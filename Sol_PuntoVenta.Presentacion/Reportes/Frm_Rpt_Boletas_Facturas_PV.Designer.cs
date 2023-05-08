
namespace Sol_PuntoVenta.Presentacion.Reportes
{
    partial class Frm_Rpt_Boletas_Facturas_PV
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.USP_Reporte_Ticketsde_BoletasyFacturas_PVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_PuntoVenta_Reportes = new Sol_PuntoVenta.Presentacion.Reportes.DS_PuntoVenta_Reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_Reporte_Ticketsde_BoletasyFacturas_PVTableAdapter = new Sol_PuntoVenta.Presentacion.Reportes.DS_PuntoVenta_ReportesTableAdapters.USP_Reporte_Ticketsde_BoletasyFacturas_PVTableAdapter();
            this.Txt_p2 = new System.Windows.Forms.TextBox();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Reporte_Ticketsde_BoletasyFacturas_PVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // USP_Reporte_Ticketsde_BoletasyFacturas_PVBindingSource
            // 
            this.USP_Reporte_Ticketsde_BoletasyFacturas_PVBindingSource.DataMember = "USP_Reporte_Ticketsde_BoletasyFacturas_PV";
            this.USP_Reporte_Ticketsde_BoletasyFacturas_PVBindingSource.DataSource = this.DS_PuntoVenta_Reportes;
            // 
            // DS_PuntoVenta_Reportes
            // 
            this.DS_PuntoVenta_Reportes.DataSetName = "DS_PuntoVenta_Reportes";
            this.DS_PuntoVenta_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Boletas_Facturas_PV";
            reportDataSource1.Value = this.USP_Reporte_Ticketsde_BoletasyFacturas_PVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_PuntoVenta.Presentacion.Reportes.Rpt_Boletas_Facturas_PV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // USP_Reporte_Ticketsde_BoletasyFacturas_PVTableAdapter
            // 
            this.USP_Reporte_Ticketsde_BoletasyFacturas_PVTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p2
            // 
            this.Txt_p2.Location = new System.Drawing.Point(131, 60);
            this.Txt_p2.Name = "Txt_p2";
            this.Txt_p2.Size = new System.Drawing.Size(100, 20);
            this.Txt_p2.TabIndex = 10;
            this.Txt_p2.Visible = false;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(25, 60);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 9;
            this.Txt_p1.Visible = false;
            // 
            // Frm_Rpt_Boletas_Facturas_PV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_p2);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Boletas_Facturas_PV";
            this.Text = "Reporte de Boletas y Facturas por Punto de Venta";
            this.Load += new System.EventHandler(this.Frm_Rpt_Boletas_Facturas_PV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_Reporte_Ticketsde_BoletasyFacturas_PVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta_Reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_Reporte_Ticketsde_BoletasyFacturas_PVBindingSource;
        private DS_PuntoVenta_Reportes DS_PuntoVenta_Reportes;
        private DS_PuntoVenta_ReportesTableAdapters.USP_Reporte_Ticketsde_BoletasyFacturas_PVTableAdapter USP_Reporte_Ticketsde_BoletasyFacturas_PVTableAdapter;
        internal System.Windows.Forms.TextBox Txt_p2;
        internal System.Windows.Forms.TextBox Txt_p1;
    }
}