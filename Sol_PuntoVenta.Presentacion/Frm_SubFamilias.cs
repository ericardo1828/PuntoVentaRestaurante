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
    public partial class Frm_SubFamilias : Form
    {
        public Frm_SubFamilias()
        {
           InitializeComponent();
        }
        #region "Mis Variables"
        int Codigo_sf = 0;
        int Codigo_fa = 0;
        int EstadoGuarda = 0;  
        #endregion

        #region "Mis Métodos"
        private void Formato()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].Visible = false;
            Dgv_Listado.Columns[1].Width = 100;
            Dgv_Listado.Columns[1].HeaderText = "CÓDIGO SF";
            Dgv_Listado.Columns[2].Width = 300;
            Dgv_Listado.Columns[2].HeaderText = "CATEGORIA";
            Dgv_Listado.Columns[3].Width = 300;
            Dgv_Listado.Columns[3].HeaderText = "FAMILIA";
            Dgv_Listado.Columns[4].Width = 300;
            Dgv_Listado.Columns[4].HeaderText = "SUBFAMILIA";
            Dgv_Listado.Columns[5].Visible=false;            
        }   

        private void Mostrar(string Ctexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_SubFamilias.Mostrar_sf(Ctexto);
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
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_sf"].Value)))
            {
                MessageBox.Show("Seleccione un registro ", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Codigo_sf = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_sf"].Value);
                Txt_descripcion_fa.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_ca"].Value) + " - " + Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_fa"].Value);
                Codigo_fa = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_fa"].Value);
                Txt_descripcion_sf.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_sf"].Value);
            }
        }

        private void Formato_fa()
        {
            Dgv_Listado_fa.Columns[0].Width = 280;
            Dgv_Listado_fa.Columns[0].HeaderText = "CATEGORIA";
            Dgv_Listado_fa.Columns[1].Width = 280;
            Dgv_Listado_fa.Columns[1].HeaderText = "FAMILIA";
            Dgv_Listado_fa.Columns[2].Visible = false;         
        }

        private void Listar_fa(string Ctexto)
        {
            try
            {
                Dgv_Listado_fa.DataSource = N_SubFamilias.Listar_fa(Ctexto);
                this.Formato_fa();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_fa()
        {
            Codigo_fa = Convert.ToInt32(Dgv_Listado_fa.CurrentRow.Cells["codigo_fa"].Value);
            Txt_descripcion_fa.Text = Convert.ToString(Dgv_Listado_fa.CurrentRow.Cells["descripcion_ca"].Value)+" - "+ Convert.ToString(Dgv_Listado_fa.CurrentRow.Cells["descripcion_fa"].Value);
        }
        private void Estado_Limpiar(bool Lestado)
        {
            Btn_cancelar.Visible = Lestado;
            Btn_guardar.Visible = Lestado;
            Btn_retornar.Visible = !Lestado;

            Txt_buscar.Clear();            
            Txt_descripcion_sf.Clear();
            Txt_descripcion_sf.ReadOnly = !Lestado;
            Pnl_listado_fa.Visible = false;
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

        private void Frm_SubFamilias_Load(object sender, EventArgs e)
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
                if (Txt_descripcion_sf.Text == string.Empty ||
                    Txt_descripcion_fa.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    E_SubFamilias Esf = new E_SubFamilias();
                    string Cduplica, Rpta = "";
                    Esf.Codigo_sf= Codigo_sf;
                    Esf.Codigo_fa = Codigo_fa;
                    Esf.Descripcion_sf = Txt_descripcion_sf.Text.Trim();
                    Esf.Estado = true;
                    // Verificamos si la información que se intenta guardar ya existe en la tabla
                    Cduplica = N_SubFamilias.Verifica_duplicado_sf(this.EstadoGuarda, Esf.Codigo_fa, Esf.Descripcion_sf);
                    if (Cduplica == "")
                    {
                        Rpta = N_SubFamilias.Guardar_sf(this.EstadoGuarda, Esf);
                        if (Rpta.Equals("OK"))
                        {
                            MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Estado_Limpiar(false);
                            Codigo_sf = 0;
                            this.EstadoGuarda = 0;
                            this.Mostrar("%");
                            Tbp_general.SelectedIndex = 0;
                            this.Estado_BotonesPrincipales(true);
                        }
                        else
                        {
                            MessageBox.Show(Rpta,"Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Codigo_sf = 0;
            Tbp_general.SelectedIndex = 1;
            Txt_descripcion_sf.Select();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Estado_Limpiar(false);
            this.EstadoGuarda = 0;
            Codigo_sf = 0;
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
                Txt_descripcion_sf.Select();
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
            if (e.ColumnIndex==Dgv_Listado.Columns["Seleccionar"].Index)
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
                if (Opcion== DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in Dgv_Listado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = N_SubFamilias.Eliminar_sf(Codigo);
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
            if (Dgv_Listado.Rows.Count>0)
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
            Reportes.Frm_Rpt_SubFamilias ORpt_sf = new Reportes.Frm_Rpt_SubFamilias();
            ORpt_sf.Txt_p1.Text = Txt_buscar.Text;
            ORpt_sf.ShowDialog();
        }

        private void btn_lupa_Click(object sender, EventArgs e)
        {
            Pnl_listado_fa.Visible = true;
            Txt_buscar_fa.Select();
            this.Listar_fa(Txt_buscar_fa.Text);
        }

        private void Btn_retornar_ca_Click(object sender, EventArgs e)
        {
            Pnl_listado_fa.Visible = false;
        }

        private void Btn_buscar_ca_Click(object sender, EventArgs e)
        {
            this.Listar_fa(Txt_buscar_fa.Text);
        }

        private void Dgv_Listado_ca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_fa();
            Pnl_listado_fa.Visible = false;
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
