
namespace Sol_PuntoVenta.Presentacion.Controles
{
    partial class MiProducto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiProducto));
            this.Pnl_producto = new System.Windows.Forms.Panel();
            this.Lbl_archivo_txt = new System.Windows.Forms.Label();
            this.Lbl_impresora = new System.Windows.Forms.Label();
            this.Lbl_codigo_pr = new System.Windows.Forms.Label();
            this.Lbl_preciounitario_pr = new System.Windows.Forms.Label();
            this.Pct_imagen_pr = new System.Windows.Forms.PictureBox();
            this.Lbl_descripcion_pr = new System.Windows.Forms.Label();
            this.Pnl_producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_imagen_pr)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_producto
            // 
            this.Pnl_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_producto.Controls.Add(this.Lbl_archivo_txt);
            this.Pnl_producto.Controls.Add(this.Lbl_impresora);
            this.Pnl_producto.Controls.Add(this.Lbl_codigo_pr);
            this.Pnl_producto.Controls.Add(this.Lbl_preciounitario_pr);
            this.Pnl_producto.Controls.Add(this.Pct_imagen_pr);
            this.Pnl_producto.Controls.Add(this.Lbl_descripcion_pr);
            this.Pnl_producto.Location = new System.Drawing.Point(3, 3);
            this.Pnl_producto.Name = "Pnl_producto";
            this.Pnl_producto.Size = new System.Drawing.Size(174, 188);
            this.Pnl_producto.TabIndex = 2;
            // 
            // Lbl_archivo_txt
            // 
            this.Lbl_archivo_txt.Location = new System.Drawing.Point(7, 65);
            this.Lbl_archivo_txt.Name = "Lbl_archivo_txt";
            this.Lbl_archivo_txt.Size = new System.Drawing.Size(19, 23);
            this.Lbl_archivo_txt.TabIndex = 5;
            this.Lbl_archivo_txt.Text = "Archivo TXT";
            this.Lbl_archivo_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_archivo_txt.Visible = false;
            // 
            // Lbl_impresora
            // 
            this.Lbl_impresora.Location = new System.Drawing.Point(142, 4);
            this.Lbl_impresora.Name = "Lbl_impresora";
            this.Lbl_impresora.Size = new System.Drawing.Size(25, 23);
            this.Lbl_impresora.TabIndex = 4;
            this.Lbl_impresora.Text = "impresora_despacho";
            this.Lbl_impresora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_impresora.Visible = false;
            // 
            // Lbl_codigo_pr
            // 
            this.Lbl_codigo_pr.Location = new System.Drawing.Point(6, 7);
            this.Lbl_codigo_pr.Name = "Lbl_codigo_pr";
            this.Lbl_codigo_pr.Size = new System.Drawing.Size(22, 23);
            this.Lbl_codigo_pr.TabIndex = 3;
            this.Lbl_codigo_pr.Text = "codigo_pr";
            this.Lbl_codigo_pr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_codigo_pr.Visible = false;
            // 
            // Lbl_preciounitario_pr
            // 
            this.Lbl_preciounitario_pr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_preciounitario_pr.Location = new System.Drawing.Point(3, 156);
            this.Lbl_preciounitario_pr.Name = "Lbl_preciounitario_pr";
            this.Lbl_preciounitario_pr.Size = new System.Drawing.Size(168, 27);
            this.Lbl_preciounitario_pr.TabIndex = 2;
            this.Lbl_preciounitario_pr.Text = "Precio X";
            this.Lbl_preciounitario_pr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pct_imagen_pr
            // 
            this.Pct_imagen_pr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pct_imagen_pr.Image = ((System.Drawing.Image)(resources.GetObject("Pct_imagen_pr.Image")));
            this.Pct_imagen_pr.Location = new System.Drawing.Point(31, 11);
            this.Pct_imagen_pr.Name = "Pct_imagen_pr";
            this.Pct_imagen_pr.Size = new System.Drawing.Size(114, 97);
            this.Pct_imagen_pr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pct_imagen_pr.TabIndex = 0;
            this.Pct_imagen_pr.TabStop = false;
            this.Pct_imagen_pr.Click += new System.EventHandler(this.Pct_imagen_pr_Click);
            // 
            // Lbl_descripcion_pr
            // 
            this.Lbl_descripcion_pr.Location = new System.Drawing.Point(4, 111);
            this.Lbl_descripcion_pr.Name = "Lbl_descripcion_pr";
            this.Lbl_descripcion_pr.Size = new System.Drawing.Size(167, 40);
            this.Lbl_descripcion_pr.TabIndex = 1;
            this.Lbl_descripcion_pr.Text = "Producto X";
            this.Lbl_descripcion_pr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MiProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pnl_producto);
            this.Name = "MiProducto";
            this.Size = new System.Drawing.Size(180, 195);
            this.Pnl_producto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pct_imagen_pr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_producto;
        public System.Windows.Forms.PictureBox Pct_imagen_pr;
        public System.Windows.Forms.Label Lbl_descripcion_pr;
        public System.Windows.Forms.Label Lbl_preciounitario_pr;
        public System.Windows.Forms.Label Lbl_impresora;
        public System.Windows.Forms.Label Lbl_codigo_pr;
        public System.Windows.Forms.Label Lbl_archivo_txt;
    }
}
