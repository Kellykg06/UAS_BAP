using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Dapper;
using System.Data.SqlClient;
using System.Globalization;

namespace UASBAP
{
    public partial class frmExcel : Form
    {
        private DataLaporan _obj = null;
        public DataLaporan RunAndReturnObjectDataLaporan(frmExcel form)
        {
            form.ShowDialog();
            return _obj;
        }
        public frmExcel(DataLaporan set)
        {
            InitializeComponent();
            DateTime Tanggal_From = Convert.ToDateTime(tanggal_From.Value);
            DateTime Tanggal_To = Convert.ToDateTime(tanggal_To.Value);
            if (set.Tanggal_From.HasValue)
            {
                Tanggal_From = set.Tanggal_From.Value.Date;
            }
            if (set.Tanggal_To.HasValue)
            {
                Tanggal_To = set.Tanggal_To.Value.Date;
            }
        }
        string connString = @"Data Source=.\sqlexpress; Initial Catalog=DB_UAS; Integrated Security=True;";

        private List<DataAkun> listAkun = null;
        private List<DataAkun> GetListAllDataDataAkun()
        {
            IEnumerable<DataAkun> listAkun = null;
            try
            {
                using (var conn = new SqlConnection(connString))
                {
                    DateTime tgl_from = Convert.ToDateTime(this.tanggal_From.Value);
                    DateTime tgl_to = Convert.ToDateTime(this.tanggal_To.Value);
                    listAkun = conn.Query<DataAkun>(@"SELECT K.NamaAkun, M.NomorAkun, L.NomorSubAkun, M.NamaTransaksi, K.TipeAkun,
                                    M.Jumlah, M.Tanggal, L.NamaSubAkun FROM Akun K 
                                INNER JOIN SubAkun L ON K.NomorAkun = L.NomorAkun 
                                INNER JOIN Transaksi M ON L.NomorSubAkun = M.NomorSubAkun
                                where M.Tanggal between '" + tgl_from.ToString("yyyy-MM-dd") + "' and '" + tgl_to.ToString("yyyy-MM-dd") + "' order by K.NomorAkun");

                }
            }
            catch (Exception)
            {
                throw;
            }
            return listAkun?.ToList() ?? null;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            listAkun = GetListAllDataDataAkun();
            DateTime tgl_from = Convert.ToDateTime(this.tanggal_From.Value);
            DateTime tgl_to = Convert.ToDateTime(this.tanggal_To.Value);
            if (listAkun != null && listAkun.Any())
            {
                try
                {
                    Excel.Application app = new Excel.Application();

                    Excel.Workbook book = app.Workbooks.Add();

                    Excel.Worksheet sheet = book.ActiveSheet as Excel.Worksheet;

                    app.Visible = true;
                    app.WindowState = Excel.XlWindowState.xlMaximized;

                    int barisHeader = 3;
                    sheet.Cells[1, 1] = "Data Laporan Periode " + tgl_from.ToString("dd/MM/yyy") + " Sampai " + tgl_to.ToString("dd/MM/yyy");
                    sheet.Cells[barisHeader, 1] = "Nomor";
                    sheet.Cells[barisHeader, 2] = "Kode";
                    sheet.Cells[barisHeader, 3] = "Tanggal";
                    sheet.Cells[barisHeader, 4] = "NamaTransaksi";
                    sheet.Cells[barisHeader, 5] = "Harga";
                    sheet.Range[$"A{barisHeader}", $"E{barisHeader}"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Range[$"A{barisHeader}", $"E{barisHeader}"].Font.Bold = true;
                    int sum = 0;
                    decimal nominalrupiah;
                    string harga;
                    int baris = 4;
                    for (int i = 0; i < listAkun.Count; i++)
                    {
                        nominalrupiah = decimal.Parse(listAkun[i].Jumlah.ToString());
                        harga = nominalrupiah.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
                        sheet.Cells[baris, 1] = i + 1;
                        sheet.Cells[baris, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[baris, 2] = listAkun[i].NomorAkun + " - " + listAkun[i].NomorSubAkun;
                        sheet.Cells[baris, 3] = listAkun[i].Tanggal;
                        sheet.Cells[baris, 4] = listAkun[i].NamaTransaksi;
                        sheet.Cells[baris, 5] = harga;
                        sum += Convert.ToInt32(listAkun[i].Jumlah);
                        sheet.Cells[baris, 3].EntireColumn.Numberformat = "dd/MM/yyyy";
                        baris++;
                    }
                    harga = sum.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
                    sheet.Cells[baris, 5] = harga;
                    sheet.Cells[baris, 1] = "TOTAL SEMUA BIAYA";
                    sheet.Range[$"A{baris}", $"E{baris}"].Font.Bold = true;
                    sheet.Range[$"A{baris}", $"D{baris}"].MergeCells = true;
                    sheet.Range[$"A{baris}", $"E{baris}"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    sheet.Range["A1", "E1"].Font.Bold = true;
                    sheet.Range["A1", "E1"].MergeCells = true;
                    sheet.Range["A1", "E1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Range[$"A{barisHeader}", $"E{5 + listAkun.Count - 1}"].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    sheet.Columns.AutoFit();
                    sheet.Rows.AutoFit();
                    sheet.Name = "Laporan";
                    app.UserControl = true;
                    book.Password = "123456";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
