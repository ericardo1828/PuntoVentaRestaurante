
namespace Sol_PuntoVenta.Presentacion
{
    partial class Frm_Consultas_Boletas_Facturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Consultas_Boletas_Facturas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.Tbp_general = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btn_imprimir_bo = new System.Windows.Forms.Button();
            this.Dgv_Listado = new System.Windows.Forms.DataGridView();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.Lbl_total = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_imprimir_fa = new System.Windows.Forms.Button();
            this.Dgv_Listado2 = new System.Windows.Forms.DataGridView();
            this.Btn_buscar2 = new System.Windows.Forms.Button();
            this.Txt_buscar2 = new System.Windows.Forms.TextBox();
            this.Lbl_total2 = new System.Windows.Forms.Label();
            this.Img_principal = new System.Windows.Forms.ImageList(this.components);
            this.Btn_salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Tbp_general.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.lblTitleChildForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 42);
            this.panel1.TabIndex = 12;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(62, 14);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(266, 18);
            this.lblTitleChildForm.TabIndex = 7;
            this.lblTitleChildForm.Text = ".:. Consultas Boletas y Facturas";
            // 
            // Tbp_general
            // 
            this.Tbp_general.Controls.Add(this.tabPage1);
            this.Tbp_general.Controls.Add(this.tabPage2);
            this.Tbp_general.ItemSize = new System.Drawing.Size(96, 32);
            this.Tbp_general.Location = new System.Drawing.Point(12, 50);
            this.Tbp_general.Name = "Tbp_general";
            this.Tbp_general.SelectedIndex = 0;
            this.Tbp_general.Size = new System.Drawing.Size(1065, 447);
            this.Tbp_general.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tbp_general.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn_imprimir_bo);
            this.tabPage1.Controls.Add(this.Dgv_Listado);
            this.tabPage1.Controls.Add(this.Btn_buscar);
            this.tabPage1.Controls.Add(this.Txt_buscar);
            this.tabPage1.Controls.Add(this.Lbl_total);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1057, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Boletas";
            // 
            // Btn_imprimir_bo
            // 
            this.Btn_imprimir_bo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.Btn_imprimir_bo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_imprimir_bo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_imprimir_bo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_imprimir_bo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_imprimir_bo.ForeColor = System.Drawing.Color.White;
            this.Btn_imprimir_bo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_imprimir_bo.Location = new System.Drawing.Point(7, 346);
            this.Btn_imprimir_bo.Name = "Btn_imprimir_bo";
            this.Btn_imprimir_bo.Size = new System.Drawing.Size(164, 48);
            this.Btn_imprimir_bo.TabIndex = 51;
            this.Btn_imprimir_bo.Text = "Imprimir Boleta";
            this.Btn_imprimir_bo.UseVisualStyleBackColor = false;
            this.Btn_imprimir_bo.Click += new System.EventHandler(this.Btn_imprimir_bo_Click);
            // 
            // Dgv_Listado
            // 
            this.Dgv_Listado.AllowUserToAddRows = false;
            this.Dgv_Listado.AllowUserToDeleteRows = false;
            this.Dgv_Listado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.Dgv_Listado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Listado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Dgv_Listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Listado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dgv_Listado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Listado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Listado.ColumnHeadersHeight = 30;
            this.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Listado.EnableHeadersVisualStyles = false;
            this.Dgv_Listado.GridColor = System.Drawing.Color.SteelBlue;
            this.Dgv_Listado.Location = new System.Drawing.Point(7, 63);
            this.Dgv_Listado.Name = "Dgv_Listado";
            this.Dgv_Listado.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Dgv_Listado.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Listado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Listado.Size = new System.Drawing.Size(1044, 276);
            this.Dgv_Listado.TabIndex = 7;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.Btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_buscar.Location = new System.Drawing.Point(331, 27);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(110, 30);
            this.Btn_buscar.TabIndex = 3;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Location = new System.Drawing.Point(7, 31);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(318, 20);
            this.Txt_buscar.TabIndex = 2;
            // 
            // Lbl_total
            // 
            this.Lbl_total.Location = new System.Drawing.Point(841, 418);
            this.Lbl_total.Name = "Lbl_total";
            this.Lbl_total.Size = new System.Drawing.Size(202, 13);
            this.Lbl_total.TabIndex = 1;
            this.Lbl_total.Text = "Total:";
            this.Lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_imprimir_fa);
            this.tabPage2.Controls.Add(this.Dgv_Listado2);
            this.tabPage2.Controls.Add(this.Btn_buscar2);
            this.tabPage2.Controls.Add(this.Txt_buscar2);
            this.tabPage2.Controls.Add(this.Lbl_total2);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1057, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Facturas";
            // 
            // Btn_imprimir_fa
            // 
            this.Btn_imprimir_fa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.Btn_imprimir_fa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_imprimir_fa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_imprimir_fa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_imprimir_fa.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_imprimir_fa.ForeColor = System.Drawing.Color.White;
            this.Btn_imprimir_fa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_imprimir_fa.Location = new System.Drawing.Point(7, 352);
            this.Btn_imprimir_fa.Name = "Btn_imprimir_fa";
            this.Btn_imprimir_fa.Size = new System.Drawing.Size(164, 48);
            this.Btn_imprimir_fa.TabIndex = 56;
            this.Btn_imprimir_fa.Text = "Imprimir Factura";
            this.Btn_imprimir_fa.UseVisualStyleBackColor = false;
            this.Btn_imprimir_fa.Click += new System.EventHandler(this.Btn_imprimir_fa_Click);
            // 
            // Dgv_Listado2
            // 
            this.Dgv_Listado2.AllowUserToAddRows = false;
            this.Dgv_Listado2.AllowUserToDeleteRows = false;
            this.Dgv_Listado2.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.Dgv_Listado2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Listado2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Dgv_Listado2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Listado2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dgv_Listado2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Listado2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Listado2.ColumnHeadersHeight = 30;
            this.Dgv_Listado2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Listado2.EnableHeadersVisualStyles = false;
            this.Dgv_Listado2.GridColor = System.Drawing.Color.SteelBlue;
            this.Dgv_Listado2.Location = new System.Drawing.Point(7, 69);
            this.Dgv_Listado2.Name = "Dgv_Listado2";
            this.Dgv_Listado2.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.Dgv_Listado2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_Listado2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Listado2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Listado2.Size = new System.Drawing.Size(1044, 276);
            this.Dgv_Listado2.TabIndex = 55;
            // 
            // Btn_buscar2
            // 
            this.Btn_buscar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.Btn_buscar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_buscar2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_buscar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar2.ForeColor = System.Drawing.Color.White;
            this.Btn_buscar2.Location = new System.Drawing.Point(331, 33);
            this.Btn_buscar2.Name = "Btn_buscar2";
            this.Btn_buscar2.Size = new System.Drawing.Size(110, 30);
            this.Btn_buscar2.TabIndex = 54;
            this.Btn_buscar2.Text = "Buscar";
            this.Btn_buscar2.UseVisualStyleBackColor = false;
            this.Btn_buscar2.Click += new System.EventHandler(this.Btn_buscar2_Click);
            // 
            // Txt_buscar2
            // 
            this.Txt_buscar2.Location = new System.Drawing.Point(7, 37);
            this.Txt_buscar2.Name = "Txt_buscar2";
            this.Txt_buscar2.Size = new System.Drawing.Size(318, 20);
            this.Txt_buscar2.TabIndex = 53;
            // 
            // Lbl_total2
            // 
            this.Lbl_total2.Location = new System.Drawing.Point(839, 418);
            this.Lbl_total2.Name = "Lbl_total2";
            this.Lbl_total2.Size = new System.Drawing.Size(202, 13);
            this.Lbl_total2.TabIndex = 52;
            this.Lbl_total2.Text = "Total:";
            this.Lbl_total2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.Btn_salir.Location = new System.Drawing.Point(995, 48);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(75, 56);
            this.Btn_salir.TabIndex = 25;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Frm_Consultas_Boletas_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 600);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Tbp_general);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Consultas_Boletas_Facturas";
            this.Text = "Frm_Consultas_Boletas_Facturas";
            this.Load += new System.EventHandler(this.Frm_Consultas_Boletas_Facturas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Tbp_general.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.TabControl Tbp_general;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Dgv_Listado;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label Lbl_total;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList Img_principal;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_imprimir_bo;
        private System.Windows.Forms.Button Btn_imprimir_fa;
        private System.Windows.Forms.DataGridView Dgv_Listado2;
        private System.Windows.Forms.Button Btn_buscar2;
        private System.Windows.Forms.TextBox Txt_buscar2;
        private System.Windows.Forms.Label Lbl_total2;
    }
}