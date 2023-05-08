using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_PuntoVenta.Presentacion
{
    public partial class Frm_Reporte_Boletas_Fecha : Form
    {
        public Frm_Reporte_Boletas_Fecha()
        {
            InitializeComponent();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Boletas_Fecha ORpt_BF = new Reportes.Frm_Rpt_Boletas_Fecha();
            ORpt_BF.Txt_p1.Text = Dtp_fechaemision.Text;           
            ORpt_BF.ShowDialog();
        }
    }
}
