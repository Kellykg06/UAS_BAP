using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UASBAP
{
    public partial class frmReportLaporan : Form
    {
        private List<DataLaporan> _lisData = null;
        public frmReportLaporan(List<DataLaporan> listData)
        {
            InitializeComponent();
            _lisData = listData;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                if (_lisData != null && _lisData.Any())
                {
                    DataSetLaporan ds = new DataSetLaporan();
                    foreach (var item in _lisData)
                    {
                        var newRow = ds.DataLaporan.NewDataLaporanRow();
                        newRow.NomorAkun = item.NomorAkun;
                        newRow.NomorSubAkun = item.NomorSubAkun;
                        newRow.JenisAkun = item.JenisAkun;
                        newRow.TipeAkun = item.TipeAkun;
                        newRow.NamaTransaksi = item.NamaTransaksi;
                        newRow.Jumlah = Convert.ToInt32(item.Jumlah);
                        newRow.Tanggal = Convert.ToDateTime(item.Tanggal_From);
                        newRow.NamaSubAkun = item.NamaSubAkun;
                        ds.DataLaporan.AddDataLaporanRow(newRow);
                    }
                    RptLaporan rpt = new RptLaporan();
                    rpt.SetDataSource(ds);
                    this.crystalReportViewer1.ReportSource = rpt;
                }
                else
                {
                    MessageBox.Show("Sorry, Minimal Harus Ada Satu Kriteria..", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
