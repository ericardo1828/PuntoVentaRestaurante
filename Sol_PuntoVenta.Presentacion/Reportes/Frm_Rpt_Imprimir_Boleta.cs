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
    public partial class Frm_Rpt_Imprimir_Boleta : Form
    {
        public Frm_Rpt_Imprimir_Boleta()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Imprimir_Boleta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_PuntoVenta.USP_Imprimir_Boleta' Puede moverla o quitarla según sea necesario.
            this.USP_Imprimir_BoletaTableAdapter.Fill(this.DS_PuntoVenta.USP_Imprimir_Boleta, Ncodigo_bol:Convert.ToInt32(Txt_p1.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
