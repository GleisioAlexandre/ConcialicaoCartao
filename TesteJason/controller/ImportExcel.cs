using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace TesteJason.controller
{
    class ImportExcel
    {
        public void ImportRede(string filePath, DataGridView dataGridView)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel._Worksheet worksheet = workbook.Sheets[1];
            Excel.Range range = worksheet.UsedRange;

            // Importa as linhas a partir da terceira
            for (int row = 3; row <= range.Rows.Count; row++) // Começa na linha 3
            {
                DataGridViewRow dgRow = new DataGridViewRow();
                dgRow.CreateCells(dataGridView);

                for (int col = 1; col <= range.Columns.Count; col++)
                {
                    var cellValue = (range.Cells[row, col] as Excel.Range).Value2;

                    if (col == 1 || col == 10) // Colunas de data
                    {
                        double oaDate = 0; // Inicializa a variável
                        if (cellValue != null && double.TryParse(cellValue.ToString(), out oaDate))
                        {
                            dgRow.Cells[col - 1].Value = DateTime.FromOADate(oaDate).ToString("dd/MM/yyyy");
                        }
                    }
                    else if (col == 4) // Coluna de inteiro
                    {
                        int intValue = 0; // Inicializa a variável
                        if (cellValue != null && int.TryParse(cellValue.ToString(), out intValue))
                        {
                            dgRow.Cells[col - 1].Value = intValue;
                        }
                    }
                    else if (col == 5 || col == 6 || col == 7 || col == 12) // Colunas de valor monetário
                    {
                        double moneyValue = 0; // Inicializa a variável
                        if (cellValue != null && double.TryParse(cellValue.ToString(), out moneyValue))
                        {
                            dgRow.Cells[col - 1].Value = moneyValue.ToString("C", CultureInfo.CurrentCulture);
                        }
                    }
                    else // Colunas de texto
                    {
                        dgRow.Cells[col - 1].Value = cellValue?.ToString() ?? string.Empty;
                    }
                }

                dataGridView.Rows.Add(dgRow);
            }

            workbook.Close(false);
            excelApp.Quit();
        }
        public void ImportGetnet(string filePath, DataGridView dataGridView)
        {
           
        }

        public void SomaGrid(DataGridView dataGridView)
        {
            
        }
    }
    
}
