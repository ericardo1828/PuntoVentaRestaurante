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
    public partial class Frm_Rpt_Imprimir_Precuenta : Form
    {
        public Frm_Rpt_Imprimir_Precuenta()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Imprimir_Precuenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_PuntoVenta.USP_Precuenta_Tickets_Seleccionados' Puede moverla o quitarla según sea necesario.
            //this.USP_Precuenta_Tickets_SeleccionadosTableAdapter.Fill(this.DS_PuntoVenta.USP_Precuenta_Tickets_Seleccionados);

            //this.reportViewer1.RefreshReport();
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }      
    }
}
