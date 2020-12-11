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

namespace UASBAP
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtNmrAkun.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, nomor akun tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNmrAkun.Focus();
            }
            else if (this.txtNmrSub.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, nomor subakun tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNmrSub.Focus();
            }
            else if (this.txtNamaTransaksi.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, nama transaksi tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNamaTransaksi.Focus();
            }
            else if (this.txtHarga.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, harga tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtHarga.Focus();
            }
            else
            {
                try
                {
                    using (var conn = new Connection().CreateAndOpenConnection())
                    {
                        using (var cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            
                            cmd.CommandText =
                                @"Insert Into Transaksi Values(@NomorAkun, @NomorSubAkun, @NamaTransaksi, @Jumlah, @Tanggal)";
                            cmd.Parameters.Clear();
                            int akun = int.Parse(this.txtNmrAkun.Text.Trim());
                            int subakun = int.Parse(this.txtNmrSub.Text.Trim());
                            int harga = int.Parse(this.txtHarga.Text.Trim());
                            DateTime tgl = DateTime.Parse(this.tanggal.Value.ToString());
                            cmd.Parameters.AddWithValue("@NomorAkun", akun);
                            cmd.Parameters.AddWithValue("@NomorSubAkun", subakun);
                            cmd.Parameters.AddWithValue("@NamaTransaksi", this.txtNamaTransaksi.Text.Trim());
                            cmd.Parameters.AddWithValue("@Jumlah", harga);
                            cmd.Parameters.AddWithValue("@Tanggal",tgl);
                            int recAffeced = cmd.ExecuteNonQuery();
                            if (recAffeced > 0)
                            {
                                this.btnClear_Click(null, null);
                                this.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void frmAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtNmrAkun.Clear();
            this.txtNmrSub.Clear();
            this.txtNamaTransaksi.Clear();
            this.txtHarga.Clear();
            this.tanggal.Value = DateTime.Today;
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

        private void tanggal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtNmrAkun_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == ' ' || e.KeyChar == '(' || e.KeyChar == ')') e.Handled = false;
        }

        private void txtHarga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            if(txtHarga.Text != "")
            {
                Bilangan bil = new Bilangan();
                biayahuruf.Text = "( " + bil.Terbilang(Convert.ToInt64(txtHarga.Text)) + " Rupiah)";
            }
        }
    }
}
