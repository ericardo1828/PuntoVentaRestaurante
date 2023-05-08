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
    public partial class Frm_Cierre_Turnos : Form
    {
        public Frm_Cierre_Turnos()
        {
            InitializeComponent();
        }

        #region "Mis Métodos"
        private void Formato_pv()
        {
            Dgv_Listado_pv.Columns[0].Width = 100;
            Dgv_Listado_pv.Columns[0].HeaderText = "CÓDIGO PV";
            Dgv_Listado_pv.Columns[1].Width = 300;
            Dgv_Listado_pv.Columns[1].HeaderText = "PUNTO VENTA";
        }

        private void Listar_pv()
        {
            try
            {
                Dgv_Listado_pv.DataSource = N_Cierre_Turnos.Listar_PV_CierreTurno();
                this.Formato_pv();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_pv()
        {
            int Ncodigo_pv;
            Ncodigo_pv = Convert.ToInt32(Dgv_Listado_pv.CurrentRow.Cells["codigo_pv"].Value);
            this.Estado_fechaturno_pv2(Ncodigo_pv);
          
        }

        private void Estado_fechaturno_pv2(int Xcodigo_pv)
        {
            DataTable Tablax = new DataTable();
            Tablax = N_Cierre_Turnos.Estado_turno_pv2(Xcodigo_pv);
            if (Tablax.Rows.Count > 0)
            {
                string Cfecha_ct = Convert.ToString(Tablax.Rows[0][0]);
                Lbl_fecha_ct.Text = Cfecha_ct.Substring(0, Cfecha_ct.Length - 8);
                Lbl_codigo_tu.Text = Convert.ToString(Tablax.Rows[0][1]);
                Lbl_descripcion_tu.Text = Convert.ToString(Tablax.Rows[0][2]);
                Lbl_estado_tu.Text = Convert.ToString(Tablax.Rows[0][3]);
                Lbl_estado_pv.Text = Convert.ToString(Tablax.Rows[0][4]);
                Lbl_codigo_pv.Text= Convert.ToString(Tablax.Rows[0][5]);
                Lbl_descripcion_pv.Text= Convert.ToString(Tablax.Rows[0][6]);
                               
                if (Lbl_estado_tu.Text== "True")
                {
                    Btn_abrir_turno.Enabled = false;
                    Btn_cerrar_turno.Enabled = true;
                }
                else
                {
                    Btn_abrir_turno.Enabled = true;
                    Btn_cerrar_turno.Enabled = false;
                }
            }
            else
            {
                Btn_abrir_turno.Enabled = true;
                Btn_cerrar_turno.Enabled = false;

                Lbl_fecha_ct.Text = "";
                Lbl_codigo_tu.Text = "0";
                Lbl_descripcion_tu.Text = "";
                Lbl_estado_tu.Text = "0";
                Lbl_estado_pv.Text = "";
                Lbl_codigo_pv.Text =Convert.ToString(Xcodigo_pv);
                Lbl_descripcion_pv.Text = "";
            }

        }
        #endregion
        private void Frm_Cierre_Turnos_Load(object sender, EventArgs e)
        {
            this.Listar_pv();
            Lbl_fecha_ct.Text = "";
            Lbl_codigo_tu.Text = "";
            Lbl_descripcion_tu.Text = "";
            Lbl_estado_tu.Text = "";
            Lbl_estado_pv.Text = "";
            Lbl_codigo_pv.Text = "";
            Lbl_descripcion_pv.Text = "";
        }

        private void Dgv_Listado_pv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_pv();
        }

        private void Btn_cerrar_turno_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Cerrar el turno ahora?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Rpta;
                    string Cfecha_ct = Lbl_fecha_ct.Text;
                    int Ncodigo_pv =Convert.ToInt32(Lbl_codigo_pv.Text);
                    int Ncodigo_tu = Convert.ToInt32(Lbl_codigo_tu.Text);
                    Rpta = N_Cierre_Turnos.Cerrar_turno(Cfecha_ct, Ncodigo_pv, Ncodigo_tu);
                    if (Rpta.Equals("OK"))
                    {
                        this.Estado_fechaturno_pv2(Ncodigo_pv);
                        MessageBox.Show("El turno ha sido cerrado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_abrir_turno_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Abrir turno siguiente ahora?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Rpta;
                   
                    int Ncodigo_pv = Convert.ToInt32(Lbl_codigo_pv.Text);
                    string Cfecha_ct = Lbl_fecha_ct.Text;
                    int Ncodigo_tu = Convert.ToInt32(Lbl_codigo_tu.Text);

                    if (Cfecha_ct == string.Empty) // asigno fecha de hoy y turno 1 en el caso no tengamos historial de cierre del PV.
                    {
                        Cfecha_ct = DateTime.Now.ToString("dd-MM-yyyy");
                        Ncodigo_tu = 1;
                    }
                    else
                    {
                        if (Ncodigo_tu == 1)
                        {
                            Ncodigo_tu = 2;
                        }
                        else if (Ncodigo_tu == 2)
                        {
                            DateTime Nueva_fecha = Convert.ToDateTime(Cfecha_ct);
                            Nueva_fecha = Nueva_fecha.AddDays(1);
                            Cfecha_ct = Convert.ToString(Nueva_fecha);
                            Cfecha_ct.Substring(0, Cfecha_ct.Length - 8);
                            Ncodigo_tu = 1;
                        }
                    }

                   
                    
                    Rpta = N_Cierre_Turnos.Abrir_turno(Cfecha_ct, Ncodigo_pv, Ncodigo_tu);
                    if (Rpta.Equals("OK"))
                    {
                        this.Estado_fechaturno_pv2(Ncodigo_pv);
                        MessageBox.Show("El turno ha sido aperturado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
