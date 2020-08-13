using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Book
{
    public partial class Form1 : Form
    {
        //коллекция с личными данными человека
        List<PersonDat> pers = new List<PersonDat>();

        //коллекция с данными о местах работы людей
        List<WorkDat> workPlaces = new List<WorkDat>();

        //коллекция для хранения выборки о местах работы конкретного человека для виртуального списка
        List<WorkDat> result2 = new List<WorkDat>();

        public Form1()
        {
            InitializeComponent();
        }

        //кнопка "Добавить работника"
        private void addWorker_Click(object sender, EventArgs e)
        {
            PersonDat p = new PersonDat();
            p.RegDate = DateTime.Now;
            p.Bday = DateTime.Now;
            PersonData newWorker = new PersonData(p);
            if (newWorker.ShowDialog() == DialogResult.OK)
                pers.Add(p);
            personsListView1.VirtualListSize = pers.Count;
            personsListView1.Invalidate();
        }

        //двойной клик на работнике в виртуальном списке ("Отредактировать")
        private void personsListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (SelNo())
                return;
            PersonDat p = pers[personsListView1.FocusedItem.Index];
            PersonData editForm = new PersonData(p);
            if (editForm.ShowDialog() == DialogResult.OK)
                personsListView1.Invalidate();
        }

        //кнопка "Удалить работника"
        private void delWorker_Click(object sender, EventArgs e)
        {
            if (SelNo())
                return;
            if (MessageBox.Show("Вы действительно хотите удалить работника?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                return;
            int selIndex = personsListView1.FocusedItem.Index;

            workPlaces.RemoveAll(i => i.WorkWorkerID == pers[selIndex].PersNumb);
            pers.Remove(pers[selIndex]);


            personsListView1.VirtualListSize = pers.Count;
            personsListView1.Invalidate();
            workPlacesListView1.VirtualListSize = 0;
        }

        //кнопка "Добавить место работы"
        private void addWorkPlace_Click(object sender, EventArgs e)
        {
            if (SelNo())
                return;
            WorkDat w = new WorkDat();
            w.WorkWorkerID = pers[personsListView1.FocusedItem.Index].PersNumb;
            WorkDataNew newWorkPlaces = new WorkDataNew(w);
            if (newWorkPlaces.ShowDialog() == DialogResult.OK)
                workPlaces.Add(w);

            RefresherWP(personsListView1.FocusedItem.Index);
        }

        //кнопка "Удалить место работы"
        private void deleteWorkPlace_Click(object sender, EventArgs e)
        {
            if (SelNoWork())
                return;
            if (MessageBox.Show("Вы действительно хотите удалить место работы?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                return;

            int selIndexWorker = personsListView1.FocusedItem.Index;
            int selIndexWork = workPlacesListView1.FocusedItem.Index;

            result2 = (workPlaces.FindAll(i => i.WorkWorkerID == pers[selIndexWorker].PersNumb));
            workPlaces.Remove(result2[selIndexWork]);

            RefresherWP(personsListView1.FocusedItem.Index);
        }

        //двойной клик на месте работы в виртуальном списке ("Отредактировать")
        private void workPlacesListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (SelNo())
                return;
            WorkDat w = result2[workPlacesListView1.FocusedItem.Index];
            WorkDataNew editForm = new WorkDataNew(w);
            if (editForm.ShowDialog() == DialogResult.OK)
                RefresherWP(personsListView1.FocusedItem.Index);
        }

        //клик на работнике ("Обновление мест работы в виртуальном списке")
        private void personsListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            RefresherWP(personsListView1.FocusedItem.Index);
        }

        //инвалидация виртуального списка работников
        private void workPlacesListView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < result2.Count)
            {
                e.Item = new ListViewItem(result2[e.ItemIndex].WorkPlaceNumb);
                e.Item.SubItems.Add(result2[e.ItemIndex].WorkDateIn.ToString("dd/MM/yyyy"));
                e.Item.SubItems.Add(result2[e.ItemIndex].WorkPlace);
                e.Item.SubItems.Add(result2[e.ItemIndex].WorkStatus);
                e.Item.SubItems.Add(result2[e.ItemIndex].WorkInDocument);
                e.Item.SubItems.Add(result2[e.ItemIndex].WorkAddInfo);
                e.Item.SubItems.Add(result2[e.ItemIndex].WorkDateOut.ToString("dd/MM/yyyy"));
                e.Item.SubItems.Add(result2[e.ItemIndex].WorkOutReason);
                e.Item.SubItems.Add(result2[e.ItemIndex].WorkOutDocument);
            }
        }

        //инвалидация виртуального списка мест работы
        private void personsListView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < pers.Count)
            {
                e.Item = new ListViewItem(pers[e.ItemIndex].SurName);
                e.Item.SubItems.Add(pers[e.ItemIndex].Name);
                e.Item.SubItems.Add(pers[e.ItemIndex].Otch);
                e.Item.SubItems.Add(pers[e.ItemIndex].Bday.ToString("dd/MM/yyyy"));
            }
        }

        //загрузка формы (подхват данных с xml-файлов и обновление виртуального списка)
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlSerializer xmlFormatP = new XmlSerializer(typeof(List<PersonDat>));
            XmlSerializer xmlFormatW = new XmlSerializer(typeof(List<WorkDat>));
            try
            {
                using (FileStream fStream = new FileStream("PersonCollection.xml", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                {
                    pers.AddRange((List<PersonDat>)xmlFormatP.Deserialize(fStream));
                }
                using (FileStream fStream = new FileStream("WorkPlaceCollection.xml", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                {
                    workPlaces.AddRange((List<WorkDat>)xmlFormatW.Deserialize(fStream));
                }
            }
            catch
            {
                MessageBox.Show("Данные отсутствуют.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            personsListView1.VirtualListSize = pers.Count;
            personsListView1.Invalidate();
        }

        //закрытие формы (сохранение данных в xml-файлы)
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FileStream fStream = new FileStream("PersonCollection.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<PersonDat>));
                xmlFormat.Serialize(fStream, pers);
            }

            using (FileStream fStream1 = new FileStream("WorkPlaceCollection.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<WorkDat>));
                xmlFormat.Serialize(fStream1, workPlaces);
            }
        }

        //клик на колонку в виртуальном списке работников ("Сортировка")
        private void personsListView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                pers.Sort((emp1, emp2) => emp1.SurName.CompareTo(emp2.SurName));
                personsListView1.Invalidate();
                return;
            }
            else if (e.Column == 1)
            {
                pers.Sort((emp1, emp2) => emp1.Name.CompareTo(emp2.Name));
                personsListView1.Invalidate();
                return;
            }
        }

        //обновление виртуального списка мест работы
        private void RefresherWP(int index)
        {
            if (SelNo())
                return;
            result2 = (workPlaces.FindAll(i => i.WorkWorkerID == pers[index].PersNumb));
            workPlacesListView1.VirtualListSize = workPlaces.Count(p => p.WorkWorkerID == pers[index].PersNumb);
            workPlacesListView1.Invalidate();
        }

        //проверка на то, что выделен какой-нибудь работник в виртуальном списке
        private bool SelNo ()
        {
            bool ok = false;
            if (personsListView1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Вы не выбрали ни одного работника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = true;
            }
            if (personsListView1.SelectedIndices.Count > 1)
            {
                MessageBox.Show("Вы выбрали больше одного работника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = true;
            }
            return ok;
        }

        //проверка на то, что выделено какое-нибудь место работы в виртуальном списке
        private bool SelNoWork()
        {
            bool ok = false;
            if (workPlacesListView1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Вы не выбрали место работы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = true;
            }
            if (workPlacesListView1.SelectedIndices.Count > 1)
            {
                MessageBox.Show("Вы выбрали несколько мест работы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = true;
            }
            return ok;
        }

        // если работник не выбран, то виртуальный список мест работы обнуляется
        private void personsListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (personsListView1.SelectedIndices.Count == 0)
                workPlacesListView1.VirtualListSize = 0;
        }
    }
}
