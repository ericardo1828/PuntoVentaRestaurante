
namespace Sol_PuntoVenta.Presentacion.Reportes
{
    partial class Frm_Rpt_Tickets_PV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rpt_Tickets_PV));
            this.RPT_tickets_PVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_PuntoVenta_Reportes = new Sol_PuntoVenta.Presentacion.Reportes.DS_PuntoVenta_Reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            this.Txt_p2 = new System.Windows.Forms.TextBox();
            this.RPT_tickets_PVTableAdapter = new Sol_PuntoVenta.Presentacion.Reportes.DS_PuntoVenta_ReportesTableAdapters.RPT_tickets_PVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RPT_tickets_PVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // RPT_tickets_PVBindingSource
            // 
            this.RPT_tickets_PVBindingSource.DataMember = "RPT_tickets_PV";
            this.RPT_tickets_PVBindingSource.DataSource = this.DS_PuntoVenta_Reportes;
            // 
            // DS_PuntoVenta_Reportes
            // 
            this.DS_PuntoVenta_Reportes.DataSetName = "DS_PuntoVenta_Reportes";
            this.DS_PuntoVenta_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Tickets_PV";
            reportDataSource1.Value = this.RPT_tickets_PVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_PuntoVenta.Presentacion.Reportes.Rpt_Tickets_PV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1218, 766);
            this.reportViewer1.TabIndex = 0;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(28, 43);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 5;
            this.Txt_p1.Visible = false;
            // 
            // Txt_p2
            // 
            this.Txt_p2.Location = new System.Drawing.Point(134, 43);
            this.Txt_p2.Name = "Txt_p2";
            this.Txt_p2.Size = new System.Drawing.Size(100, 20);
            this.Txt_p2.TabIndex = 6;
            this.Txt_p2.Visible = false;
            // 
            // RPT_tickets_PVTableAdapter
            // 
            this.RPT_tickets_PVTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Rpt_Tickets_PV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 766);
            this.Controls.Add(this.Txt_p2);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Rpt_Tickets_PV";
            this.Text = "Reporte de Tickets por Punto de Venta";
            this.Load += new System.EventHandler(this.Frm_Rpt_Tickets_PV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RPT_tickets_PVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta_Reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RPT_tickets_PVBindingSource;
        private DS_PuntoVenta_Reportes DS_PuntoVenta_Reportes;
        private DS_PuntoVenta_ReportesTableAdapters.RPT_tickets_PVTableAdapter RPT_tickets_PVTableAdapter;
        internal System.Windows.Forms.TextBox Txt_p1;
        internal System.Windows.Forms.TextBox Txt_p2;
    }
}