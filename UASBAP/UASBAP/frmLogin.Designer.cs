namespace UASBAP
{
    partial class frmLogin
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblIDAdmin = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPassAdmin = new System.Windows.Forms.TextBox();
            this.txtIDAdmin = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(14, 150);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 17);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "&Password : ";
            // 
            // lblIDAdmin
            // 
            this.lblIDAdmin.AutoSize = true;
            this.lblIDAdmin.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDAdmin.Location = new System.Drawing.Point(14, 66);
            this.lblIDAdmin.Name = "lblIDAdmin";
            this.lblIDAdmin.Size = new System.Drawing.Size(77, 17);
            this.lblIDAdmin.TabIndex = 22;
            this.lblIDAdmin.Text = "&ID Admin : ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(472, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPassAdmin
            // 
            this.txtPassAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassAdmin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassAdmin.Location = new System.Drawing.Point(14, 174);
            this.txtPassAdmin.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPassAdmin.Name = "txtPassAdmin";
            this.txtPassAdmin.PasswordChar = '*';
            this.txtPassAdmin.Size = new System.Drawing.Size(500, 32);
            this.txtPassAdmin.TabIndex = 1;
            this.txtPassAdmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassAdmin_KeyDown);
            // 
            // txtIDAdmin
            // 
            this.txtIDAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDAdmin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIDAdmin.Location = new System.Drawing.Point(14, 94);
            this.txtIDAdmin.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtIDAdmin.Name = "txtIDAdmin";
            this.txtIDAdmin.Size = new System.Drawing.Size(500, 32);
            this.txtIDAdmin.TabIndex = 0;
            this.txtIDAdmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIDAdmin_KeyDown);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogIn.Location = new System.Drawing.Point(14, 238);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(501, 39);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "&Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(223, 24);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(86, 27);
            this.lbl.TabIndex = 17;
            this.lbl.Text = "LOGIN";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 294);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblIDAdmin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtPassAdmin);
            this.Controls.Add(this.txtIDAdmin);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lbl);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblIDAdmin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPassAdmin;
        private System.Windows.Forms.TextBox txtIDAdmin;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lbl;
    }
}

