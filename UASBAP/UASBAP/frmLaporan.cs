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
using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;
using Dapper;
namespace UASBAP
{
    public partial class frmLaporan : Form
    {
        public int NomorTransaksi;
        private DataLaporan set = new DataLaporan("", "", "", "", "", default, default, default, "");
        public frmLaporan(string NamaAdmin)
        {
            InitializeComponent();
            this.NamaAdmin.Text = NamaAdmin;
            this.dgvData.AutoGenerateColumns = false;
            this.lblFilter.Text = "";
        }
        private void frmLaporan_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadData(string query)
        {
            this.dgvData.Rows.Clear();
            try
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        if (query == null)
                        {
                            cmd.CommandText = @"SELECT M.NomorTransaksi, K.NomorAkun, L.NomorSubAkun, M.NamaTransaksi, K.TipeAkun, 
                                                K.JenisAkun, Convert(varchar, M.Tanggal, 23) as Tanggal, M.Jumlah, L.NamaSubAkun FROM Akun K 
                                                INNER JOIN SubAkun L ON K.NomorAkun = L.NomorAkun 
                                                INNER JOIN Transaksi M ON L.NomorSubAkun = M.NomorSubAkun ";
                        }
                        else
                        {
                            cmd.CommandText = query;
                        }
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                int huruf = 0;
                                string hargaakhir;
                                while (reader.Read())
                                {
                                    decimal nominalrupiah, totalharga = 0;
                                    string harga;
                                    string rupiah = "";
                                    nominalrupiah = decimal.Parse(reader["Jumlah"].ToString());
                                    harga = nominalrupiah.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
                                    this.dgvData.Rows.Add(new string[] {
                                            reader["NomorTransaksi"].ToString(),
                                            reader["NomorAkun"].ToString(),
                                            reader["NomorSubAkun"].ToString(),
                                            reader["TipeAkun"].ToString(),
                                            reader["JenisAkun"].ToString(),
                                            reader["NamaTransaksi"].ToString(),
                                            reader["Tanggal"].ToString(),
                                            harga,
                                            reader["Jumlah"].ToString(),
                                            reader["NamaSubAkun"].ToString(),
                                            });
                                    for (int i = 0; i < dgvData.RowCount; i++)
                                    {
                                        var value = dgvData.Rows[i].Cells[8].Value;
                                        if (value != DBNull.Value)
                                        {
                                            totalharga += Convert.ToDecimal(value);
                                            huruf += Convert.ToInt32(value);
                                        }
                                    };
                                    rupiah = totalharga.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
                                    lblTotal.Text = rupiah;
                                    huruf = Convert.ToInt32(totalharga);
                                }
                                hargaakhir = huruf.ToString();
                                Bilangan bil = new Bilangan();
                                biayahuruf.Text = "( " + bil.Terbilang(Convert.ToInt64(hargaakhir)) + " Rupiah)";
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            var form = new frmFilter(set);
            var returnvalue = form.RunAndReturnObjectDataLaporan(form);
            if (returnvalue != null)
            {
                DateTime tgl_from = Convert.ToDateTime(returnvalue.Tanggal_From.Value);
                DateTime tgl_to = Convert.ToDateTime(returnvalue.Tanggal_To.Value);
                string nomorakun = returnvalue.NomorAkun;
                string nomorsubakun = returnvalue.NomorSubAkun;
                string tipeakun = returnvalue.TipeAkun;
                string jenisakun = returnvalue.JenisAkun;
                string namatransaksi = returnvalue.NamaTransaksi;
                string query = @"SELECT M.NomorTransaksi, K.NomorAkun, L.NomorSubAkun, M.NamaTransaksi, K.TipeAkun, 
                                K.JenisAkun, M.Jumlah, L.NamaSubAkun, M.Tanggal FROM Akun K 
                                INNER JOIN SubAkun L ON K.NomorAkun = L.NomorAkun 
                                INNER JOIN Transaksi M ON L.NomorSubAkun = M.NomorSubAkun 
                                where K.NomorAkun like '" + nomorakun + "%' " +
                                "and L.NomorSubAkun like '" + nomorsubakun + "%' and M.NamaTransaksi like '" + namatransaksi + "%'  " +
                                "and K.TipeAkun like '" + tipeakun + "%'" +
                                "and M.Tanggal between '"  + tgl_from.ToString("yyyy-MM-dd") +  "' and '" + tgl_to.ToString("yyyy-MM-dd")  + "' ";
                LoadData(query);
                lblFilter.Text = $"Filter By : Nomor Akun  : {nomorakun}.  Nomor SubAkun : {nomorsubakun}. " +
                                 $"Nama Transaksi : {namatransaksi}. " + $"Tipe Akun : {tipeakun}. " +
                                 $"Tanggal Dari : {tgl_from.ToString("yyyy-MM-dd")}. Tanggal Ke : {tgl_to.ToString("yyyy-MM-dd")}";
                set.NomorAkun = nomorakun;
                set.NomorSubAkun = nomorsubakun;
                set.NamaTransaksi = namatransaksi;
                set.TipeAkun = tipeakun;
                set.Tanggal_From = tgl_from;
                set.Tanggal_To = tgl_to;
            }

        }
        private void dgvData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int record = dgvData.Rows.Count;
            lblBanyakRecordData.Text = record + " Record";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvData_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvData.CurrentRow != null)
            {
                var row = this.dgvData.CurrentRow;
                frmFilter form = new frmFilter(set);
                var returnValue = form.RunAndReturnObjectDataLaporan(form);
                if (returnValue != null)
                {
                    row.Cells[1].Value = returnValue.NomorAkun;
                    row.Cells[2].Value = returnValue.NomorSubAkun;
                    row.Cells[3].Value = returnValue.TipeAkun;
                    row.Cells[5].Value = returnValue.NamaTransaksi;
                    row.Cells[6].Value = Convert.ToDateTime(returnValue.Tanggal_From.Value);
                    row.Cells[8].Value = returnValue.Jumlah;
                }
            }
        }
        private void hapusLaporanToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.dgvData.CurrentRow != null)
            {
                if (MessageBox.Show("Hapus Data Ini ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var conn = new Connection().CreateAndOpenConnection())
                    {
                        using (var cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            try
                            {
                                DataGridViewRow row = this.dgvData.CurrentRow;
                                NomorTransaksi = Convert.ToInt32(row.Cells[0].Value);
                                string NomorAkun = row.Cells[1].Value.ToString().Trim();
                                string NomorSubAkun = row.Cells[2].Value.ToString().Trim();
                                string NamaTransaksi = row.Cells[5].Value.ToString().Trim();
                                int Jumlah = Convert.ToInt32(row.Cells[8].Value);
                                DateTime Tanggal = Convert.ToDateTime(row.Cells[6].Value);
                                cmd.CommandText = "DELETE Transaksi where NomorTransaksi = @NomorTransaksi";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@NomorAkun", NomorAkun);
                                cmd.Parameters.AddWithValue("@NomorSubAkun", NomorSubAkun);
                                cmd.Parameters.AddWithValue("@NamaTransaksi", NamaTransaksi);
                                cmd.Parameters.AddWithValue("@Jumlah", Jumlah);
                                cmd.Parameters.AddWithValue("@Tanggal", Tanggal);
                                cmd.Parameters.AddWithValue("@NomorTransaksi", this.NomorTransaksi);
                                int recAffeced = cmd.ExecuteNonQuery();
                                if (recAffeced > 0)
                                {
                                    LoadData(null);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                }
            }
        }
        private void btnLaporan_Click(object sender, EventArgs e)
        {
            if (this.dgvData.Rows.Count > 0)
            {
                List<DataLaporan> listData = new List<DataLaporan>();
                foreach (DataGridViewRow row in this.dgvData.Rows)
                {
                    string nomorakun = row.Cells[1].Value.ToString().Trim();
                    string nomorsubakun = row.Cells[2].Value.ToString().Trim();
                    string tipeakun = row.Cells[3].Value.ToString().Trim();
                    string jenisakun = row.Cells[4].Value.ToString().Trim();
                    string namasub = row.Cells[9].Value.ToString().Trim();
                    string namatransaksi = row.Cells[5].Value.ToString().Trim();
                    int jumlah = Convert.ToInt32(row.Cells[8].Value);
                    DateTime tgl_to = Convert.ToDateTime(row.Cells[6].Value);
                    DateTime tgl_from = Convert.ToDateTime(row.Cells[6].Value);
                    listData.Add(new DataLaporan(nomorakun, nomorsubakun, tipeakun, jenisakun, namatransaksi, tgl_to, tgl_from, jumlah, namasub)
                    {
                        NomorAkun = nomorakun,
                        NomorSubAkun = nomorsubakun,
                        TipeAkun = tipeakun,
                        JenisAkun = jenisakun,
                        NamaTransaksi = namatransaksi,
                        Tanggal_To = tgl_to,
                        Tanggal_From = tgl_from,
                        Jumlah = jumlah,
                        NamaSubAkun = namasub,
                    });
                }
                frmReportLaporan form = new frmReportLaporan(listData);
                form.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new frmAdd();
            form.ShowDialog();
            LoadData(null);
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            var form = new frmExcel(set);
            var returnvalue = form.RunAndReturnObjectDataLaporan(form);
            if (returnvalue != null)
            {
                DateTime tgl_from = Convert.ToDateTime(returnvalue.Tanggal_From.Value);
                DateTime tgl_to = Convert.ToDateTime(returnvalue.Tanggal_To.Value);
                set.Tanggal_From = tgl_from;
                set.Tanggal_To = tgl_to;
            }
        }
    }
}
