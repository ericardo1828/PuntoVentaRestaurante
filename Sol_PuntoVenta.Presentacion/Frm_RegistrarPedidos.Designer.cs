
namespace Sol_PuntoVenta.Presentacion
{
    partial class Frm_RegistrarPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistrarPedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.Img_principal = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pnl_listado_pv = new System.Windows.Forms.Panel();
            this.Dgv_Listado_pv = new System.Windows.Forms.DataGridView();
            this.Btn_retornar_pv = new System.Windows.Forms.Button();
            this.Lbl_mensaje = new System.Windows.Forms.Label();
            this.Lbl_estado_tu = new System.Windows.Forms.Label();
            this.Lbl_estado_pv = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_descripcion_tu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_fecha_ct = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_descripcion_pv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_lupa = new System.Windows.Forms.Button();
            this.Txt_codigo_pv = new System.Windows.Forms.TextBox();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Pnl_listado_pv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado_pv)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.panel1.TabIndex = 13;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(62, 14);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(165, 18);
            this.lblTitleChildForm.TabIndex = 7;
            this.lblTitleChildForm.Text = ".:. Registrar Pedido";
            // 
            // Img_principal
            // 
            this.Img_principal.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img_principal.ImageStream")));
            this.Img_principal.TransparentColor = System.Drawing.Color.Transparent;
            this.Img_principal.Images.SetKeyName(0, "eliminar.ico");
            this.Img_principal.Images.SetKeyName(1, "salir.ico");
            this.Img_principal.Images.SetKeyName(2, "agregar-archivo.png");
            this.Img_principal.Images.SetKeyName(3, "visualizar_pedido.png");
            this.Img_principal.Images.SetKeyName(4, "emitir_documento.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.Pnl_listado_pv);
            this.panel2.Controls.Add(this.Lbl_mensaje);
            this.panel2.Controls.Add(this.Lbl_estado_tu);
            this.panel2.Controls.Add(this.Lbl_estado_pv);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Lbl_descripcion_tu);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Lbl_fecha_ct);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Lbl_descripcion_pv);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_lupa);
            this.panel2.Controls.Add(this.Txt_codigo_pv);
            this.panel2.Controls.Add(this.Btn_salir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 141);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Pnl_listado_pv
            // 
            this.Pnl_listado_pv.BackColor = System.Drawing.Color.Silver;
            this.Pnl_listado_pv.Controls.Add(this.Dgv_Listado_pv);
            this.Pnl_listado_pv.Controls.Add(this.Btn_retornar_pv);
            this.Pnl_listado_pv.Location = new System.Drawing.Point(52, 3);
            this.Pnl_listado_pv.Name = "Pnl_listado_pv";
            this.Pnl_listado_pv.Size = new System.Drawing.Size(312, 135);
            this.Pnl_listado_pv.TabIndex = 27;
            this.Pnl_listado_pv.Visible = false;
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
            this.Dgv_Listado_pv.Location = new System.Drawing.Point(5, 4);
            this.Dgv_Listado_pv.Name = "Dgv_Listado_pv";
            this.Dgv_Listado_pv.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Dgv_Listado_pv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Listado_pv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Listado_pv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Listado_pv.Size = new System.Drawing.Size(270, 128);
            this.Dgv_Listado_pv.TabIndex = 20;
            this.Dgv_Listado_pv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Listado_pv_CellDoubleClick);
            // 
            // Btn_retornar_pv
            // 
            this.Btn_retornar_pv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.Btn_retornar_pv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_retornar_pv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_retornar_pv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_retornar_pv.ForeColor = System.Drawing.Color.White;
            this.Btn_retornar_pv.Image = ((System.Drawing.Image)(resources.GetObject("Btn_retornar_pv.Image")));
            this.Btn_retornar_pv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_retornar_pv.Location = new System.Drawing.Point(276, 2);
            this.Btn_retornar_pv.Name = "Btn_retornar_pv";
            this.Btn_retornar_pv.Size = new System.Drawing.Size(34, 30);
            this.Btn_retornar_pv.TabIndex = 17;
            this.Btn_retornar_pv.UseVisualStyleBackColor = false;
            this.Btn_retornar_pv.Click += new System.EventHandler(this.Btn_retornar_pv_Click);
            // 
            // Lbl_mensaje
            // 
            this.Lbl_mensaje.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_mensaje.Location = new System.Drawing.Point(25, 113);
            this.Lbl_mensaje.Name = "Lbl_mensaje";
            this.Lbl_mensaje.Size = new System.Drawing.Size(1052, 25);
            this.Lbl_mensaje.TabIndex = 40;
            this.Lbl_mensaje.Text = "mensaje";
            this.Lbl_mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_mensaje.Visible = false;
            // 
            // Lbl_estado_tu
            // 
            this.Lbl_estado_tu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_estado_tu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado_tu.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_estado_tu.Location = new System.Drawing.Point(720, 97);
            this.Lbl_estado_tu.Name = "Lbl_estado_tu";
            this.Lbl_estado_tu.Size = new System.Drawing.Size(137, 26);
            this.Lbl_estado_tu.TabIndex = 39;
            this.Lbl_estado_tu.Text = "Estado_tu";
            this.Lbl_estado_tu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_estado_tu.Visible = false;
            // 
            // Lbl_estado_pv
            // 
            this.Lbl_estado_pv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(117)))), ((int)(((byte)(110)))));
            this.Lbl_estado_pv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_estado_pv.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado_pv.ForeColor = System.Drawing.Color.White;
            this.Lbl_estado_pv.Location = new System.Drawing.Point(717, 43);
            this.Lbl_estado_pv.Name = "Lbl_estado_pv";
            this.Lbl_estado_pv.Size = new System.Drawing.Size(149, 54);
            this.Lbl_estado_pv.TabIndex = 38;
            this.Lbl_estado_pv.Text = "Estado X";
            this.Lbl_estado_pv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(717, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Estado";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_descripcion_tu
            // 
            this.Lbl_descripcion_tu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(117)))), ((int)(((byte)(110)))));
            this.Lbl_descripcion_tu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_descripcion_tu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion_tu.ForeColor = System.Drawing.Color.White;
            this.Lbl_descripcion_tu.Location = new System.Drawing.Point(562, 43);
            this.Lbl_descripcion_tu.Name = "Lbl_descripcion_tu";
            this.Lbl_descripcion_tu.Size = new System.Drawing.Size(149, 54);
            this.Lbl_descripcion_tu.TabIndex = 35;
            this.Lbl_descripcion_tu.Text = "Turno X";
            this.Lbl_descripcion_tu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(562, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Turno";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_fecha_ct
            // 
            this.Lbl_fecha_ct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(117)))), ((int)(((byte)(110)))));
            this.Lbl_fecha_ct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_fecha_ct.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha_ct.ForeColor = System.Drawing.Color.White;
            this.Lbl_fecha_ct.Location = new System.Drawing.Point(407, 43);
            this.Lbl_fecha_ct.Name = "Lbl_fecha_ct";
            this.Lbl_fecha_ct.Size = new System.Drawing.Size(149, 54);
            this.Lbl_fecha_ct.TabIndex = 33;
            this.Lbl_fecha_ct.Text = "Fecha de trabajo X";
            this.Lbl_fecha_ct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(407, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Fecha de trabajo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_descripcion_pv
            // 
            this.Lbl_descripcion_pv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(117)))), ((int)(((byte)(110)))));
            this.Lbl_descripcion_pv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_descripcion_pv.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion_pv.ForeColor = System.Drawing.Color.White;
            this.Lbl_descripcion_pv.Location = new System.Drawing.Point(25, 43);
            this.Lbl_descripcion_pv.Name = "Lbl_descripcion_pv";
            this.Lbl_descripcion_pv.Size = new System.Drawing.Size(273, 54);
            this.Lbl_descripcion_pv.TabIndex = 26;
            this.Lbl_descripcion_pv.Text = "PuntoVenta X";
            this.Lbl_descripcion_pv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(25, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Punto de Venta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_lupa
            // 
            this.btn_lupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(106)))));
            this.btn_lupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lupa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.btn_lupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lupa.ForeColor = System.Drawing.Color.White;
            this.btn_lupa.Image = ((System.Drawing.Image)(resources.GetObject("btn_lupa.Image")));
            this.btn_lupa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lupa.Location = new System.Drawing.Point(304, 43);
            this.btn_lupa.Name = "btn_lupa";
            this.btn_lupa.Size = new System.Drawing.Size(54, 54);
            this.btn_lupa.TabIndex = 23;
            this.btn_lupa.UseVisualStyleBackColor = false;
            this.btn_lupa.Click += new System.EventHandler(this.btn_lupa_Click);
            // 
            // Txt_codigo_pv
            // 
            this.Txt_codigo_pv.Location = new System.Drawing.Point(310, 61);
            this.Txt_codigo_pv.Name = "Txt_codigo_pv";
            this.Txt_codigo_pv.Size = new System.Drawing.Size(54, 20);
            this.Txt_codigo_pv.TabIndex = 24;
            this.Txt_codigo_pv.Text = "0";
            this.Txt_codigo_pv.Visible = false;
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
            this.Btn_salir.Location = new System.Drawing.Point(972, 7);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(105, 70);
            this.Btn_salir.TabIndex = 14;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1089, 40);
            this.panel3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "::: MESAS :::";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 223);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1089, 377);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_RegistrarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 600);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_RegistrarPedidos";
            this.Text = "Frm_RegistrarPedidos";
            this.Load += new System.EventHandler(this.Frm_RegistrarPedidos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Pnl_listado_pv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado_pv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.ImageList Img_principal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Lbl_descripcion_pv;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btn_lupa;
        private System.Windows.Forms.TextBox Txt_codigo_pv;
        internal System.Windows.Forms.Panel Pnl_listado_pv;
        private System.Windows.Forms.DataGridView Dgv_Listado_pv;
        internal System.Windows.Forms.Button Btn_retornar_pv;
        private System.Windows.Forms.Label Lbl_descripcion_tu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_fecha_ct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_estado_pv;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label Lbl_estado_tu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lbl_mensaje;
    }
}