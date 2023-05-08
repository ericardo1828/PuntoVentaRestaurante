
namespace Sol_PuntoVenta.Presentacion.Reportes
{
    partial class Frm_Rpt_Familias
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rpt_Familias));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DS_PuntoVenta = new Sol_PuntoVenta.Presentacion.Reportes.DS_PuntoVenta();
            this.Usp_mostrar_faBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Usp_mostrar_faTableAdapter = new Sol_PuntoVenta.Presentacion.Reportes.DS_PuntoVentaTableAdapters.Usp_mostrar_faTableAdapter();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usp_mostrar_faBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DS_Familias";
            reportDataSource3.Value = this.Usp_mostrar_faBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_PuntoVenta.Presentacion.Reportes.Rpt_Familias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DS_PuntoVenta
            // 
            this.DS_PuntoVenta.DataSetName = "DS_PuntoVenta";
            this.DS_PuntoVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Usp_mostrar_faBindingSource
            // 
            this.Usp_mostrar_faBindingSource.DataMember = "Usp_mostrar_fa";
            this.Usp_mostrar_faBindingSource.DataSource = this.DS_PuntoVenta;
            // 
            // Usp_mostrar_faTableAdapter
            // 
            this.Usp_mostrar_faTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(36, 59);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 5;
            this.Txt_p1.Visible = false;
            // 
            // Frm_Rpt_Familias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Rpt_Familias";
            this.Text = "Reporte de Familias";
            this.Load += new System.EventHandler(this.Frm_Rpt_Familias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usp_mostrar_faBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Usp_mostrar_faBindingSource;
        private DS_PuntoVenta DS_PuntoVenta;
        private DS_PuntoVentaTableAdapters.Usp_mostrar_faTableAdapter Usp_mostrar_faTableAdapter;
        internal System.Windows.Forms.TextBox Txt_p1;
    }
}