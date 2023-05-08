
namespace Sol_PuntoVenta.Presentacion
{
    partial class Frm_Cierre_Turnos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cierre_Turnos));
            this.Dgv_Listado_pv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_estado_tu = new System.Windows.Forms.Label();
            this.Lbl_codigo_tu = new System.Windows.Forms.Label();
            this.Lbl_codigo_pv = new System.Windows.Forms.Label();
            this.Lbl_descripcion_tu = new System.Windows.Forms.Label();
            this.Lbl_fecha_ct = new System.Windows.Forms.Label();
            this.Lbl_descripcion_pv = new System.Windows.Forms.Label();
            this.Lbl_estado_pv = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_abrir_turno = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_cerrar_turno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Img_principal = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado_pv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Listado_pv
            // 
            this.Dgv_Listado_pv.AllowUserToAddRows = false;
            this.Dgv_Listado_pv.AllowUserToDeleteRows = false;
            this.Dgv_Listado_pv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.Dgv_Listado_pv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Listado_pv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Dgv_Listado_pv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Listado_pv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dgv_Listado_pv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Listado_pv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Listado_pv.ColumnHeadersHeight = 30;
            this.Dgv_Listado_pv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Listado_pv.EnableHeadersVisualStyles = false;
            this.Dgv_Listado_pv.GridColor = System.Drawing.Color.SteelBlue;
            this.Dgv_Listado_pv.Location = new System.Drawing.Point(21, 48);
            this.Dgv_Listado_pv.Name = "Dgv_Listado_pv";
            this.Dgv_Listado_pv.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Dgv_Listado_pv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Listado_pv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Listado_pv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Listado_pv.Size = new System.Drawing.Size(427, 186);
            this.Dgv_Listado_pv.TabIndex = 21;
            this.Dgv_Listado_pv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Listado_pv_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.Lbl_estado_tu);
            this.panel2.Controls.Add(this.Lbl_codigo_tu);
            this.panel2.Controls.Add(this.Lbl_codigo_pv);
            this.panel2.Controls.Add(this.Lbl_descripcion_tu);
            this.panel2.Controls.Add(this.Lbl_fecha_ct);
            this.panel2.Controls.Add(this.Lbl_descripcion_pv);
            this.panel2.Controls.Add(this.Lbl_estado_pv);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Btn_abrir_turno);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Btn_cerrar_turno);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(21, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 253);
            this.panel2.TabIndex = 23;
            // 
            // Lbl_estado_tu
            // 
            this.Lbl_estado_tu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Lbl_estado_tu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_estado_tu.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado_tu.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_estado_tu.Location = new System.Drawing.Point(351, 167);
            this.Lbl_estado_tu.Name = "Lbl_estado_tu";
            this.Lbl_estado_tu.Size = new System.Drawing.Size(33, 26);
            this.Lbl_estado_tu.TabIndex = 66;
            this.Lbl_estado_tu.Text = "Estado_tu";
            this.Lbl_estado_tu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_estado_tu.Visible = false;
            // 
            // Lbl_codigo_tu
            // 
            this.Lbl_codigo_tu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Lbl_codigo_tu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_codigo_tu.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigo_tu.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_codigo_tu.Location = new System.Drawing.Point(350, 116);
            this.Lbl_codigo_tu.Name = "Lbl_codigo_tu";
            this.Lbl_codigo_tu.Size = new System.Drawing.Size(33, 26);
            this.Lbl_codigo_tu.TabIndex = 65;
            this.Lbl_codigo_tu.Text = "Codigo_pv";
            this.Lbl_codigo_tu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_codigo_tu.Visible = false;
            // 
            // Lbl_codigo_pv
            // 
            this.Lbl_codigo_pv.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Lbl_codigo_pv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_codigo_pv.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigo_pv.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_codigo_pv.Location = new System.Drawing.Point(350, 46);
            this.Lbl_codigo_pv.Name = "Lbl_codigo_pv";
            this.Lbl_codigo_pv.Size = new System.Drawing.Size(33, 26);
            this.Lbl_codigo_pv.TabIndex = 64;
            this.Lbl_codigo_pv.Text = "Codigo_pv";
            this.Lbl_codigo_pv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_codigo_pv.Visible = false;
            // 
            // Lbl_descripcion_tu
            // 
            this.Lbl_descripcion_tu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Lbl_descripcion_tu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_descripcion_tu.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion_tu.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_descripcion_tu.Location = new System.Drawing.Point(114, 116);
            this.Lbl_descripcion_tu.Name = "Lbl_descripcion_tu";
            this.Lbl_descripcion_tu.Size = new System.Drawing.Size(230, 26);
            this.Lbl_descripcion_tu.TabIndex = 63;
            this.Lbl_descripcion_tu.Text = "Turno X";
            this.Lbl_descripcion_tu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_fecha_ct
            // 
            this.Lbl_fecha_ct.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Lbl_fecha_ct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_fecha_ct.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha_ct.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_fecha_ct.Location = new System.Drawing.Point(114, 81);
            this.Lbl_fecha_ct.Name = "Lbl_fecha_ct";
            this.Lbl_fecha_ct.Size = new System.Drawing.Size(230, 26);
            this.Lbl_fecha_ct.TabIndex = 62;
            this.Lbl_fecha_ct.Text = "Fecha de trabajo X";
            this.Lbl_fecha_ct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_descripcion_pv
            // 
            this.Lbl_descripcion_pv.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Lbl_descripcion_pv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_descripcion_pv.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion_pv.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_descripcion_pv.Location = new System.Drawing.Point(114, 46);
            this.Lbl_descripcion_pv.Name = "Lbl_descripcion_pv";
            this.Lbl_descripcion_pv.Size = new System.Drawing.Size(230, 26);
            this.Lbl_descripcion_pv.TabIndex = 61;
            this.Lbl_descripcion_pv.Text = "Punto de Venta X";
            this.Lbl_descripcion_pv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_estado_pv
            // 
            this.Lbl_estado_pv.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Lbl_estado_pv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_estado_pv.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado_pv.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_estado_pv.Location = new System.Drawing.Point(114, 154);
            this.Lbl_estado_pv.Name = "Lbl_estado_pv";
            this.Lbl_estado_pv.Size = new System.Drawing.Size(230, 39);
            this.Lbl_estado_pv.TabIndex = 60;
            this.Lbl_estado_pv.Text = "Estado pv x";
            this.Lbl_estado_pv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Estado actual:";
            // 
            // Btn_abrir_turno
            // 
            this.Btn_abrir_turno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.Btn_abrir_turno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_abrir_turno.Enabled = false;
            this.Btn_abrir_turno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_abrir_turno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_abrir_turno.ForeColor = System.Drawing.Color.White;
            this.Btn_abrir_turno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_abrir_turno.Location = new System.Drawing.Point(50, 202);
            this.Btn_abrir_turno.Name = "Btn_abrir_turno";
            this.Btn_abrir_turno.Size = new System.Drawing.Size(164, 39);
            this.Btn_abrir_turno.TabIndex = 58;
            this.Btn_abrir_turno.Text = "Abrir siguiente turno";
            this.Btn_abrir_turno.UseVisualStyleBackColor = false;
            this.Btn_abrir_turno.Click += new System.EventHandler(this.Btn_abrir_turno_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Punto de Venta:";
            // 
            // Btn_cerrar_turno
            // 
            this.Btn_cerrar_turno.BackColor = System.Drawing.Color.DimGray;
            this.Btn_cerrar_turno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cerrar_turno.Enabled = false;
            this.Btn_cerrar_turno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_cerrar_turno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar_turno.ForeColor = System.Drawing.Color.White;
            this.Btn_cerrar_turno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_cerrar_turno.Location = new System.Drawing.Point(220, 202);
            this.Btn_cerrar_turno.Name = "Btn_cerrar_turno";
            this.Btn_cerrar_turno.Size = new System.Drawing.Size(164, 39);
            this.Btn_cerrar_turno.TabIndex = 53;
            this.Btn_cerrar_turno.Text = "Cerrar turno";
            this.Btn_cerrar_turno.UseVisualStyleBackColor = false;
            this.Btn_cerrar_turno.Click += new System.EventHandler(this.Btn_cerrar_turno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Turno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha de trabajo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 38);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datos actuales del turno";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_salir
            // 
            this.Btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.Btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_salir.ImageKey = "salir.ico";
            this.Btn_salir.ImageList = this.Img_principal;
            this.Btn_salir.Location = new System.Drawing.Point(1002, 48);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(75, 56);
            this.Btn_salir.TabIndex = 24;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Img_principal
            // 
            this.Img_principal.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img_principal.ImageStream")));
            this.Img_principal.TransparentColor = System.Drawing.Color.Transparent;
            this.Img_principal.Images.SetKeyName(0, "nuevo.ico");
            this.Img_principal.Images.SetKeyName(1, "actualizar.ico");
            this.Img_principal.Images.SetKeyName(2, "eliminar.ico");
            this.Img_principal.Images.SetKeyName(3, "reporte.ico");
            this.Img_principal.Images.SetKeyName(4, "salir.ico");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel3.Controls.Add(this.lblTitleChildForm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1089, 42);
            this.panel3.TabIndex = 25;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(62, 14);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(149, 18);
            this.lblTitleChildForm.TabIndex = 7;
            this.lblTitleChildForm.Text = "Gestión de Cierre";
            // 
            // Frm_Cierre_Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 638);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Dgv_Listado_pv);
            this.Name = "Frm_Cierre_Turnos";
            this.Text = "Frm_Cierre_Turnos";
            this.Load += new System.EventHandler(this.Frm_Cierre_Turnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado_pv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Listado_pv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_cerrar_turno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_abrir_turno;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label Lbl_estado_pv;
        public System.Windows.Forms.Label Lbl_codigo_tu;
        public System.Windows.Forms.Label Lbl_codigo_pv;
        public System.Windows.Forms.Label Lbl_fecha_ct;
        public System.Windows.Forms.Label Lbl_descripcion_pv;
        public System.Windows.Forms.Label Lbl_estado_tu;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.ImageList Img_principal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Label Lbl_descripcion_tu;
    }
}