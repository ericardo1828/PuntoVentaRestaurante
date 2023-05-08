
namespace Sol_PuntoVenta.Presentacion.Reportes
{
    partial class Frm_Rpt_Imprimir_Boleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rpt_Imprimir_Boleta));
            this.USP_Imprimir_BoletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_PuntoVenta = new Sol_PuntoVenta.Presentacion.Reportes.DS_PuntoVenta();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_Imprimir_BoletaTableAdapter = new Sol_PuntoVenta.Presentacion.Reportes.DS_PuntoVentaTableAdapters.USP_Imprimir_BoletaTableAdapter();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Imprimir_BoletaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // USP_Imprimir_BoletaBindingSource
            // 
            this.USP_Imprimir_BoletaBindingSource.DataMember = "USP_Imprimir_Boleta";
            this.USP_Imprimir_BoletaBindingSource.DataSource = this.DS_PuntoVenta;
            // 
            // DS_PuntoVenta
            // 
            this.DS_PuntoVenta.DataSetName = "DS_PuntoVenta";
            this.DS_PuntoVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Boleta";
            reportDataSource1.Value = this.USP_Imprimir_BoletaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_PuntoVenta.Presentacion.Reportes.Rpt_Imprimir_Boleta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(416, 623);
            this.reportViewer1.TabIndex = 0;
            // 
            // USP_Imprimir_BoletaTableAdapter
            // 
            this.USP_Imprimir_BoletaTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(27, 55);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 5;
            this.Txt_p1.Visible = false;
            // 
            // Frm_Rpt_Imprimir_Boleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 623);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Rpt_Imprimir_Boleta";
            this.Text = "Orden de Venta - BOLETA";
            this.Load += new System.EventHandler(this.Frm_Rpt_Imprimir_Boleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_Imprimir_BoletaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_Imprimir_BoletaBindingSource;
        private DS_PuntoVenta DS_PuntoVenta;
        private DS_PuntoVentaTableAdapters.USP_Imprimir_BoletaTableAdapter USP_Imprimir_BoletaTableAdapter;
        internal System.Windows.Forms.TextBox Txt_p1;
    }
}