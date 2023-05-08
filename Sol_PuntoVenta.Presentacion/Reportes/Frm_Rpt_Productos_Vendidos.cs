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
    public partial class Frm_Rpt_Productos_Vendidos : Form
    {
        public Frm_Rpt_Productos_Vendidos()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Productos_Vendidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_PuntoVenta_Reportes.USP_Reporte_Productos_Vendidos' Puede moverla o quitarla según sea necesario.
            this.USP_Reporte_Productos_VendidosTableAdapter.Fill(this.DS_PuntoVenta_Reportes.USP_Reporte_Productos_Vendidos, Ffecha_ini: Txt_p1.Text, Ffecha_fin: Txt_p2.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
