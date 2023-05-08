
namespace Sol_PuntoVenta.Presentacion.Reportes
{
    partial class Frm_Rpt_Productos_Vendidos
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
            this.USP_Reporte_Productos_VendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_Reporte_Productos_VendidosTableAdapter = new Sol_PuntoVenta.Presentacion.Reportes.DS_PuntoVenta_ReportesTableAdapters.USP_Reporte_Productos_VendidosTableAdapter();
            this.Txt_p2 = new System.Windows.Forms.TextBox();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Reporte_Productos_VendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DS_Reporte_Productos_Vendidos";
            reportDataSource2.Value = this.USP_Reporte_Productos_VendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_PuntoVenta.Presentacion.Reportes.Rpt_Productos_Vendidos.rdlc";
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
            // USP_Reporte_Productos_VendidosBindingSource
            // 
            this.USP_Reporte_Productos_VendidosBindingSource.DataMember = "USP_Reporte_Productos_Vendidos";
            this.USP_Reporte_Productos_VendidosBindingSource.DataSource = this.DS_PuntoVenta_Reportes;
            // 
            // USP_Reporte_Productos_VendidosTableAdapter
            // 
            this.USP_Reporte_Productos_VendidosTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p2
            // 
            this.Txt_p2.Location = new System.Drawing.Point(145, 49);
            this.Txt_p2.Name = "Txt_p2";
            this.Txt_p2.Size = new System.Drawing.Size(100, 20);
            this.Txt_p2.TabIndex = 10;
            this.Txt_p2.Visible = false;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(39, 49);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 9;
            this.Txt_p1.Visible = false;
            // 
            // Frm_Rpt_Productos_Vendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 749);
            this.Controls.Add(this.Txt_p2);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Productos_Vendidos";
            this.Text = "Frm_Rpt_Productos_Vendidos";
            this.Load += new System.EventHandler(this.Frm_Rpt_Productos_Vendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Reporte_Productos_VendidosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_Reporte_Productos_VendidosBindingSource;
        private DS_PuntoVenta_Reportes DS_PuntoVenta_Reportes;
        private DS_PuntoVenta_ReportesTableAdapters.USP_Reporte_Productos_VendidosTableAdapter USP_Reporte_Productos_VendidosTableAdapter;
        internal System.Windows.Forms.TextBox Txt_p2;
        internal System.Windows.Forms.TextBox Txt_p1;
    }
}