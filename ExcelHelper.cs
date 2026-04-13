using ClosedXML.Excel;
using System;
using System.Data;

namespace miniPOS
{
    public static class ExcelHelper
    {
        public static void ExportToExcel(DataTable dt, string formName)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel (*.xlsx)|*.xlsx";
                sfd.FileName = formName;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var ws = wb.Worksheets.Add(dt, formName);

                            ws.Row(1).Style.Font.Bold = true;
                            ws.Columns().AdjustToContents();

                            wb.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Datos exportados exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar datos: " + ex.Message);
                    }
                }
            }
        }
    }
}
