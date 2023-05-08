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
    public partial class Frm_Usuarios : Form
    {
        public Frm_Usuarios()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        internal int iCodigo_us { get; set; }
        internal int iCodigo_ru { get; set; }

        int Codigo_us = 0;
        int Codigo_cr = 0;
        int Codigo_ru = 0;
        int EstadoGuarda = 0;
        #endregion

        #region "Mis Métodos"
        private void Formato_us()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].Visible = false;
            Dgv_Listado.Columns[1].Width = 100;
            Dgv_Listado.Columns[1].HeaderText = "CÓDIGO US";
            Dgv_Listado.Columns[2].Width = 180;
            Dgv_Listado.Columns[2].HeaderText = "EMAIL / USUARIO";
            Dgv_Listado.Columns[3].Width = 190;
            Dgv_Listado.Columns[3].HeaderText = "ROL DE USUARIO";
            Dgv_Listado.Columns[4].Width = 250;
            Dgv_Listado.Columns[4].HeaderText = "NOMBRES";
            Dgv_Listado.Columns[5].Width = 250;
            Dgv_Listado.Columns[5].HeaderText = "CARGO / ÁREA";           
            Dgv_Listado.Columns[6].Visible = false;
            Dgv_Listado.Columns[7].Visible = false;
        }

        private void Listado_us(string cTexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Usuarios.Listado_us(cTexto);
                this.Formato_us();
                Lbl_total.Text = "Total registros: " + Convert.ToString(Dgv_Listado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_us"].Value)))
            {
                MessageBox.Show("Seleccione un registro ", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Codigo_us = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_us"].Value);
                Txt_Email_us.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["email_us"].Value);
                Txt_Password_us.Text = "";
                Txt_Nombres_us.Text= Convert.ToString(Dgv_Listado.CurrentRow.Cells["nombres_us"].Value);
                Cmb_Cargos.Text= Convert.ToString(Dgv_Listado.CurrentRow.Cells["cargo_area"].Value);
                Codigo_cr= Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_cr"].Value);
                Cmb_RolUsuarios.Text= Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_ru"].Value);
                Codigo_ru= Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_ru"].Value);
            }
        }



        private void Cargar_Cargos()
        {
            try
            {
                Cmb_Cargos.DataSource = N_Usuarios.Cargar_Cargos();
                Cmb_Cargos.ValueMember = "codigo_cr";
                Cmb_Cargos.DisplayMember = "cargo_area";                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Cargar_RolesUsuarios()
        {
            try
            {
                Cmb_RolUsuarios.DataSource = N_Usuarios.Cargar_RolesUsuarios();
                Cmb_RolUsuarios.ValueMember = "codigo_ru";
                Cmb_RolUsuarios.DisplayMember = "descripcion_ru";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Estado_Limpiar(bool Lestado)
        {
            Btn_cancelar.Visible = Lestado;
            Btn_guardar.Visible = Lestado;
            Btn_retornar.Visible = !Lestado;

            Txt_buscar.Clear();
            Txt_Email_us.Clear();
            Txt_Password_us.Clear();
            Txt_Nombres_us.Clear();
            Cmb_Cargos.Text = "";
            Cmb_RolUsuarios.Text = "";
            Txt_Email_us.ReadOnly = !Lestado;   
            Txt_Password_us.ReadOnly = !Lestado;
            Txt_Nombres_us.ReadOnly=!Lestado;
            Cmb_Cargos.Enabled = Lestado;
            Cmb_RolUsuarios.Enabled = Lestado;
        }

        private void Estado_BotonesPrincipales(bool Lestado)
        {
            Btn_nuevo.Enabled = Lestado;
            Btn_actualizar.Enabled = Lestado;
            Btn_eliminar.Enabled = Lestado;
            Btn_reporte.Enabled = Lestado;
            Btn_salir.Enabled = Lestado;
          

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

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            this.Cargar_Cargos();
            this.Cargar_RolesUsuarios();
            this.Listado_us("%");
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_us(Txt_buscar.Text);
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Email_us.Text == string.Empty ||
                    Txt_Nombres_us.Text == string.Empty ||
                    Cmb_Cargos.Text==string.Empty ||
                    Cmb_RolUsuarios.Text==string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    E_Usuarios eUs = new E_Usuarios();
                    string Cduplica, Rpta = "";
                    eUs.Codigo_us = Codigo_us;
                    eUs.Email_us = Txt_Email_us.Text;
                    eUs.Password_us = Txt_Password_us.Text;
                    eUs.Nombres_us = Txt_Nombres_us.Text;
                    eUs.Codigo_cr = Convert.ToInt32(Cmb_Cargos.SelectedValue);
                    eUs.Codigo_ru = Convert.ToInt32(Cmb_RolUsuarios.SelectedValue);
                   
                    // Verificamos si la información que se intenta guardar ya existe en la tabla
                    Cduplica = N_Usuarios.Verifica_duplicado_us(this.EstadoGuarda, eUs.Codigo_us, eUs.Email_us);
                    if (Cduplica == "")
                    {
                        Rpta = N_Usuarios.Guardar_us(this.EstadoGuarda, eUs);
                        if (Rpta.Equals("OK"))
                        {
                            MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Estado_Limpiar(false);
                            Codigo_us = 0;
                            this.EstadoGuarda = 0;
                            this.Listado_us("%");
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
            Codigo_us = 0;
            Codigo_cr = 0;
            Codigo_ru = 0;
            Tbp_general.SelectedIndex = 1;
            Txt_Email_us.Select();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Estado_Limpiar(false);
            Codigo_us = 0;
            Codigo_cr = 0;
            Codigo_ru = 0;
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
                Txt_Email_us.Select();
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
                            Rpta = N_Usuarios.Eliminar_us(Codigo);
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
                    this.Listado_us("%");
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
            Configuraciones.Reportes.Frm_Rpt_Usuarios ORpt_us = new Configuraciones.Reportes.Frm_Rpt_Usuarios();
            ORpt_us.Txt_p1.Text = Txt_buscar.Text;
            ORpt_us.ShowDialog();
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
