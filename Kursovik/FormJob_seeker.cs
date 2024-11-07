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
    public partial class FormJob_seeker : Form
    {
        public FormJob_seeker()
        {
            InitializeComponent();
        }

        private void FormJob_seeker_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employment_agencyDataSet.Profession". При необходимости она может быть перемещена или удалена.
            this.professionTableAdapter.Fill(this.employment_agencyDataSet.Profession);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employment_agencyDataSet.Job_seeker". При необходимости она может быть перемещена или удалена.
            this.job_seekerTableAdapter.Fill(this.employment_agencyDataSet.Job_seeker);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jobseekerBindingSource.EndEdit();
            this.job_seekerTableAdapter.Update(this.employment_agencyDataSet.Job_seeker);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            jobseekerBindingSource.Filter = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            jobseekerBindingSource.Filter = "Application_date = " +
            "'" + dataGridView1[6, bb].Value + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            jobseekerBindingSource.Filter = "Area = " +
            "'" + dataGridView1[9, bb].Value + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            jobseekerBindingSource.Filter = "Status = " +
            "'" + dataGridView1[7, bb].Value + "'";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            jobseekerBindingSource.Filter = "ID_profession = " +
            "'" + dataGridView1[8, bb].Value + "'";
        }
    }
}
