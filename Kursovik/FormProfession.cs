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
    public partial class FormProfession : Form
    {
        public FormProfession()
        {
            InitializeComponent();
        }

        private void FormProfession_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employment_agencyDataSet.Profession". При необходимости она может быть перемещена или удалена.
            this.professionTableAdapter.Fill(this.employment_agencyDataSet.Profession);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professionBindingSource.EndEdit();
            this.professionTableAdapter.Update(this.employment_agencyDataSet.Profession);
        }
    }
}
