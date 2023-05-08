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
    public partial class Frm_Reporte_Personalizados : Form
    {
        #region "Métodos"
        private void Cargar_PuntoVenta()
        {
            try
            {
                Cmb_PuntoVenta.DataSource = N_Reportes.Listar_PuntoVenta();
                Cmb_PuntoVenta.ValueMember = "codigo_pv";
                Cmb_PuntoVenta.DisplayMember = "descripcion_pv";

                Cmb_PuntoVenta2.DataSource = N_Reportes.Listar_PuntoVenta();
                Cmb_PuntoVenta2.ValueMember = "codigo_pv";
                Cmb_PuntoVenta2.DisplayMember = "descripcion_pv";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        #endregion
        public Frm_Reporte_Personalizados()
        {
            InitializeComponent();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Reporte_Personalizados_Load(object sender, EventArgs e)
        {
            this.Cargar_PuntoVenta();
            //this.reportViewer1.RefreshReport();
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            if(Cmb_PuntoVenta.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un Punto de Venta para el reporte", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Reportes.Frm_Rpt_Productos_Vendidos_PV ORpt_01 = new Reportes.Frm_Rpt_Productos_Vendidos_PV();
                ORpt_01.Txt_p1.Text = Dtp_fecha.Text;
                ORpt_01.Txt_p2.Text = Convert.ToString(Cmb_PuntoVenta.SelectedValue);
                ORpt_01.ShowDialog();
            }
            
        }

        private void Btn_reporte2_Click(object sender, EventArgs e)
        {
            if (Cmb_PuntoVenta2.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un Punto de Venta para el reporte", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Reportes.Frm_Rpt_Boletas_Facturas_PV ORpt_03 = new Reportes.Frm_Rpt_Boletas_Facturas_PV();
                ORpt_03.Txt_p1.Text = Dtp_fecha2.Text;
                ORpt_03.Txt_p2.Text = Convert.ToString(Cmb_PuntoVenta2.SelectedValue);
                ORpt_03.ShowDialog();
            }
        }

        private void Btn_reporte3_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Productos_Vendidos ORpt_04 = new Reportes.Frm_Rpt_Productos_Vendidos();
            ORpt_04.Txt_p1.Text = Dtp_fecha_ini.Text;
            ORpt_04.Txt_p2.Text = Dtp_fecha_fin.Text;
            ORpt_04.ShowDialog();
        }

        private void Btn_reporte4_Click(object sender, EventArgs e)
        {
             Reportes.Frm_Rpt_Productos_Vendidos_x_Usuarios ORpt_05 = new Reportes.Frm_Rpt_Productos_Vendidos_x_Usuarios();
            ORpt_05.Txt_p1.Text = Dtp_fecha_ini2.Text;
            ORpt_05.Txt_p2.Text = Dtp_fecha_fin2.Text;
            ORpt_05.ShowDialog();
        }
    }
}
