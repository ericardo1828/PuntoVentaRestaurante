using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_PuntoVenta.Presentacion.Configuraciones.Reportes
{
    public partial class Frm_Rpt_Usuarios : Form
    {
        public Frm_Rpt_Usuarios()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Usuarios_Load(object sender, EventArgs e)
        {
            this.uSP_Listado_usTableAdapter.Fill(this.dS_Configuraciones.USP_Listado_us, cTexto: Txt_p1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
