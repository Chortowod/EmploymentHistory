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
    public partial class WorkDataNew : Form
    {
        WorkDat w;

        public WorkDataNew()
        {
            InitializeComponent();
        }

        public WorkDataNew(WorkDat w)
        {
            InitializeComponent();
            this.w = w;
            textBox1.Text = w.WorkPlaceNumb;
            dateTimePicker1.Value = DateTime.Now;
            textBox2.Text = w.WorkPlace;
            textBox3.Text = w.WorkStatus;
            textBox4.Text = w.WorkInDocument;
            textBox5.Text = w.WorkAddInfo;
            dateTimePicker2.Value = DateTime.Now;
            textBox6.Text = w.WorkOutReason;
            textBox7.Text = w.WorkOutDocument;
            label10.Text = w.WorkWorkerID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            w.WorkPlaceNumb = textBox1.Text;
            w.WorkDateIn = dateTimePicker1.Value;
            w.WorkPlace = textBox2.Text;
            w.WorkStatus = textBox3.Text;
            w.WorkInDocument = textBox4.Text;
            w.WorkAddInfo = textBox5.Text;
            w.WorkDateOut = dateTimePicker2.Value;
            w.WorkOutReason = textBox6.Text;
            w.WorkOutDocument = textBox7.Text;
        }
    }
}
