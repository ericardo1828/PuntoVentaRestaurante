using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_PuntoVenta.Presentacion.Reportes
{
    public partial class Frm_Rpt_Boletas_Fecha : Form
    {
        public Frm_Rpt_Boletas_Fecha()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Boletas_Fecha_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_PuntoVenta_Reportes.USP_Reporte_Boleta' Puede moverla o quitarla según sea necesario.
            this.USP_Reporte_BoletaTableAdapter.Fill(this.DS_PuntoVenta_Reportes.USP_Reporte_Boleta, Cfecha: Txt_p1.Text) ;

            this.reportViewer1.RefreshReport();
        }
    }
}
