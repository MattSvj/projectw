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
    public partial class FormPositions : Form
    {
        public FormPositions()
        {
            InitializeComponent();
        }

        private void FormPositions_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employment_agencyDataSet.Vacancy". При необходимости она может быть перемещена или удалена.
            this.vacancyTableAdapter.Fill(this.employment_agencyDataSet.Vacancy);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employment_agencyDataSet.Job_seeker". При необходимости она может быть перемещена или удалена.
            this.job_seekerTableAdapter.Fill(this.employment_agencyDataSet.Job_seeker);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employment_agencyDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.employment_agencyDataSet.Positions);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.positionsBindingSource.EndEdit();
            this.positionsTableAdapter.Update(this.employment_agencyDataSet.Positions);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            positionsBindingSource.Filter = "ID_vacancy = " +
            "'" + dataGridView1[1, bb].Value + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            positionsBindingSource.Filter = "Hire_date = " +
            "'" + dataGridView1[2, bb].Value + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            positionsBindingSource.Filter = "Job_title = " +
            "'" + dataGridView1[3, bb].Value + "'";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            positionsBindingSource.Filter = "";
        }
    }
}
