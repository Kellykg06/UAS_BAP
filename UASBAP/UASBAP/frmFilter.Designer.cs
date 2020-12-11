namespace UASBAP
{
    partial class frmFilter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNamaTransaksi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cboTipe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNmrSub = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNmrAkun = new System.Windows.Forms.TextBox();
            this.lblBanyakRecordData = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tanggal_From = new System.Windows.Forms.DateTimePicker();
            this.cboTanggal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tanggal_To = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNamaTransaksi
            // 
            this.txtNamaTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaTransaksi.Location = new System.Drawing.Point(157, 133);
            this.txtNamaTransaksi.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamaTransaksi.Name = "txtNamaTransaksi";
            this.txtNamaTransaksi.Size = new System.Drawing.Size(215, 26);
            this.txtNamaTransaksi.TabIndex = 2;
            this.txtNamaTransaksi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNamaTransaksi_KeyDown);
            this.txtNamaTransaksi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNmrAkun_KeyPress);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(18, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 25);
            this.label8.TabIndex = 47;
            this.label8.Text = "Nama Transaksi";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 47);
            this.panel1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.CadetBlue;
            this.label7.CausesValidation = false;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(166, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "FILTER";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(348, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(24, 24);
            this.Close.TabIndex = 0;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(1167, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(272, 311);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(158, 311);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cboTipe
            // 
            this.cboTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipe.FormattingEnabled = true;
            this.cboTipe.Items.AddRange(new object[] {
            "",
            "Finansial",
            "Operasional",
            "Investasi"});
            this.cboTipe.Location = new System.Drawing.Point(157, 167);
            this.cboTipe.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipe.Name = "cboTipe";
            this.cboTipe.Size = new System.Drawing.Size(215, 26);
            this.cboTipe.TabIndex = 3;
            this.cboTipe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTipe_KeyDown);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Dari Tanggal";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Jenis Akun";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNmrSub
            // 
            this.txtNmrSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNmrSub.Location = new System.Drawing.Point(158, 102);
            this.txtNmrSub.Margin = new System.Windows.Forms.Padding(4);
            this.txtNmrSub.Name = "txtNmrSub";
            this.txtNmrSub.Size = new System.Drawing.Size(215, 26);
            this.txtNmrSub.TabIndex = 1;
            this.txtNmrSub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNmrSub_KeyDown);
            this.txtNmrSub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNmrAkun_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nomor SubAkun";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNmrAkun
            // 
            this.txtNmrAkun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNmrAkun.Location = new System.Drawing.Point(158, 70);
            this.txtNmrAkun.Margin = new System.Windows.Forms.Padding(4);
            this.txtNmrAkun.Name = "txtNmrAkun";
            this.txtNmrAkun.Size = new System.Drawing.Size(215, 26);
            this.txtNmrAkun.TabIndex = 0;
            this.txtNmrAkun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNmrAkun_KeyDown);
            this.txtNmrAkun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNmrAkun_KeyPress);
            // 
            // lblBanyakRecordData
            // 
            this.lblBanyakRecordData.Location = new System.Drawing.Point(19, 69);
            this.lblBanyakRecordData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBanyakRecordData.Name = "lblBanyakRecordData";
            this.lblBanyakRecordData.Size = new System.Drawing.Size(131, 25);
            this.lblBanyakRecordData.TabIndex = 36;
            this.lblBanyakRecordData.Text = "Nomor Akun";
            this.lblBanyakRecordData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 50;
            this.label6.Text = "Ke Tanggal";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tanggal_From
            // 
            this.tanggal_From.CustomFormat = "dd-MM-yyyy";
            this.tanggal_From.Enabled = false;
            this.tanggal_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tanggal_From.Location = new System.Drawing.Point(157, 242);
            this.tanggal_From.Name = "tanggal_From";
            this.tanggal_From.Size = new System.Drawing.Size(120, 26);
            this.tanggal_From.TabIndex = 6;
            this.tanggal_From.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // cboTanggal
            // 
            this.cboTanggal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTanggal.FormattingEnabled = true;
            this.cboTanggal.Items.AddRange(new object[] {
            "",
            "Harian",
            "Mingguan",
            "Bulanan"});
            this.cboTanggal.Location = new System.Drawing.Point(157, 204);
            this.cboTanggal.Margin = new System.Windows.Forms.Padding(4);
            this.cboTanggal.Name = "cboTanggal";
            this.cboTanggal.Size = new System.Drawing.Size(215, 26);
            this.cboTanggal.TabIndex = 5;
            this.cboTanggal.SelectedIndexChanged += new System.EventHandler(this.cboTanggal_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(18, 204);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 51;
            this.label9.Text = "Range Tanggal";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tanggal_To
            // 
            this.tanggal_To.CustomFormat = "dd-MM-yyyy";
            this.tanggal_To.Enabled = false;
            this.tanggal_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tanggal_To.Location = new System.Drawing.Point(157, 279);
            this.tanggal_To.Name = "tanggal_To";
            this.tanggal_To.Size = new System.Drawing.Size(120, 26);
            this.tanggal_To.TabIndex = 7;
            this.tanggal_To.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // frmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 345);
            this.Controls.Add(this.tanggal_To);
            this.Controls.Add(this.cboTanggal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tanggal_From);
            this.Controls.Add(this.txtNamaTransaksi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cboTipe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNmrSub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNmrAkun);
            this.Controls.Add(this.lblBanyakRecordData);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFilter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFilter_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNamaTransaksi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cboTipe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNmrSub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNmrAkun;
        private System.Windows.Forms.Label lblBanyakRecordData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker tanggal_From;
        private System.Windows.Forms.ComboBox cboTanggal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker tanggal_To;
    }
}