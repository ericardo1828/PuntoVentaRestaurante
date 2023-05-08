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
    public partial class Frm_Rpt_Productos_Vendidos_PV : Form
    {
        public Frm_Rpt_Productos_Vendidos_PV()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Productos_Vendidos_PV_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_PuntoVenta_Reportes.USP_Reporte_Productos_Vendidos_PV' Puede moverla o quitarla según sea necesario.
            this.USP_Reporte_Productos_Vendidos_PVTableAdapter.Fill(this.DS_PuntoVenta_Reportes.USP_Reporte_Productos_Vendidos_PV, Ffecha: Txt_p1.Text, Ncodigo_pv: Convert.ToInt32(Txt_p2.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
