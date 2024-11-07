using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;


namespace Kursovik
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT * FROM Job_seeker;
                SELECT * FROM Company;
                SELECT * FROM Profession;
                SELECT * FROM Vacancy;
                SELECT * FROM Positions;";
            using (SqlCommand command = new SqlCommand(query, sqlConnection1))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                        saveFileDialog.Title = "Save Excel File";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            var excelApp = new Excel.Application();
                            excelApp.Visible = false;
                            Excel.Workbook workbook = excelApp.Workbooks.Add();
                            for (int i = 0; i < dataSet.Tables.Count; i++)
                            {
                                DataTable table = dataSet.Tables[i];
                                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.Add();
                                worksheet.Name = table.TableName;
                                for (int col = 0; col < table.Columns.Count; col++)
                                {
                                    worksheet.Cells[1, col + 1] = table.Columns[col].ColumnName;
                                }
                                for (int row = 0; row < table.Rows.Count; row++)
                                {
                                    for (int col = 0; col < table.Columns.Count; col++)
                                    {
                                        worksheet.Cells[row + 2, col + 1] = table.Rows[row][col];
                                    }
                                }
                            }
                            workbook.SaveAs(filePath);
                            workbook.Close();
                            excelApp.Quit();
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Job_seeker";

            // Создаем команду SQL
            using (SqlCommand command = new SqlCommand(query, sqlConnection1))
            {
                // Создаем адаптер данных
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    // Создаем DataTable для хранения данных о работниках
                    DataTable dataTable = new DataTable();

                    // Заполняем DataTable данными из таблицы Worker
                    adapter.Fill(dataTable);

                    // Открываем диалоговое окно сохранения файла
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Word documents (*.docx)|*.docx";
                        saveFileDialog.Title = "Save Word Document";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Путь к файлу, выбранный пользователем
                            string filePath = saveFileDialog.FileName;

                            // Создаем новое приложение Word
                            var wordApp = new Word.Application();
                            wordApp.Visible = false;

                            // Добавляем документ
                            Word.Document document = wordApp.Documents.Add();

                            // Добавляем таблицу в документ
                            Word.Table table = document.Tables.Add(document.Range(0, 0), dataTable.Rows.Count + 1, dataTable.Columns.Count);
                            table.Borders.Enable = 1;

                            // Заполняем заголовки столбцов
                            for (int col = 0; col < dataTable.Columns.Count; col++)
                            {
                                table.Cell(1, col + 1).Range.Text = dataTable.Columns[col].ColumnName;
                            }

                            // Заполняем данные строк
                            for (int row = 0; row < dataTable.Rows.Count; row++)
                            {
                                for (int col = 0; col < dataTable.Columns.Count; col++)
                                {
                                    table.Cell(row + 2, col + 1).Range.Text = dataTable.Rows[row][col].ToString();
                                }
                            }

                            // Сохраняем файл Word
                            document.SaveAs2(filePath);
                            document.Close();
                            wordApp.Quit();

                            // Освобождение ресурсов
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(document);
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);

                            Console.WriteLine("Data has been successfully exported to Word.");
                        }
                        else
                        {
                            Console.WriteLine("File save operation was canceled.");
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            report1.Load(@"C:\Users\matth\OneDrive\Документы\Report1.frx");
            report1.Prepare();
            report1.Show();
        }
    }
}
