
namespace Sol_PuntoVenta.Presentacion
{
    partial class Frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_email_us = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_password_us = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_acceder = new FontAwesome.Sharp.IconButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Pct_minimizar = new System.Windows.Forms.PictureBox();
            this.Pct_cerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Versión 2.1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 125);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sistema \r\nde \r\nPunto de Venta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_email_us
            // 
            this.Txt_email_us.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_email_us.Location = new System.Drawing.Point(338, 94);
            this.Txt_email_us.MaxLength = 150;
            this.Txt_email_us.Name = "Txt_email_us";
            this.Txt_email_us.Size = new System.Drawing.Size(310, 23);
            this.Txt_email_us.TabIndex = 1;
            this.Txt_email_us.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_email_us_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email y/o Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            // 
            // Txt_password_us
            // 
            this.Txt_password_us.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_password_us.Location = new System.Drawing.Point(338, 157);
            this.Txt_password_us.MaxLength = 50;
            this.Txt_password_us.Name = "Txt_password_us";
            this.Txt_password_us.PasswordChar = '*';
            this.Txt_password_us.Size = new System.Drawing.Size(310, 23);
            this.Txt_password_us.TabIndex = 3;
            this.Txt_password_us.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_password_us_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Iniciar sesión";
            // 
            // Btn_acceder
            // 
            this.Btn_acceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Btn_acceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_acceder.FlatAppearance.BorderSize = 0;
            this.Btn_acceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_acceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_acceder.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_acceder.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_acceder.IconColor = System.Drawing.Color.Black;
            this.Btn_acceder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_acceder.Location = new System.Drawing.Point(338, 217);
            this.Btn_acceder.Name = "Btn_acceder";
            this.Btn_acceder.Size = new System.Drawing.Size(310, 40);
            this.Btn_acceder.TabIndex = 0;
            this.Btn_acceder.Text = "ACCEDER";
            this.Btn_acceder.UseVisualStyleBackColor = false;
            this.Btn_acceder.Click += new System.EventHandler(this.Btn_acceder_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(394, 288);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(194, 14);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Has olvidado tu contraseña?";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Pct_minimizar
            // 
            this.Pct_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pct_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Pct_minimizar.Image")));
            this.Pct_minimizar.Location = new System.Drawing.Point(721, 9);
            this.Pct_minimizar.Name = "Pct_minimizar";
            this.Pct_minimizar.Size = new System.Drawing.Size(18, 18);
            this.Pct_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pct_minimizar.TabIndex = 8;
            this.Pct_minimizar.TabStop = false;
            this.Pct_minimizar.Click += new System.EventHandler(this.Pct_minimizar_Click);
            // 
            // Pct_cerrar
            // 
            this.Pct_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pct_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Pct_cerrar.Image")));
            this.Pct_cerrar.Location = new System.Drawing.Point(750, 9);
            this.Pct_cerrar.Name = "Pct_cerrar";
            this.Pct_cerrar.Size = new System.Drawing.Size(18, 18);
            this.Pct_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pct_cerrar.TabIndex = 7;
            this.Pct_cerrar.TabStop = false;
            this.Pct_cerrar.Click += new System.EventHandler(this.Pct_cerrar_Click);
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.Pct_minimizar);
            this.Controls.Add(this.Pct_cerrar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Btn_acceder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_password_us);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_email_us);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_login";
            this.Load += new System.EventHandler(this.Frm_login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_login_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_email_us;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_password_us;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton Btn_acceder;
        private System.Windows.Forms.LinkLabel linkLabel1;
        internal System.Windows.Forms.PictureBox Pct_minimizar;
        internal System.Windows.Forms.PictureBox Pct_cerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}