
namespace Sol_PuntoVenta.Presentacion.Reportes
{
    partial class Frm_Rpt_ImprimirComanda
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
            this.USP_Imprimir_comandaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_PuntoVenta = new Sol_PuntoVenta.Presentacion.Reportes.DS_PuntoVenta();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_Imprimir_comandaTableAdapter = new Sol_PuntoVenta.Presentacion.Reportes.DS_PuntoVentaTableAdapters.USP_Imprimir_comandaTableAdapter();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            this.Txt_p2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Imprimir_comandaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // USP_Imprimir_comandaBindingSource
            // 
            this.USP_Imprimir_comandaBindingSource.DataMember = "USP_Imprimir_comanda";
            this.USP_Imprimir_comandaBindingSource.DataSource = this.DS_PuntoVenta;
            // 
            // DS_PuntoVenta
            // 
            this.DS_PuntoVenta.DataSetName = "DS_PuntoVenta";
            this.DS_PuntoVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_ImprimirComanda";
            reportDataSource1.Value = this.USP_Imprimir_comandaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_PuntoVenta.Presentacion.Reportes.Rpt_ImprimirComanda.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(366, 510);
            this.reportViewer1.TabIndex = 0;
            // 
            // USP_Imprimir_comandaTableAdapter
            // 
            this.USP_Imprimir_comandaTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(12, 34);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(100, 20);
            this.Txt_p1.TabIndex = 5;
            this.Txt_p1.Visible = false;
            // 
            // Txt_p2
            // 
            this.Txt_p2.Location = new System.Drawing.Point(12, 60);
            this.Txt_p2.Name = "Txt_p2";
            this.Txt_p2.Size = new System.Drawing.Size(100, 20);
            this.Txt_p2.TabIndex = 6;
            this.Txt_p2.Visible = false;
            this.Txt_p2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Frm_Rpt_ImprimirComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 510);
            this.Controls.Add(this.Txt_p2);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_ImprimirComanda";
            this.Text = "Frm_Rpt_ImprimirComanda";
            this.Load += new System.EventHandler(this.Frm_Rpt_ImprimirComanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_Imprimir_comandaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PuntoVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource USP_Imprimir_comandaBindingSource;
        private DS_PuntoVenta DS_PuntoVenta;
        private DS_PuntoVentaTableAdapters.USP_Imprimir_comandaTableAdapter USP_Imprimir_comandaTableAdapter;
        internal System.Windows.Forms.TextBox Txt_p1;
        internal System.Windows.Forms.TextBox Txt_p2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}