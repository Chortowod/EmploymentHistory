using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book
{
    public partial class PersonData : Form
    {

        PersonDat p;

        public bool checkwind = false;

        public PersonData()
        {
            InitializeComponent();
        }

        public PersonData(PersonDat p)
        {
            InitializeComponent();
            this.p = p;
            textSurname.Text = p.SurName;
            textName.Text = p.Name;
            textOtch.Text = p.Otch;
            dateBday.Value = p.Bday;
            comboEduc.Text = p.Educ;
            textProf.Text = p.Prof;
            dateReg.Value = p.RegDate;
            textPersnumb.Text = p.PersNumb.ToString();
        }

        private void saveParsonData_Click(object sender, EventArgs e)
        {
            p.SurName = textSurname.Text;
            p.Name = textName.Text;
            p.Otch = textOtch.Text;
            p.Bday = dateBday.Value;
            p.Educ = comboEduc.Text;
            p.Prof = textProf.Text;
            p.RegDate = dateReg.Value;
            p.PersNumb = Guid.NewGuid();
        }
    }
}
