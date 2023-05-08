
namespace Sol_PuntoVenta.Presentacion.Reportes
{
    partial class Frm_Rpt_Tickets_PV_Anulados
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
            this.RPT_tickets_PV_AnuladoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_PuntoVenta_Reportes = new Sol_PuntoVenta.Presentacion.Reportes.DS_PuntoVenta_Reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RPT_tickets_PV_AnuladoTableAdapter = new Sol_PuntoVenta.Presentacion.Reportes.DS_PuntoVenta_ReportesTableAdapters.RPT_tickets_PV_AnuladoTableAdapter();
            this.Txt_p2 = new System.Windows.Forms.TextBox();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RPT_tickets_PV_AnuladoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // RPT_tickets_PV_AnuladoBindingSource
            // 
            this.RPT_tickets_PV_AnuladoBindingSource.DataMember = "RPT_tickets_PV_Anulado";
            this.RPT_tickets_PV_AnuladoBindingSource.DataSource = this.DS_PuntoVenta_Reportes;
            // 
            // DS_PuntoVenta_Reportes
            // 
            this.DS_PuntoVenta_Reportes.DataSetName = "DS_PuntoVenta_Reportes";
            this.DS_PuntoVenta_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Tickets_PV_Anulados";
            reportDataSource1.Value = this.RPT_tickets_PV_AnuladoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_PuntoVenta.Presentacion.Reportes.Rpt_Tickets_PV_anulados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1218, 766);
            this.reportViewer1.TabIndex = 0;
            // 
            // RPT_tickets_PV_AnuladoTableAdapter
            // 
            this.RPT_tickets_PV_AnuladoTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p2
            // 
            this.Txt_p2.Location = new System.Drawing.Point(127, 42);
            this.Txt_p2.Name = "Txt_p2";
            this.Txt_p2.Size = new System.Drawing.Size(100, 20);
            this.Txt_p2.TabIndex = 8;
            this.Txt_p2.Visible = false;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(21, 42);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 7;
            this.Txt_p1.Visible = false;
            // 
            // Frm_Rpt_Tickets_PV_Anulados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 766);
            this.Controls.Add(this.Txt_p2);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Tickets_PV_Anulados";
            this.Text = "Reporte de Tickets anulados por Punto de Venta";
            this.Load += new System.EventHandler(this.Frm_Rpt_Tickets_PV_Anulados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RPT_tickets_PV_AnuladoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta_Reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RPT_tickets_PV_AnuladoBindingSource;
        private DS_PuntoVenta_Reportes DS_PuntoVenta_Reportes;
        private DS_PuntoVenta_ReportesTableAdapters.RPT_tickets_PV_AnuladoTableAdapter RPT_tickets_PV_AnuladoTableAdapter;
        internal System.Windows.Forms.TextBox Txt_p2;
        internal System.Windows.Forms.TextBox Txt_p1;
    }
}