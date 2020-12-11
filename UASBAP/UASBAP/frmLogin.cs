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

namespace UASBAP
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (this.txtIDAdmin.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, ID Admin Wajib DiIsi ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtIDAdmin.Focus();
            }
            else if (txtPassAdmin.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Password User Wajib DiIsi ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPassAdmin.Focus();
            }
            else
            {
                string IDAdmin = this.txtIDAdmin.Text.Trim();
                string Passwordadmin = this.txtPassAdmin.Text;
                string namaAdmin = "";
                bool sukses = false;
                try
                {
                    using (var conn = new Connection().CreateAndOpenConnection())
                    {
                        using (var cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = @"Select IDAdmin, NamaAdmin, Password From Admin Where IDAdmin = @IDAdmin";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@IDAdmin", IDAdmin);
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        if (Passwordadmin == reader["Password"].ToString())
                                        {
                                            namaAdmin = reader["NamaAdmin"].ToString();
                                            sukses = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (sukses)
                    {
                        this.Hide();
                        var form = new frmLaporan(namaAdmin);
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, data anda tidak terdaftar ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtIDAdmin.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtIDAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }
        private void txtPassAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
