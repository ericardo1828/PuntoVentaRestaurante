namespace Sol_PuntoVenta.Presentacion.Configuraciones.Reportes
{
    partial class Frm_Rpt_Areas
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
            this.uspmostrararBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Configuraciones = new Sol_PuntoVenta.Presentacion.Configuraciones.Reportes.DS_Configuraciones();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usp_mostrar_arTableAdapter = new Sol_PuntoVenta.Presentacion.Configuraciones.Reportes.DS_ConfiguracionesTableAdapters.Usp_mostrar_arTableAdapter();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uspmostrararBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Configuraciones)).BeginInit();
            this.SuspendLayout();
            // 
            // uspmostrararBindingSource
            // 
            this.uspmostrararBindingSource.DataMember = "Usp_mostrar_ar";
            this.uspmostrararBindingSource.DataSource = this.dS_Configuraciones;
            // 
            // dS_Configuraciones
            // 
            this.dS_Configuraciones.DataSetName = "DS_Configuraciones";
            this.dS_Configuraciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uspmostrararBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_PuntoVenta.Presentacion.Configuraciones.Reportes.Rpt_Areas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 545);
            this.reportViewer1.TabIndex = 0;
            // 
            // usp_mostrar_arTableAdapter
            // 
            this.usp_mostrar_arTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(12, 41);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 4;
            this.Txt_p1.Visible = false;
            // 
            // Frm_Rpt_Areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Areas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Rpt_Areas";
            this.Load += new System.EventHandler(this.Frm_Rpt_Areas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspmostrararBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Configuraciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspmostrararBindingSource;
        private DS_Configuraciones dS_Configuraciones;
        private DS_ConfiguracionesTableAdapters.Usp_mostrar_arTableAdapter usp_mostrar_arTableAdapter;
        internal System.Windows.Forms.TextBox Txt_p1;
    }
}