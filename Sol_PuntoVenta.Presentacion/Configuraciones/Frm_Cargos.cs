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
    public partial class Frm_Cargos : Form
    {
        public Frm_Cargos()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int Codigo_cr = 0;
        int Codigo_ar = 0;
        int EstadoGuarda = 0;
        #endregion

        #region "Mis Métodos"
        private void Formato()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].Visible = false;
            Dgv_Listado.Columns[1].Width = 100;
            Dgv_Listado.Columns[1].HeaderText = "CÓDIGO CR";
            Dgv_Listado.Columns[2].Width = 320;
            Dgv_Listado.Columns[2].HeaderText = "ÁREAS";
            Dgv_Listado.Columns[3].Width = 320;
            Dgv_Listado.Columns[3].HeaderText = "CARGOS";
            Dgv_Listado.Columns[4].Visible = false;
        }

        private void Mostrar(string Ctexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Cargos.Mostrar_cr(Ctexto);
                this.Formato();
                Lbl_total.Text = "Total registros: " + Convert.ToString(Dgv_Listado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_cr"].Value)))
            {
                MessageBox.Show("Seleccione un registro ", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Codigo_cr = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_cr"].Value);
                Txt_descripcion_ar.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_ar"].Value);
                Codigo_ar = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_ar"].Value);
                Txt_descripcion_cr.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_cr"].Value);
            }
        }

        private void Formato_ar()
        {
            Dgv_Listado_ar.Columns[0].Width = 250;
            Dgv_Listado_ar.Columns[0].HeaderText = "ÁREA";
            Dgv_Listado_ar.Columns[1].Visible = false;
        }

        private void Listar_ar(string Ctexto)
        {
            try
            {
                Dgv_Listado_ar.DataSource = N_Cargos.Listar_ar(Ctexto);
                this.Formato_ar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_ar()
        {
            Codigo_ar = Convert.ToInt32(Dgv_Listado_ar.CurrentRow.Cells["codigo_ar"].Value);
            Txt_descripcion_ar.Text = Convert.ToString(Dgv_Listado_ar.CurrentRow.Cells["descripcion_ar"].Value);
        }
        private void Estado_Limpiar(bool Lestado)
        {
            Btn_cancelar.Visible = Lestado;
            Btn_guardar.Visible = Lestado;
            Btn_retornar.Visible = !Lestado;

            Txt_buscar.Clear();
            Txt_descripcion_cr.Clear();
            Txt_descripcion_cr.ReadOnly = !Lestado;
            Pnl_listado_ar.Visible = false;
        }

        private void Estado_BotonesPrincipales(bool Lestado)
        {
            Btn_nuevo.Enabled = Lestado;
            Btn_actualizar.Enabled = Lestado;
            Btn_eliminar.Enabled = Lestado;
            Btn_reporte.Enabled = Lestado;
            Btn_salir.Enabled = Lestado;
            btn_lupa.Visible = !Lestado;

            if (this.EstadoGuarda > 0)
            {
                Dgv_Listado.Enabled = Lestado;
            }
            else
            {
                Dgv_Listado.Enabled = true;
            }
            Txt_buscar.Enabled = Lestado;
            Btn_buscar.Enabled = Lestado;
        }
        #endregion

        private void Frm_Cargos_Load(object sender, EventArgs e)
        {
            this.Mostrar("%");
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Mostrar(Txt_buscar.Text);
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_descripcion_cr.Text == string.Empty ||
                    Txt_descripcion_ar.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    E_Cargos eCr = new E_Cargos();
                    string Cduplica, Rpta = "";
                    eCr.Codigo_ar = Codigo_ar;
                    eCr.Codigo_cr = Codigo_cr;
                    eCr.Descripcion_cr = Txt_descripcion_cr.Text.Trim();
                   
                    // Verificamos si la información que se intenta guardar ya existe en la tabla
                    Cduplica = N_Cargos.Verifica_duplicado_cr(this.EstadoGuarda, eCr.Codigo_cr, eCr.Descripcion_cr);
                    if (Cduplica == "")
                    {
                        Rpta = N_Cargos.Guardar_cr(this.EstadoGuarda, eCr);
                        if (Rpta.Equals("OK"))
                        {
                            MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Estado_Limpiar(false);
                            Codigo_cr = 0;
                            this.EstadoGuarda = 0;
                            this.Mostrar("%");
                            Tbp_general.SelectedIndex = 0;
                            this.Estado_BotonesPrincipales(true);
                        }
                        else
                        {
                            MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Los datos que se intenta guardar ya existe en la base de datos con el código: " + Cduplica, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.EstadoGuarda = 1; //Nuevo registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_Limpiar(true);
            Codigo_cr = 0;
            Tbp_general.SelectedIndex = 1;
            Txt_descripcion_cr.Select();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Estado_Limpiar(false);
            Codigo_cr = 0;
            this.EstadoGuarda = 0;
            Tbp_general.SelectedIndex = 0;
            this.Estado_BotonesPrincipales(true);
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            if (this.Dgv_Listado.Rows.Count > 0)
            {
                this.EstadoGuarda = 2; //Actualizar registro
                this.Estado_BotonesPrincipales(false);
                this.Estado_Limpiar(true);
                this.Selecciona_dgv();
                Tbp_general.SelectedIndex = 1;
                Txt_descripcion_cr.Select();
            }

        }

        private void Dgv_Listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Estado_Limpiar(false);
            this.Selecciona_dgv();
            Tbp_general.SelectedIndex = 1;
        }

        private void Btn_retornar_Click(object sender, EventArgs e)
        {
            this.Estado_Limpiar(false);
            this.EstadoGuarda = 0;
            Tbp_general.SelectedIndex = 0;
            this.Estado_BotonesPrincipales(true);
        }

        private void Dgv_Listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Listado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)Dgv_Listado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }

        }

        private void Btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Estas seguro de eliminar los registros seleccionados?", "Aviso del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in Dgv_Listado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = N_Cargos.Eliminar_cr(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                // por definir que mensaje ubicar
                            }
                            else
                            {
                                MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    this.Mostrar("%");
                    Btn_cancelar2.Visible = false;
                    Btn_confirmar.Visible = false;
                    this.Estado_BotonesPrincipales(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Listado.Rows.Count > 0)
            {
                this.Estado_BotonesPrincipales(false);
                Dgv_Listado.Columns[0].Visible = true;
                Btn_cancelar2.Visible = true;
                Btn_confirmar.Visible = true;
                Tbp_general.SelectedIndex = 0;
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Configuraciones.Reportes.Frm_Rpt_Cargos ORpt_cr = new Configuraciones.Reportes.Frm_Rpt_Cargos();
            ORpt_cr.Txt_p1.Text = Txt_buscar.Text;
            ORpt_cr.ShowDialog();
        }

        private void btn_lupa_Click(object sender, EventArgs e)
        {
            Pnl_listado_ar.Visible = true;
            Txt_buscar_ar.Select();
            this.Listar_ar(Txt_buscar_ar.Text);
        }

        private void Btn_retornar_ar_Click(object sender, EventArgs e)
        {
            Pnl_listado_ar.Visible = false;
        }

        private void Btn_buscar_ar_Click(object sender, EventArgs e)
        {
            this.Listar_ar(Txt_buscar_ar.Text);
        }

        private void Dgv_Listado_ar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_ar();
            Pnl_listado_ar.Visible = false;
        }

        private void Btn_cancelar2_Click(object sender, EventArgs e)
        {
            this.Estado_BotonesPrincipales(true);
            Dgv_Listado.Columns[0].Visible = false;
            foreach (DataGridViewRow row in Dgv_Listado.Rows)
            {
                row.Cells["Seleccionar"].Value = false;
            }
            Btn_cancelar2.Visible = false;
            Btn_confirmar.Visible = false;
        }
    }
}
