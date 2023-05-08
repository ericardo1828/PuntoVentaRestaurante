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
    public partial class Frm_Rpt_Familias : Form
    {
        public Frm_Rpt_Familias()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Familias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_PuntoVenta.Usp_mostrar_fa' Puede moverla o quitarla según sea necesario.
            this.Usp_mostrar_faTableAdapter.Fill(this.DS_PuntoVenta.Usp_mostrar_fa, Ctexto: Txt_p1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
