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
    public partial class Frm_Rpt_Productos_Vendidos_x_Usuarios : Form
    {
        public Frm_Rpt_Productos_Vendidos_x_Usuarios()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Productos_Vendidos_x_Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_PuntoVenta_Reportes.USP_Reporte_Productos_Vendidos_X_Usuarios' Puede moverla o quitarla según sea necesario.
            this.USP_Reporte_Productos_Vendidos_X_UsuariosTableAdapter.Fill(this.DS_PuntoVenta_Reportes.USP_Reporte_Productos_Vendidos_X_Usuarios, Ffecha_ini: Txt_p1.Text, Ffecha_fin: Txt_p2.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
