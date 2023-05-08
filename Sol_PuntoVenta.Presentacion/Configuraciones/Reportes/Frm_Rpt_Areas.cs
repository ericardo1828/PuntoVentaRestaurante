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
    public partial class Frm_Rpt_Areas : Form
    {
        public Frm_Rpt_Areas()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Areas_Load(object sender, EventArgs e)
        {
            this.usp_mostrar_arTableAdapter.Fill(this.dS_Configuraciones.Usp_mostrar_ar, Ctexto: Txt_p1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
