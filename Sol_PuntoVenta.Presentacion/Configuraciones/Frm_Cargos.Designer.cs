namespace Sol_PuntoVenta.Presentacion
{
    partial class Frm_Cargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cargos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Txt_descripcion_ar = new System.Windows.Forms.TextBox();
            this.Btn_buscar_ar = new System.Windows.Forms.Button();
            this.Img_procesos = new System.Windows.Forms.ImageList(this.components);
            this.Btn_retornar = new System.Windows.Forms.Button();
            this.Dgv_Listado_ar = new System.Windows.Forms.DataGridView();
            this.Label4 = new System.Windows.Forms.Label();
            this.Btn_retornar_ar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Txt_descripcion_cr = new System.Windows.Forms.TextBox();
            this.Img_principal = new System.Windows.Forms.ImageList(this.components);
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.Txt_buscar_ar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pnl_listado_ar = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_lupa = new System.Windows.Forms.Button();
            this.Btn_confirmar = new System.Windows.Forms.Button();
            this.Btn_cancelar2 = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.Lbl_total = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Dgv_Listado = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Tbp_general = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado_ar)).BeginInit();
            this.panel1.SuspendLayout();
            this.Pnl_listado_ar.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.Tbp_general.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_descripcion_ar
            // 
            this.Txt_descripcion_ar.Location = new System.Drawing.Point(99, 44);
            this.Txt_descripcion_ar.Name = "Txt_descripcion_ar";
            this.Txt_descripcion_ar.ReadOnly = true;
            this.Txt_descripcion_ar.Size = new System.Drawing.Size(237, 20);
            this.Txt_descripcion_ar.TabIndex = 8;
            // 
            // Btn_buscar_ar
            // 
            this.Btn_buscar_ar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.Btn_buscar_ar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_buscar_ar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_buscar_ar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar_ar.ForeColor = System.Drawing.Color.White;
            this.Btn_buscar_ar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_buscar_ar.ImageKey = "buscar.png";
            this.Btn_buscar_ar.ImageList = this.Img_procesos;
            this.Btn_buscar_ar.Location = new System.Drawing.Point(224, 38);
            this.Btn_buscar_ar.Name = "Btn_buscar_ar";
            this.Btn_buscar_ar.Size = new System.Drawing.Size(34, 30);
            this.Btn_buscar_ar.TabIndex = 16;
            this.Btn_buscar_ar.UseVisualStyleBackColor = false;
            this.Btn_buscar_ar.Click += new System.EventHandler(this.Btn_buscar_ar_Click);
            // 
            // Img_procesos
            // 
            this.Img_procesos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img_procesos.ImageStream")));
            this.Img_procesos.TransparentColor = System.Drawing.Color.Transparent;
            this.Img_procesos.Images.SetKeyName(0, "buscar.png");
            this.Img_procesos.Images.SetKeyName(1, "cancelar.png");
            this.Img_procesos.Images.SetKeyName(2, "guardar.png");
            this.Img_procesos.Images.SetKeyName(3, "retornar.png");
            this.Img_procesos.Images.SetKeyName(4, "confirmar.png");
            this.Img_procesos.Images.SetKeyName(5, "lupa.png");
            // 
            // Btn_retornar
            // 
            this.Btn_retornar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.Btn_retornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_retornar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_retornar.ForeColor = System.Drawing.Color.White;
            this.Btn_retornar.Location = new System.Drawing.Point(235, 148);
            this.Btn_retornar.Name = "Btn_retornar";
            this.Btn_retornar.Size = new System.Drawing.Size(110, 30);
            this.Btn_retornar.TabIndex = 6;
            this.Btn_retornar.Text = "Retornar";
            this.Btn_retornar.UseVisualStyleBackColor = false;
            this.Btn_retornar.Visible = false;
            this.Btn_retornar.Click += new System.EventHandler(this.Btn_retornar_Click);
            // 
            // Dgv_Listado_ar
            // 
            this.Dgv_Listado_ar.AllowUserToAddRows = false;
            this.Dgv_Listado_ar.AllowUserToDeleteRows = false;
            this.Dgv_Listado_ar.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.Dgv_Listado_ar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Listado_ar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Dgv_Listado_ar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Listado_ar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dgv_Listado_ar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Listado_ar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Listado_ar.ColumnHeadersHeight = 30;
            this.Dgv_Listado_ar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Listado_ar.EnableHeadersVisualStyles = false;
            this.Dgv_Listado_ar.GridColor = System.Drawing.Color.SteelBlue;
            this.Dgv_Listado_ar.Location = new System.Drawing.Point(13, 74);
            this.Dgv_Listado_ar.Name = "Dgv_Listado_ar";
            this.Dgv_Listado_ar.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Dgv_Listado_ar.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Listado_ar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Listado_ar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Listado_ar.Size = new System.Drawing.Size(300, 182);
            this.Dgv_Listado_ar.TabIndex = 20;
            this.Dgv_Listado_ar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Listado_ar_CellDoubleClick);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.Label4.Location = new System.Drawing.Point(10, 7);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(126, 13);
            this.Label4.TabIndex = 18;
            this.Label4.Text = "LISTADO DE ÁREAS";
            // 
            // Btn_retornar_ar
            // 
            this.Btn_retornar_ar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.Btn_retornar_ar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_retornar_ar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_retornar_ar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_retornar_ar.ForeColor = System.Drawing.Color.White;
            this.Btn_retornar_ar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_retornar_ar.ImageKey = "retornar.png";
            this.Btn_retornar_ar.ImageList = this.Img_procesos;
            this.Btn_retornar_ar.Location = new System.Drawing.Point(264, 38);
            this.Btn_retornar_ar.Name = "Btn_retornar_ar";
            this.Btn_retornar_ar.Size = new System.Drawing.Size(34, 30);
            this.Btn_retornar_ar.TabIndex = 17;
            this.Btn_retornar_ar.UseVisualStyleBackColor = false;
            this.Btn_retornar_ar.Click += new System.EventHandler(this.Btn_retornar_ar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Área (*):";
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.Btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_guardar.Location = new System.Drawing.Point(221, 148);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(110, 30);
            this.Btn_guardar.TabIndex = 5;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Visible = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.Btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_cancelar.Location = new System.Drawing.Point(99, 148);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(110, 30);
            this.Btn_cancelar.TabIndex = 4;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Visible = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Txt_descripcion_cr
            // 
            this.Txt_descripcion_cr.Location = new System.Drawing.Point(99, 93);
            this.Txt_descripcion_cr.MaxLength = 100;
            this.Txt_descripcion_cr.Name = "Txt_descripcion_cr";
            this.Txt_descripcion_cr.ReadOnly = true;
            this.Txt_descripcion_cr.Size = new System.Drawing.Size(237, 20);
            this.Txt_descripcion_cr.TabIndex = 3;
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
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.Btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_salir.ImageKey = "salir.ico";
            this.Btn_salir.ImageList = this.Img_principal;
            this.Btn_salir.Location = new System.Drawing.Point(340, 425);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(75, 56);
            this.Btn_salir.TabIndex = 17;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.Btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_reporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_reporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_reporte.ImageKey = "reporte.ico";
            this.Btn_reporte.ImageList = this.Img_principal;
            this.Btn_reporte.Location = new System.Drawing.Point(259, 425);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(75, 56);
            this.Btn_reporte.TabIndex = 16;
            this.Btn_reporte.Text = "Reporte";
            this.Btn_reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_reporte.UseVisualStyleBackColor = false;
            this.Btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.Btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_eliminar.ImageKey = "eliminar.ico";
            this.Btn_eliminar.ImageList = this.Img_principal;
            this.Btn_eliminar.Location = new System.Drawing.Point(178, 425);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(75, 56);
            this.Btn_eliminar.TabIndex = 15;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.Btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_actualizar.ImageKey = "actualizar.ico";
            this.Btn_actualizar.ImageList = this.Img_principal;
            this.Btn_actualizar.Location = new System.Drawing.Point(97, 425);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(75, 56);
            this.Btn_actualizar.TabIndex = 14;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.Btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_nuevo.ImageKey = "nuevo.ico";
            this.Btn_nuevo.ImageList = this.Img_principal;
            this.Btn_nuevo.Location = new System.Drawing.Point(16, 425);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(75, 56);
            this.Btn_nuevo.TabIndex = 13;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cargo: (*):";
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(62, 14);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(86, 18);
            this.lblTitleChildForm.TabIndex = 7;
            this.lblTitleChildForm.Text = ".:. Cargos";
            // 
            // Txt_buscar_ar
            // 
            this.Txt_buscar_ar.Location = new System.Drawing.Point(13, 44);
            this.Txt_buscar_ar.Name = "Txt_buscar_ar";
            this.Txt_buscar_ar.Size = new System.Drawing.Size(205, 20);
            this.Txt_buscar_ar.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.lblTitleChildForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 42);
            this.panel1.TabIndex = 18;
            // 
            // Pnl_listado_ar
            // 
            this.Pnl_listado_ar.BackColor = System.Drawing.Color.Silver;
            this.Pnl_listado_ar.Controls.Add(this.Dgv_Listado_ar);
            this.Pnl_listado_ar.Controls.Add(this.Label4);
            this.Pnl_listado_ar.Controls.Add(this.Btn_retornar_ar);
            this.Pnl_listado_ar.Controls.Add(this.Btn_buscar_ar);
            this.Pnl_listado_ar.Controls.Add(this.Txt_buscar_ar);
            this.Pnl_listado_ar.Location = new System.Drawing.Point(364, 16);
            this.Pnl_listado_ar.Name = "Pnl_listado_ar";
            this.Pnl_listado_ar.Size = new System.Drawing.Size(333, 272);
            this.Pnl_listado_ar.TabIndex = 16;
            this.Pnl_listado_ar.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Pnl_listado_ar);
            this.tabPage2.Controls.Add(this.btn_lupa);
            this.tabPage2.Controls.Add(this.Txt_descripcion_ar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Btn_retornar);
            this.tabPage2.Controls.Add(this.Btn_guardar);
            this.tabPage2.Controls.Add(this.Btn_cancelar);
            this.tabPage2.Controls.Add(this.Txt_descripcion_cr);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // btn_lupa
            // 
            this.btn_lupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(106)))));
            this.btn_lupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lupa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.btn_lupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lupa.ForeColor = System.Drawing.Color.White;
            this.btn_lupa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lupa.ImageKey = "lupa.png";
            this.btn_lupa.ImageList = this.Img_procesos;
            this.btn_lupa.Location = new System.Drawing.Point(341, 40);
            this.btn_lupa.Name = "btn_lupa";
            this.btn_lupa.Size = new System.Drawing.Size(34, 30);
            this.btn_lupa.TabIndex = 19;
            this.btn_lupa.UseVisualStyleBackColor = false;
            this.btn_lupa.Visible = false;
            this.btn_lupa.Click += new System.EventHandler(this.btn_lupa_Click);
            // 
            // Btn_confirmar
            // 
            this.Btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.Btn_confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.Btn_confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_confirmar.Location = new System.Drawing.Point(124, 287);
            this.Btn_confirmar.Name = "Btn_confirmar";
            this.Btn_confirmar.Size = new System.Drawing.Size(110, 30);
            this.Btn_confirmar.TabIndex = 6;
            this.Btn_confirmar.Text = "Confirmar";
            this.Btn_confirmar.UseVisualStyleBackColor = false;
            this.Btn_confirmar.Visible = false;
            this.Btn_confirmar.Click += new System.EventHandler(this.Btn_confirmar_Click);
            // 
            // Btn_cancelar2
            // 
            this.Btn_cancelar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.Btn_cancelar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cancelar2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_cancelar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_cancelar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_cancelar2.Location = new System.Drawing.Point(7, 287);
            this.Btn_cancelar2.Name = "Btn_cancelar2";
            this.Btn_cancelar2.Size = new System.Drawing.Size(110, 30);
            this.Btn_cancelar2.TabIndex = 5;
            this.Btn_cancelar2.Text = "Cancelar";
            this.Btn_cancelar2.UseVisualStyleBackColor = false;
            this.Btn_cancelar2.Visible = false;
            this.Btn_cancelar2.Click += new System.EventHandler(this.Btn_cancelar2_Click);
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
            this.Lbl_total.AutoSize = true;
            this.Lbl_total.Location = new System.Drawing.Point(660, 296);
            this.Lbl_total.Name = "Lbl_total";
            this.Lbl_total.Size = new System.Drawing.Size(34, 13);
            this.Lbl_total.TabIndex = 1;
            this.Lbl_total.Text = "Total:";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Dgv_Listado
            // 
            this.Dgv_Listado.AllowUserToAddRows = false;
            this.Dgv_Listado.AllowUserToDeleteRows = false;
            this.Dgv_Listado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.Dgv_Listado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Listado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Dgv_Listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Listado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dgv_Listado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Listado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Listado.ColumnHeadersHeight = 30;
            this.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.Dgv_Listado.EnableHeadersVisualStyles = false;
            this.Dgv_Listado.GridColor = System.Drawing.Color.SteelBlue;
            this.Dgv_Listado.Location = new System.Drawing.Point(7, 63);
            this.Dgv_Listado.Name = "Dgv_Listado";
            this.Dgv_Listado.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.Dgv_Listado.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_Listado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Listado.Size = new System.Drawing.Size(782, 211);
            this.Dgv_Listado.TabIndex = 8;
            this.Dgv_Listado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Listado_CellContentClick);
            this.Dgv_Listado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Listado_CellDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Dgv_Listado);
            this.tabPage1.Controls.Add(this.Btn_confirmar);
            this.tabPage1.Controls.Add(this.Btn_cancelar2);
            this.tabPage1.Controls.Add(this.Btn_buscar);
            this.tabPage1.Controls.Add(this.Txt_buscar);
            this.tabPage1.Controls.Add(this.Lbl_total);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // Tbp_general
            // 
            this.Tbp_general.Controls.Add(this.tabPage1);
            this.Tbp_general.Controls.Add(this.tabPage2);
            this.Tbp_general.ItemSize = new System.Drawing.Size(96, 32);
            this.Tbp_general.Location = new System.Drawing.Point(12, 57);
            this.Tbp_general.Name = "Tbp_general";
            this.Tbp_general.SelectedIndex = 0;
            this.Tbp_general.Size = new System.Drawing.Size(803, 362);
            this.Tbp_general.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tbp_general.TabIndex = 12;
            // 
            // Frm_Cargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 600);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tbp_general);
            this.Name = "Frm_Cargos";
            this.Text = "Frm_Cargos";
            this.Load += new System.EventHandler(this.Frm_Cargos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado_ar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Pnl_listado_ar.ResumeLayout(false);
            this.Pnl_listado_ar.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Tbp_general.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_descripcion_ar;
        internal System.Windows.Forms.Button Btn_buscar_ar;
        private System.Windows.Forms.ImageList Img_procesos;
        private System.Windows.Forms.Button Btn_retornar;
        private System.Windows.Forms.DataGridView Dgv_Listado_ar;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button Btn_retornar_ar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.TextBox Txt_descripcion_cr;
        private System.Windows.Forms.ImageList Img_principal;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitleChildForm;
        internal System.Windows.Forms.TextBox Txt_buscar_ar;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel Pnl_listado_ar;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.Button btn_lupa;
        private System.Windows.Forms.Button Btn_confirmar;
        private System.Windows.Forms.Button Btn_cancelar2;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label Lbl_total;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridView Dgv_Listado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl Tbp_general;
    }
}