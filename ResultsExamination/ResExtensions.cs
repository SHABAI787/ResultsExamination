using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultsExamination
{
   public static class ResExtensions
    {
        public static void ExportToExcel(this DataGridView dataGridView)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                ExcelApp.Columns[i + 1].ColumnWidth = ((DataGridViewColumn)dataGridView.Columns[i]).HeaderText.Length;
                ExcelApp.Cells[1, i + 1] = ((DataGridViewColumn)dataGridView.Columns[i]).HeaderText;
            }

            string value;
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView.RowCount; j++)
                {
                    value = dataGridView[i, j].Value == null ? "" : dataGridView[i, j].Value.ToString();
                    ExcelApp.Cells[j + 2, i + 1] = value;
                }
            }
            ExcelApp.Visible = true;
        }
    }
}
