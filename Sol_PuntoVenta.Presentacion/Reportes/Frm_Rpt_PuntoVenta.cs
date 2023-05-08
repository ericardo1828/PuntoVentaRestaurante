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
    public partial class Frm_Rpt_PuntoVenta : Form
    {
        public Frm_Rpt_PuntoVenta()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_PuntoVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_PuntoVenta.Usp_mostrar_pv' Puede moverla o quitarla según sea necesario.
            this.Usp_mostrar_pvTableAdapter.Fill(this.DS_PuntoVenta.Usp_mostrar_pv, Ctexto: Txt_p1.Text);

            this.reportViewer1.RefreshReport();          
        }
    }
}
