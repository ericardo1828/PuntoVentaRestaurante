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
    public partial class Frm_Consultas_Boletas_Facturas : Form
    {
        public Frm_Consultas_Boletas_Facturas()
        {
            InitializeComponent();
        }
        #region "Métodos"
        private void Formato_bo()
        {
            Dgv_Listado.Columns[0].Width = 90;
            Dgv_Listado.Columns[0].HeaderText = "CÓDIGO BO";
            Dgv_Listado.Columns[1].Width = 300;
            Dgv_Listado.Columns[1].HeaderText = "CLIENTE";
            Dgv_Listado.Columns[2].Width = 130;
            Dgv_Listado.Columns[2].HeaderText = "NRO. DOC.";
            Dgv_Listado.Columns[3].Width = 240;
            Dgv_Listado.Columns[3].HeaderText = "DIRECCIÓN";
            Dgv_Listado.Columns[4].Width = 120;
            Dgv_Listado.Columns[4].HeaderText = "FECHA EMISIÓN";
            Dgv_Listado.Columns[5].Width = 120;
            Dgv_Listado.Columns[5].HeaderText = "IMPORTE TOTAL";
        }

        private void Mostrar_bo(string Ctexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Consultas_Boletas_Facturas.Listar_bo(Ctexto);
                this.Formato_bo();
                Lbl_total.Text = "Total Nro .registros: " + Convert.ToString(Dgv_Listado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_bo()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_bo"].Value)))
            {
                MessageBox.Show("Seleccione un registro ", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int Ncodigo_bo;
                Ncodigo_bo = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_bo"].Value);

                Reportes.Frm_Rpt_Imprimir_Boleta ORpt_bo = new Reportes.Frm_Rpt_Imprimir_Boleta();
                ORpt_bo.Txt_p1.Text =Convert.ToString(Ncodigo_bo);
                ORpt_bo.ShowDialog();
            }
        }


        private void Formato_fa()
        {
            Dgv_Listado2.Columns[0].Width = 90;
            Dgv_Listado2.Columns[0].HeaderText = "CÓDIGO FA";
            Dgv_Listado2.Columns[1].Width = 300;
            Dgv_Listado2.Columns[1].HeaderText = "CLIENTE";
            Dgv_Listado2.Columns[2].Width = 130;
            Dgv_Listado2.Columns[2].HeaderText = "NRO. DOC.";
            Dgv_Listado2.Columns[3].Width = 240;
            Dgv_Listado2.Columns[3].HeaderText = "DIRECCIÓN";
            Dgv_Listado2.Columns[4].Width = 120;
            Dgv_Listado2.Columns[4].HeaderText = "FECHA EMISIÓN";
            Dgv_Listado2.Columns[5].Width = 120;
            Dgv_Listado2.Columns[5].HeaderText = "IMPORTE TOTAL";
        }

        private void Mostrar_fa(string Ctexto)
        {
            try
            {
                Dgv_Listado2.DataSource = N_Consultas_Boletas_Facturas.Listar_fa(Ctexto);
                this.Formato_fa();
                Lbl_total2.Text = "Total Nro .registros: " + Convert.ToString(Dgv_Listado2.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_fa()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Listado2.CurrentRow.Cells["codigo_fa"].Value)))
            {
                MessageBox.Show("Seleccione un registro ", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int Ncodigo_fa;
                Ncodigo_fa = Convert.ToInt32(Dgv_Listado2.CurrentRow.Cells["codigo_fa"].Value);

                Reportes.Frm_Rpt_Imprimir_Factura ORpt_fa = new Reportes.Frm_Rpt_Imprimir_Factura();
                ORpt_fa.Txt_p1.Text = Convert.ToString(Ncodigo_fa);
                ORpt_fa.ShowDialog();
            }
        }
        #endregion
        private void Frm_Consultas_Boletas_Facturas_Load(object sender, EventArgs e)
        {
            this.Mostrar_bo("%");
            this.Mostrar_fa("%");
            Txt_buscar.Select();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Mostrar_bo(Txt_buscar.Text);
        }

        private void Btn_imprimir_bo_Click(object sender, EventArgs e)
        {
            this.Selecciona_dgv_bo();
        }

        private void Btn_imprimir_fa_Click(object sender, EventArgs e)
        {
            this.Selecciona_dgv_fa();
        }

        private void Btn_buscar2_Click(object sender, EventArgs e)
        {
            this.Mostrar_fa(Txt_buscar2.Text);
        }
    }
}
