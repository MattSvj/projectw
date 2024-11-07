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
    public partial class FormCompany : Form
    {
        public FormCompany()
        {
            InitializeComponent();
        }

        private void FormCompany_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employment_agencyDataSet.Company". При необходимости она может быть перемещена или удалена.
            this.companyTableAdapter.Fill(this.employment_agencyDataSet.Company);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companyBindingSource.EndEdit();
            this.companyTableAdapter.Update(this.employment_agencyDataSet.Company);
        }
    }
}
