using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Sol_PuntoVenta.Presentacion;
using Sol_PuntoVenta.Presentacion.Controles;
using Sol_PuntoVenta.Negocio;
using Sol_PuntoVenta.Entidades;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;

namespace Sol_PuntoVenta.Presentacion
{
     public partial class Frm_RegistrarPedidos : Form
    {
        
        #region "Variable y Propiedades"

        private int Codigo_me;
        private string Descripcion_me;
        private Image Estado;
        private int Codigo_pv;
        private string Descripcion_pv;
        private string Archivo_txt;
        internal int Codigo_us { get; set; }
        internal int Codigo_tu { get; set; }
        public int Codigo_me1 { get => Codigo_me; set => Codigo_me = value; }
        public string Descripcion_me1 { get => Descripcion_me; set => Descripcion_me = value; }
        public Image Estado1 { get => Estado; set => Estado = value; }
        public int Codigo_pv1 { get => Codigo_pv; set => Codigo_pv = value; }
        public string Descripcion_pv1 { get => Descripcion_pv; set => Descripcion_pv = value; }
        public string Archivo_txt1 { get => Archivo_txt; set => Archivo_txt = value; }
        public int Codigo_us1 { get => Codigo_us; set => Codigo_us = value; }
        public int Codigo_tu1 { get => Codigo_tu; set => Codigo_tu = value; }
        #endregion

        #region "Métodos"       
        private void Formato_pv()
        {            
            Dgv_Listado_pv.Columns[0].Width = 250;
            Dgv_Listado_pv.Columns[0].HeaderText = "PUNTO VENTA";
            Dgv_Listado_pv.Columns[1].Visible = false;
        }

        private void Listar_pv(string Ctexto)
        {
            try
            {
                Dgv_Listado_pv.DataSource = N_AreaDespacho.Listar_pv(Ctexto);
                this.Formato_pv();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_pv()
        {
            Txt_codigo_pv.Text = Convert.ToString(Dgv_Listado_pv.CurrentRow.Cells["codigo_pv"].Value);
            Lbl_descripcion_pv.Text = Convert.ToString(Dgv_Listado_pv.CurrentRow.Cells["descripcion_pv"].Value);
        }
        #endregion
        #region "Método de llenado del Punto de Venta con Mesas"
        public void LLenarPuntoVenta(FlowLayoutPanel Contenedor)
        {
            Contenedor.Controls.Clear();
            
            if (Lbl_estado_tu.Text == "False" || Lbl_estado_tu.Text=="0" ) // el turno del punto de venta se encuentra cerrado
            {
                Lbl_mensaje.Visible = true;
                Lbl_mensaje.Text="El turno del punto de venta se encuentra cerrado, Solicite al Administrador la apertura de una nueva fecha de trabajo y/o Turno";

            }
            else //el Turno del punto de venta se encuentra abierto para registrar pedidos
            {
                Lbl_mensaje.Visible = false;

                Byte[] Bimagen1 = new byte[0];
                Bimagen1 = N_RegistrarPedido.Img_predeterminada(1); // Estado Disponible
                MemoryStream ms1 = new MemoryStream(Bimagen1);

                Byte[] Bimagen2 = new byte[0];
                Bimagen2 = N_RegistrarPedido.Img_predeterminada(2); // Estado No Disponible
                MemoryStream ms2 = new MemoryStream(Bimagen2);

                DataTable Tabla = new DataTable();
                Tabla = N_RegistrarPedido.Mostrar_rp(Convert.ToInt32(Txt_codigo_pv.Text));
                for (int Nfila = 0; Nfila <= Tabla.Rows.Count - 1; Nfila++)
                {
                    Codigo_me = Convert.ToInt32(Tabla.Rows[Nfila][0]);
                    Descripcion_me = Convert.ToString(Tabla.Rows[Nfila][1]);

                    //verificamos si la mesa está disponible
                    if (Convert.ToInt32(Tabla.Rows[Nfila][2]) == 1) // Disponible
                    {
                        Estado = Image.FromStream(ms1);
                    }
                    else
                    {
                        Estado = Image.FromStream(ms2);
                    }
                    Codigo_pv = Convert.ToInt32(Tabla.Rows[Nfila][3]);
                    Descripcion_pv = Convert.ToString(Tabla.Rows[Nfila][4]);                    
                    //Creamos la Mesa para cargar los datos
                    MiMesa Omesa = new MiMesa();
                    Omesa.Codigo = Codigo_me;
                    Omesa.Descripcion = Descripcion_me;
                    Omesa.Disponible = Estado;
                    Omesa.Codigo_pv = Codigo_pv;
                    Omesa.Descripcion_pv = Descripcion_pv;
                    Omesa.Codigo_us = Codigo_us;
                    Omesa.Codigo_tu = Codigo_tu;
                    //Añadimos la mesa al Control
                    Contenedor.Controls.Add(Omesa);
                }
            
            }
        }
        #endregion
        #region "Método para saber la fecha y turno del punto de venta en que estado se encuentra"
        private void Estado_fechaturno_pv(int Xcodigo_pv)
        {
            DataTable Tablax = new DataTable();
            Tablax = N_RegistrarPedido.Estado_turno_pv(Xcodigo_pv);
            if (Tablax.Rows.Count > 0)
            {
                string Cfecha_ct = Convert.ToString(Tablax.Rows[0][0]);
                Lbl_fecha_ct.Text = Cfecha_ct.Substring(0, Cfecha_ct.Length - 8);                
                Codigo_tu= Convert.ToInt32(Tablax.Rows[0][1]);
                Lbl_descripcion_tu.Text= Convert.ToString(Tablax.Rows[0][2]);
                Lbl_estado_tu.Text= Convert.ToString(Tablax.Rows[0][3]);
                Lbl_estado_pv.Text= Convert.ToString(Tablax.Rows[0][4]);
            }
            else
            {
                Lbl_fecha_ct.Text = "Ninguno";
                Codigo_tu = 0;
                Lbl_descripcion_tu.Text = "Ninguno";
                Lbl_estado_tu.Text = "0";
                Lbl_estado_pv.Text = "Ninguno";
            }
           
        }
                #endregion
        public Frm_RegistrarPedidos()
        {
            InitializeComponent();
        }

        private void Frm_RegistrarPedidos_Load(object sender, EventArgs e) {

        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            this.Close();
        }

        private void Btn_retornar_pv_Click(object sender, EventArgs e)
        {
            Pnl_listado_pv.Visible = false;
        }

        private void btn_lupa_Click(object sender, EventArgs e)
        {
            Pnl_listado_pv.Visible = true;
            this.Listar_pv("%");
        }

        private void Dgv_Listado_pv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_pv();
            this.Estado_fechaturno_pv(Convert.ToInt32(Txt_codigo_pv.Text));
            Pnl_listado_pv.Visible = false;
            this.LLenarPuntoVenta(flowLayoutPanel1);            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Estado_fechaturno_pv(Convert.ToInt32(Txt_codigo_pv.Text));           
            this.LLenarPuntoVenta(flowLayoutPanel1);
        }
    }    
}
