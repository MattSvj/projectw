using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kursovik
{
    public partial class FormProcedure : Form
    {
        public FormProcedure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            sqlCommand1.Parameters["@Area"].Value =
            Convert.ToString(textBox1.Text);
            sqlCommand1.Parameters["@ProfessionName"].Value =
            Convert.ToString(textBox2.Text);
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();

            SqlCommand cmd = sqlConnection1.CreateCommand();
            DataGridView dgv = dataGridView1;
            sqlConnection1.Open();
            cmd.CommandText = "GetJobSeekersByAreaAndProfession";
            cmd.CommandType = CommandType.StoredProcedure;

            var parameters = new Dictionary<TextBox, string>()
                {
                    {textBox1, "@Area"},
                    {textBox2, "@ProfessionName" }
                };

            if (parameters != null)
            {
                foreach (var par in parameters)
                {
                    cmd.Parameters.AddWithValue(par.Value, par.Key.Text.ToString());
                }

      
            }

            dgv.Columns.Clear();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                List<string[]> data = new List<string[]>();
                data.Add(new string[reader.FieldCount]);
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dgv.Columns.Add(reader.GetName(i), reader.GetName(i));
                    if (reader.GetName(i) == "id")
                    {
                        //dataGridView1.Columns["id"].Visible = false;
                        dgv.Columns[0].Visible = false;
                    }
                }
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            data[data.Count - 1][i] = reader[i].ToString();
                        }
                    }
                    foreach (var s in data)
                        dgv.Rows.Add(s);
                }
            }
        }

        private void FormProcedure_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employment_agencyDataSet.Job_seeker". При необходимости она может быть перемещена или удалена.
            this.job_seekerTableAdapter.Fill(this.employment_agencyDataSet.Job_seeker);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlCommand2.Parameters["@StartDate"].Value =
            Convert.ToString(textBox3.Text);
            sqlCommand2.Parameters["@EndDate"].Value =
            Convert.ToString(textBox4.Text);
            sqlCommand2.Parameters["@ProfessionName"].Value =
            Convert.ToString(textBox5.Text);
            sqlCommand2.Parameters["@EmployerName"].Value =
            Convert.ToString(textBox6.Text);
            sqlConnection2.Open();
            sqlCommand2.ExecuteNonQuery();
            sqlConnection2.Close();

            SqlCommand cmd = sqlConnection2.CreateCommand();
            DataGridView dgv = dataGridView2;
            sqlConnection2.Open();
            cmd.CommandText = "GetEmployedDuringPeriod";
            cmd.CommandType = CommandType.StoredProcedure;

            var parameters = new Dictionary<TextBox, string>()
                {
                    {textBox3, "@StartDate"},
                    {textBox4, "@EndDate" },
                    {textBox5, "@ProfessionName" },
                    {textBox6, "@EmployerName" }
                };

            if (parameters != null)
            {
                foreach (var par in parameters)
                {
                    cmd.Parameters.AddWithValue(par.Value, par.Key.Text.ToString());
                }


            }

            dgv.Columns.Clear();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                List<string[]> data = new List<string[]>();
                data.Add(new string[reader.FieldCount]);
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dgv.Columns.Add(reader.GetName(i), reader.GetName(i));
                    if (reader.GetName(i) == "id")
                    {
                        //dataGridView1.Columns["id"].Visible = false;
                        dgv.Columns[0].Visible = false;
                    }
                }
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            data[data.Count - 1][i] = reader[i].ToString();
                        }
                    }
                    foreach (var s in data)
                        dgv.Rows.Add(s);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlConnection3.Open();
            sqlCommand3.ExecuteNonQuery();
            sqlConnection3.Close();

            SqlCommand cmd = sqlConnection3.CreateCommand();
            DataGridView dgv = dataGridView4;
            sqlConnection3.Open();
            cmd.CommandText = "GetCompaniesWithMostVacancies";
            cmd.CommandType = CommandType.StoredProcedure;

            var parameters = new Dictionary<TextBox, string>()
                {

                };

            if (parameters != null)
            {
                foreach (var par in parameters)
                {
                    cmd.Parameters.AddWithValue(par.Value, par.Key.Text.ToString());
                }


            }

            dgv.Columns.Clear();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                List<string[]> data = new List<string[]>();
                data.Add(new string[reader.FieldCount]);
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dgv.Columns.Add(reader.GetName(i), reader.GetName(i));
                    if (reader.GetName(i) == "id")
                    {
                        //dataGridView1.Columns["id"].Visible = false;
                        dgv.Columns[0].Visible = false;
                    }
                }
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            data[data.Count - 1][i] = reader[i].ToString();
                        }
                    }
                    foreach (var s in data)
                        dgv.Rows.Add(s);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlCommand4.Parameters["@StartDate"].Value =
            Convert.ToString(textBox7.Text);
            sqlCommand4.Parameters["@EndDate"].Value =
            Convert.ToString(textBox8.Text);
            sqlCommand4.Parameters["@SpecialtyName"].Value =
            Convert.ToString(textBox9.Text);
            sqlConnection4.Open();
            sqlCommand4.ExecuteNonQuery();
            sqlConnection4.Close();

            SqlCommand cmd = sqlConnection4.CreateCommand();
            DataGridView dgv = dataGridView3;
            sqlConnection4.Open();
            cmd.CommandText = "GetAvailableVacanciesByPeriodAndSpecialty";
            cmd.CommandType = CommandType.StoredProcedure;

            var parameters = new Dictionary<TextBox, string>()
                {
                    {textBox7, "@StartDate"},
                    {textBox8, "@EndDate" },
                    {textBox9, "@SpecialtyName" }
                };

            if (parameters != null)
            {
                foreach (var par in parameters)
                {
                    cmd.Parameters.AddWithValue(par.Value, par.Key.Text.ToString());
                }


            }

            dgv.Columns.Clear();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                List<string[]> data = new List<string[]>();
                data.Add(new string[reader.FieldCount]);
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dgv.Columns.Add(reader.GetName(i), reader.GetName(i));
                    if (reader.GetName(i) == "id")
                    {
                        //dataGridView1.Columns["id"].Visible = false;
                        dgv.Columns[0].Visible = false;
                    }
                }
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            data[data.Count - 1][i] = reader[i].ToString();
                        }
                    }
                    foreach (var s in data)
                        dgv.Rows.Add(s);
                }
            }
        }
    }
}
