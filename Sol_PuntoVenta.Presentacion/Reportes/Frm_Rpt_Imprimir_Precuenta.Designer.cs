
namespace Sol_PuntoVenta.Presentacion.Reportes
{
    partial class Frm_Rpt_Imprimir_Precuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rpt_Imprimir_Precuenta));
            this.USP_Precuenta_Tickets_SeleccionadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_PuntoVenta = new Sol_PuntoVenta.Presentacion.Reportes.DS_PuntoVenta();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_Precuenta_Tickets_SeleccionadosTableAdapter = new Sol_PuntoVenta.Presentacion.Reportes.DS_PuntoVentaTableAdapters.USP_Precuenta_Tickets_SeleccionadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Precuenta_Tickets_SeleccionadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // USP_Precuenta_Tickets_SeleccionadosBindingSource
            // 
            this.USP_Precuenta_Tickets_SeleccionadosBindingSource.DataMember = "USP_Precuenta_Tickets_Seleccionados";
            this.USP_Precuenta_Tickets_SeleccionadosBindingSource.DataSource = this.DS_PuntoVenta;
            // 
            // DS_PuntoVenta
            // 
            this.DS_PuntoVenta.DataSetName = "DS_PuntoVenta";
            this.DS_PuntoVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Imprimir_Precuenta";
            reportDataSource1.Value = this.USP_Precuenta_Tickets_SeleccionadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_PuntoVenta.Presentacion.Reportes.Rpt_Imprimir_Precuenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(454, 768);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // USP_Precuenta_Tickets_SeleccionadosTableAdapter
            // 
            this.USP_Precuenta_Tickets_SeleccionadosTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Rpt_Imprimir_Precuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 768);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Rpt_Imprimir_Precuenta";
            this.Text = "Ticket Precuenta";
            this.Load += new System.EventHandler(this.Frm_Rpt_Imprimir_Precuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_Precuenta_Tickets_SeleccionadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public DS_PuntoVentaTableAdapters.USP_Precuenta_Tickets_SeleccionadosTableAdapter USP_Precuenta_Tickets_SeleccionadosTableAdapter;
        public System.Windows.Forms.BindingSource USP_Precuenta_Tickets_SeleccionadosBindingSource;
        public DS_PuntoVenta DS_PuntoVenta;
    }
}