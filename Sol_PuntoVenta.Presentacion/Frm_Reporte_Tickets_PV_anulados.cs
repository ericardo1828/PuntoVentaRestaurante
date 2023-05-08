using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_PuntoVenta.Negocio;
using Sol_PuntoVenta.Entidades;

namespace Sol_PuntoVenta.Presentacion
{
    public partial class Frm_Reporte_Tickets_PV_anulados : Form
    {
        #region "Métodos"
        private void Cargar_PuntoVenta()
        {
            try
            {
                Cmb_PuntoVenta.DataSource = N_Reportes.Listar_PuntoVenta();
                Cmb_PuntoVenta.ValueMember = "codigo_pv";
                Cmb_PuntoVenta.DisplayMember = "descripcion_pv";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        #endregion
        public Frm_Reporte_Tickets_PV_anulados()
        {
            InitializeComponent();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Reporte_Tickets_PV_anulados_Load(object sender, EventArgs e)
        {
            this.Cargar_PuntoVenta();
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            if (Cmb_PuntoVenta.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un Punto de Venta para el reporte", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Reportes.Frm_Rpt_Tickets_PV_Anulados ORpt_tpv_a = new Reportes.Frm_Rpt_Tickets_PV_Anulados();
                ORpt_tpv_a.Txt_p1.Text = Dtp_fechaemision.Text;
                ORpt_tpv_a.Txt_p2.Text = Convert.ToString(Cmb_PuntoVenta.SelectedValue);
                ORpt_tpv_a.ShowDialog();
            }

        }
    }
}
