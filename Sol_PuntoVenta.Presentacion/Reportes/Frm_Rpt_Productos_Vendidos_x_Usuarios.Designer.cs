
namespace Sol_PuntoVenta.Presentacion.Reportes
{
    partial class Frm_Rpt_Productos_Vendidos_x_Usuarios
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DS_PuntoVenta_Reportes = new Sol_PuntoVenta.Presentacion.Reportes.DS_PuntoVenta_Reportes();
            this.USP_Reporte_Productos_Vendidos_X_UsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_Reporte_Productos_Vendidos_X_UsuariosTableAdapter = new Sol_PuntoVenta.Presentacion.Reportes.DS_PuntoVenta_ReportesTableAdapters.USP_Reporte_Productos_Vendidos_X_UsuariosTableAdapter();
            this.Txt_p2 = new System.Windows.Forms.TextBox();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Reporte_Productos_Vendidos_X_UsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DS_Productos_Vendidos_x_Usuarios";
            reportDataSource2.Value = this.USP_Reporte_Productos_Vendidos_X_UsuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_PuntoVenta.Presentacion.Reportes.Rpt_Productos_Vendidos_x_Usuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(870, 749);
            this.reportViewer1.TabIndex = 0;
            // 
            // DS_PuntoVenta_Reportes
            // 
            this.DS_PuntoVenta_Reportes.DataSetName = "DS_PuntoVenta_Reportes";
            this.DS_PuntoVenta_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_Reporte_Productos_Vendidos_X_UsuariosBindingSource
            // 
            this.USP_Reporte_Productos_Vendidos_X_UsuariosBindingSource.DataMember = "USP_Reporte_Productos_Vendidos_X_Usuarios";
            this.USP_Reporte_Productos_Vendidos_X_UsuariosBindingSource.DataSource = this.DS_PuntoVenta_Reportes;
            // 
            // USP_Reporte_Productos_Vendidos_X_UsuariosTableAdapter
            // 
            this.USP_Reporte_Productos_Vendidos_X_UsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p2
            // 
            this.Txt_p2.Location = new System.Drawing.Point(132, 46);
            this.Txt_p2.Name = "Txt_p2";
            this.Txt_p2.Size = new System.Drawing.Size(100, 20);
            this.Txt_p2.TabIndex = 12;
            this.Txt_p2.Visible = false;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(26, 46);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 11;
            this.Txt_p1.Visible = false;
            // 
            // Frm_Rpt_Productos_Vendidos_x_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 749);
            this.Controls.Add(this.Txt_p2);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Productos_Vendidos_x_Usuarios";
            this.Text = "Frm_Rpt_Productos_Vendidos_x_Usuarios";
            this.Load += new System.EventHandler(this.Frm_Rpt_Productos_Vendidos_x_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Reporte_Productos_Vendidos_X_UsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_Reporte_Productos_Vendidos_X_UsuariosBindingSource;
        private DS_PuntoVenta_Reportes DS_PuntoVenta_Reportes;
        private DS_PuntoVenta_ReportesTableAdapters.USP_Reporte_Productos_Vendidos_X_UsuariosTableAdapter USP_Reporte_Productos_Vendidos_X_UsuariosTableAdapter;
        internal System.Windows.Forms.TextBox Txt_p2;
        internal System.Windows.Forms.TextBox Txt_p1;
    }
}