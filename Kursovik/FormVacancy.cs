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
    public partial class FormVacancy : Form
    {
        public FormVacancy()
        {
            InitializeComponent();
        }

        private void FormVacancy_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employment_agencyDataSet.Profession". При необходимости она может быть перемещена или удалена.
            this.professionTableAdapter.Fill(this.employment_agencyDataSet.Profession);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employment_agencyDataSet.Company". При необходимости она может быть перемещена или удалена.
            this.companyTableAdapter.Fill(this.employment_agencyDataSet.Company);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employment_agencyDataSet.Vacancy". При необходимости она может быть перемещена или удалена.
            this.vacancyTableAdapter.Fill(this.employment_agencyDataSet.Vacancy);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vacancyBindingSource.EndEdit();
            this.vacancyTableAdapter.Update(this.employment_agencyDataSet.Vacancy);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            vacancyBindingSource.Filter = "ID_firm = " +
            "'" + dataGridView1[0, bb].Value + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            vacancyBindingSource.Filter = "ID_profession = " +
            "'" + dataGridView1[1, bb].Value + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            vacancyBindingSource.Filter = "Posting_date = " +
            "'" + dataGridView1[2, bb].Value + "'";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            vacancyBindingSource.Filter = "Status = " +
            "'" + dataGridView1[4, bb].Value + "'";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vacancyBindingSource.Filter = "";
        }
    }
}
