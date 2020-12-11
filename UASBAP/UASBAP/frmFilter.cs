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

namespace UASBAP
{
    public partial class frmFilter : Form
    {
        private DataLaporan _obj = null;
        public DataLaporan RunAndReturnObjectDataLaporan(frmFilter form)
        {
            form.ShowDialog();
            return _obj;
        }

        public frmFilter(DataLaporan set)
        {
            InitializeComponent(); 
            if (cboTanggal.Text == "")
            {
                this.tanggal_From.Enabled = false;
                this.tanggal_To.Enabled = false;
            }
            else if (cboTanggal.Text == "Mingguan")
            {
                this.tanggal_From.Enabled = false;
                this.tanggal_To.Enabled = false;
                this.tanggal_From.Value = DateTime.Today;
                this.tanggal_To.Value = DateTime.Now.AddDays(7);
            }
            else if (cboTanggal.Text == "Bulanan")
            {
                this.tanggal_From.Enabled = false;
                this.tanggal_To.Enabled = false;
                this.tanggal_From.Value = DateTime.Today;
                this.tanggal_To.Value = DateTime.Now.AddDays(30);
            }
            else
            {
                this.tanggal_From.Enabled = true;
                this.tanggal_To.Enabled = true;
            }
            DateTime Tanggal_From = Convert.ToDateTime(tanggal_From.Value);
            DateTime Tanggal_To = Convert.ToDateTime(tanggal_To.Value);
            this.txtNmrAkun.Text = set.NomorAkun;
            this.txtNmrSub.Text = set.NomorSubAkun;
            this.cboTipe.SelectedItem = set.TipeAkun;
            this.txtNamaTransaksi.Text = set.NamaTransaksi;
            if (set.Tanggal_From.HasValue)
            {
                Tanggal_From = set.Tanggal_From.Value.Date;
            }
            if (set.Tanggal_To.HasValue)
            {
                Tanggal_To = set.Tanggal_To.Value.Date;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime Tanggal_From = Convert.ToDateTime(tanggal_From.Value);
            DateTime Tanggal_To = Convert.ToDateTime(tanggal_To.Value);
            _obj = new DataLaporan
            (
                this.txtNmrAkun.Text.Trim(),
                this.txtNmrSub.Text.Trim(),
                this.cboTipe.Text.ToString().Trim(),
                null,
                this.txtNamaTransaksi.Text.Trim(),
                Tanggal_From,
                Tanggal_To,
                null,
                null
            );
            this.Close();

        }
        private void frmFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtNmrAkun.Clear();
            this.txtNmrSub.Clear();
            this.cboTipe.SelectedIndex = -1;
            this.txtNamaTransaksi.Clear();
            this.cboTanggal.SelectedIndex = -1;
            this.tanggal_From.Enabled = false;
            this.tanggal_To.Enabled = false;
        }
        private void txtNmrAkun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }

        private void txtNmrSub_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }

        private void txtNamaTransaksi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }

        private void cboTipe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTanggal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTanggal.Text == "")
            {
                this.tanggal_From.Enabled = false;
                this.tanggal_To.Enabled = false;
            }
            else if (cboTanggal.Text == "Mingguan")
            {
                this.tanggal_From.Enabled = false;
                this.tanggal_To.Enabled = false;
                this.tanggal_From.Value = DateTime.Today;
                this.tanggal_To.Value = DateTime.Now.AddDays(7);
            }
            else if (cboTanggal.Text == "Bulanan")
            {
                this.tanggal_From.Enabled = false;
                this.tanggal_To.Enabled = false;
                this.tanggal_From.Value = DateTime.Today;
                this.tanggal_To.Value = DateTime.Now.AddDays(30);
            }
            else
            {
                this.tanggal_From.Enabled = true;
                this.tanggal_To.Enabled = true;
            }
        }

        private void txtNmrAkun_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == ' ' || e.KeyChar == '(' || e.KeyChar == ')') e.Handled = false;
        }
    }
}
