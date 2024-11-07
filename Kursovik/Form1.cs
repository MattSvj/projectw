using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void соискательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJob_seeker myForm2 = new FormJob_seeker();
            myForm2.Show();
        }

        private void фирмаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompany myForm3 = new FormCompany();
            myForm3.Show();
        }

        private void профессияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfession myForm4 = new FormProfession();
            myForm4.Show();
        }

        private void вакансияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVacancy myForm5 = new FormVacancy();
            myForm5.Show();
        }

        private void поToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPositions myForm6 = new FormPositions();
            myForm6.Show();
        }

        private void работаСПроцедурамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProcedure myForm7 = new FormProcedure();
            myForm7.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormJob_seeker myForm2 = new FormJob_seeker();
            myForm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCompany myForm3 = new FormCompany();
            myForm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormProfession myForm4 = new FormProfession();
            myForm4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormVacancy myForm5 = new FormVacancy();
            myForm5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormPositions myForm6 = new FormPositions();
            myForm6.Show();
        }

        private void отчётыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports myForm7 = new Reports();
            myForm7.Show();
        }
    }
}
