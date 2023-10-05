using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Sol_PuntoVenta.Entidades;
using Sol_PuntoVenta.Negocio;
using Sol_PuntoVenta.Presentacion.Controles;

namespace Sol_PuntoVenta.Presentacion.Controles
{
    public partial class Frm_MesaAbierta : Form
    {
        #region "Variables y Propiedades"
        int EstadoPrecuenta = 0;
        DataTable TablaDetalle = new DataTable(); // esta tabla es para el detalle del pedido
        DataTable TablaTicket = new DataTable(); // esta tabla es para los ticket seleccionado y que se procesará para precuenta
        DataTable Tabla_Division = new DataTable(); //esta tabla es para la division de cuentas de los tickets seleccionados
        DataTable Tabla_detalle_boleta = new DataTable(); //esta tabla es para el detalle de la boleta
        DataTable Tabla_detalle_factura = new DataTable(); //esta tabla es para el detalle de la boleta
        private int _Codigo_pr1;
        private string _Descripcion_pr1;
        private string _Preciounitario_pr1;
        private string _Impresora1;
        private Image _Imagen_pr1;
        private string _Archivo_txt1;       

        public int Codigo_pr1 { get => _Codigo_pr1; set => _Codigo_pr1 = value; }
        public string Descripcion_pr1 { get => _Descripcion_pr1; set => _Descripcion_pr1 = value; }
        public string Preciounitario_pr1 { get => _Preciounitario_pr1; set => _Preciounitario_pr1 = value; }
        public string Impresora1 { get => _Impresora1; set => _Impresora1 = value; }
        public Image Imagen_pr1 { get => _Imagen_pr1; set => _Imagen_pr1 = value; }
        public string Archivo_txt1 { get => _Archivo_txt1; set => _Archivo_txt1 = value; }


        //Variable especial para la impresión de comandas(Solo se utiliza para el botón generar comanda)
        private int X1codigo_ti;
        private string X1impresora;
        private string X1descripcion_pv;
        private string X1fecha_emision;
        private string X1descripcion_tu;
        private string X1nombres_us;
        private string X1descripcion_ca;
        private string X1descripcion_me;
        private string X1cliente;
        private string X1nrodocumento_cl;
        private string X1obsanulado_ti;

        //
        public int X1codigo_ti1 { get => X1codigo_ti; set => X1codigo_ti = value; }
        public string X1impresora1 { get => X1impresora; set => X1impresora = value; }
        public string X1descripcion_pv1 { get => X1descripcion_pv; set => X1descripcion_pv = value; }
        public string X1fecha_emision1 { get => X1fecha_emision; set => X1fecha_emision = value; }
        public string X1descripcion_tu1 { get => X1descripcion_tu; set => X1descripcion_tu = value; }
        public string X1nombres_us1 { get => X1nombres_us; set => X1nombres_us = value; }
        public string X1descripcion_ca1 { get => X1descripcion_ca; set => X1descripcion_ca = value; }
        public string X1descripcion_me1 { get => X1descripcion_me; set => X1descripcion_me = value; }
        public string X1cliente1 { get => X1cliente; set => X1cliente = value; }
        public string X1nrodocumento_cl1 { get => X1nrodocumento_cl; set => X1nrodocumento_cl = value; }
        public string X1obsanulado_ti1 { get => X1obsanulado_ti; set => X1obsanulado_ti = value; }

        #endregion

        #region "Tabla para el detalle de la boleta"
        private void Crear_TablaDetalleBoleta()
        {
            this.Tabla_detalle_boleta = new DataTable("tabla_detalle_boleta");

            this.Tabla_detalle_boleta.Columns.Add("Codigo_pr", System.Type.GetType("System.Int32"));
            this.Tabla_detalle_boleta.Columns.Add("Preciounitario_pr", System.Type.GetType("System.String"));
            this.Tabla_detalle_boleta.Columns.Add("Cantidad_bo", System.Type.GetType("System.String"));
            this.Tabla_detalle_boleta.Columns.Add("Total_bo", System.Type.GetType("System.String"));           
            this.Tabla_detalle_boleta.Columns.Add("Codigo_ti", System.Type.GetType("System.Int32"));            
        }
        private void Crear_TablaDetalleFactura()
        {
            this.Tabla_detalle_boleta = new DataTable("tabla_detalle_boleta");

            this.Tabla_detalle_factura.Columns.Add("Codigo_pr", System.Type.GetType("System.Int32"));
            this.Tabla_detalle_factura.Columns.Add("Preciounitario_pr", System.Type.GetType("System.String"));
            this.Tabla_detalle_factura.Columns.Add("Cantidad_fa", System.Type.GetType("System.String"));
            this.Tabla_detalle_factura.Columns.Add("Total_fa", System.Type.GetType("System.String"));
            this.Tabla_detalle_factura.Columns.Add("Codigo_ti", System.Type.GetType("System.Int32"));
        }
        #endregion

        #region "Tabla para DiVision de cuenta para enviarse a la base de datos"
        private void Crear_TablaDvision()
        {
            this.Tabla_Division = new DataTable("Tabla_Division");
            this.Tabla_Division.Columns.Add("Cuentas", System.Type.GetType("System.String"));
            this.Tabla_Division.Columns.Add("Descripcion_pr", System.Type.GetType("System.String"));
            this.Tabla_Division.Columns.Add("Preciounitario_ti", System.Type.GetType("System.String"));
            this.Tabla_Division.Columns.Add("Cantidad_ti", System.Type.GetType("System.String"));
            this.Tabla_Division.Columns.Add("Total_ti", System.Type.GetType("System.String"));
            this.Tabla_Division.Columns.Add("Observacion", System.Type.GetType("System.String"));
            this.Tabla_Division.Columns.Add("Codigo_ti", System.Type.GetType("System.Int32"));
            this.Tabla_Division.Columns.Add("Codigo_pr", System.Type.GetType("System.Int32"));
            this.Tabla_Division.Columns.Add("Impresora", System.Type.GetType("System.String"));
        }
        #endregion

            #region "Tabla detalle de pedido"
            private void Crear_TablaDetalle()
        {
            this.TablaDetalle = new DataTable("TablaDetalle");
            this.TablaDetalle.Columns.Add("Descripcion_pr", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Preciounitario_pr", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Cantidad", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Total", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Obs", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Codigo_pr", System.Type.GetType("System.Int32"));
            this.TablaDetalle.Columns.Add("Impresora", System.Type.GetType("System.String"));

            Dgv_Detalle.DataSource = this.TablaDetalle;

            Dgv_Detalle.Columns[0].Width = 210;
            Dgv_Detalle.Columns[0].HeaderText = "PRODUCTO";
            Dgv_Detalle.Columns[1].Width = 75;
            Dgv_Detalle.Columns[1].HeaderText = "P.UNIT.";
            Dgv_Detalle.Columns[2].Width = 75;
            Dgv_Detalle.Columns[2].HeaderText = "CANTIDAD";
            Dgv_Detalle.Columns[3].Width = 75;
            Dgv_Detalle.Columns[3].HeaderText = "TOTAL S/.";
            Dgv_Detalle.Columns[4].Width = 40;
            Dgv_Detalle.Columns[4].HeaderText = "OBS.";
            Dgv_Detalle.Columns[5].Visible = false;
            Dgv_Detalle.Columns[6].Visible = false;          
        }

        private void Agregar_Item(string Cdescripcion_pr,
                                  string Cpreciounitario_pr,
                                  string Ccantidad,
                                  string Ctotal,
                                  string Cobs,
                                  int Ncodigo_pr,
                                  string Cimpresora)
        {
            DataRow Fila = TablaDetalle.NewRow();
            Fila["Descripcion_pr"] = Cdescripcion_pr.Trim();
            Fila["Preciounitario_pr"] = Cpreciounitario_pr.Trim();
            Fila["Cantidad"] = Ccantidad;
            Fila["Total"] = Ctotal.Trim();
            Fila["Obs"] = Cobs.Trim();
            Fila["Codigo_pr"] = Ncodigo_pr;
            Fila["Impresora"] = Cimpresora.Trim();
            this.TablaDetalle.Rows.Add(Fila);
        }

        #endregion

        #region "Método de llenado del Punto de Venta con Mesas"
        public void LLenarListadoProducto(FlowLayoutPanel Contenedor)
        {
            Contenedor.Controls.Clear();
            int Ncodigo_pv, Ncodigo_sf;
            Byte[] Bimagen = new byte[0];

            Archivo_txt1 = Lbl_archivo_txt.Text.Trim(); //cargamos el nombre de fichero txt que usaremos
            Ncodigo_pv = Convert.ToInt32(Lbl_codigo_pv.Text.Trim());
            Ncodigo_sf = Convert.ToInt32(Dgv_Listado_pr.CurrentRow.Cells["codigo_sf"].Value);
            DataTable Tabla1 = new DataTable();
            Tabla1 = N_RegistrarPedido.ListarProductos_SubFamilias(Ncodigo_pv, Ncodigo_sf);
            if (Tabla1.Rows.Count > 0)
            {
                for (int Nfila = 0; Nfila <= Tabla1.Rows.Count - 1; Nfila++)
                {
                    Codigo_pr1 = Convert.ToInt32(Tabla1.Rows[Nfila][0]);
                    Descripcion_pr1 = Convert.ToString(Tabla1.Rows[Nfila][1]);
                    Preciounitario_pr1 = Convert.ToString(Tabla1.Rows[Nfila][2]);

                    Bimagen = (byte[])Tabla1.Rows[Nfila][3];
                    MemoryStream ms = new MemoryStream(Bimagen);
                    Imagen_pr1 = Image.FromStream(ms);

                    Impresora1 = Convert.ToString(Tabla1.Rows[Nfila][4]);


                    //Creamos el producto para cargar en el Layout
                    MiProducto Oproducto = new MiProducto();
                    Oproducto.Codigo_pr = Codigo_pr1;
                    Oproducto.Descripcion_pr = Descripcion_pr1;
                    Oproducto.Preciounitario_pr = Preciounitario_pr1;
                    Oproducto.Imagen_pr = Imagen_pr1;
                    Oproducto.Impresora = Impresora1.Trim();
                    Oproducto.Archivo_txt = Archivo_txt1;
                    //Añadimos el producto al Control
                    Contenedor.Controls.Add(Oproducto);
                }
            }

        }
        #endregion

        #region "Método para Listar Clientes"
        private void Formato_cl()
        {
            Dgv_Listado_cl.Columns[0].Width = 310;
            Dgv_Listado_cl.Columns[0].HeaderText = "CLIENTE";
            Dgv_Listado_cl.Columns[1].Width = 120;
            Dgv_Listado_cl.Columns[1].HeaderText = "NRO. DOC.";
            Dgv_Listado_cl.Columns[2].Visible = false;
        }

        private void Listar_cl(string Ctexto)
        {
            try
            {
                Dgv_Listado_cl.DataSource = N_RegistrarPedido.Listar_cl(Ctexto);
                this.Formato_cl();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_cl()
        {
            Txt_codigo_cl.Text = Convert.ToString(Dgv_Listado_cl.CurrentRow.Cells["codigo_cl"].Value);
            Txt_cliente.Text = Convert.ToString(Dgv_Listado_cl.CurrentRow.Cells["cliente"].Value);
            Txt_nrodocumento_cl.Text= Convert.ToString(Dgv_Listado_cl.CurrentRow.Cells["nrodocumento_cl"].Value);
        }
        #endregion

        #region "Método para busqueda rápida de productos"
        private void Formato_busqueda_pr()
        {
            Dgv_Listado_Busqueda_pr.Columns[0].Width = 250;
            Dgv_Listado_Busqueda_pr.Columns[0].HeaderText = "PRODUCTO";
            Dgv_Listado_Busqueda_pr.Columns[1].Width = 60;
            Dgv_Listado_Busqueda_pr.Columns[1].HeaderText = "P.UNIT.";
            Dgv_Listado_Busqueda_pr.Columns[2].Width = 250;
            Dgv_Listado_Busqueda_pr.Columns[2].HeaderText = "SUFAMILIA";
            Dgv_Listado_Busqueda_pr.Columns[3].Visible = false;
        }

        private void Listar_busqueda_pr(string Ctexto)
        {
            try
            {
                Dgv_Listado_Busqueda_pr.DataSource = N_RegistrarPedido.Listar_busqueda_pr(Ctexto);
                this.Formato_busqueda_pr();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_busqueda_pr()
        {
            string Bdescripcion_pr;
            string Bpreciounitario_pr;
            int Bcodigo_pr;
            string Bimpresora;

            Bdescripcion_pr = Convert.ToString(Dgv_Listado_Busqueda_pr.CurrentRow.Cells["descripcion_pr"].Value);
            Bpreciounitario_pr= Convert.ToString(Dgv_Listado_Busqueda_pr.CurrentRow.Cells["preciounitario_pr"].Value);
            Bcodigo_pr= Convert.ToInt32(Dgv_Listado_Busqueda_pr.CurrentRow.Cells["codigo_pr"].Value);
            Bimpresora = Convert.ToString(Dgv_Listado_Busqueda_pr.CurrentRow.Cells["impresora"].Value);
            
            this.Agregar_Item(Bdescripcion_pr,
                              Bpreciounitario_pr,
                              " 1.00",
                              Bpreciounitario_pr,
                              "",
                              Bcodigo_pr,
                              Bimpresora);

            TablaDetalle.AcceptChanges();
            const int columna = 3;

            decimal suma = 0;
            foreach (DataGridViewRow row in Dgv_Detalle.Rows)
            {
                suma += Convert.ToDecimal(row.Cells[columna].Value);
            }
            Lbl_total.Text = Convert.ToString(suma);            
        }
        #endregion

        #region "Método para Listar Clientes Boleta y Factura"
        private void Formato_cl_bo_fa()
        {
            Dgv_listado_cl_bo_fa.Columns[0].Width = 310;
            Dgv_listado_cl_bo_fa.Columns[0].HeaderText = "CLIENTE";
            Dgv_listado_cl_bo_fa.Columns[1].Width = 120;
            Dgv_listado_cl_bo_fa.Columns[1].HeaderText = "NRO. DOC.";
            Dgv_listado_cl_bo_fa.Columns[2].Visible = false;
            Dgv_listado_cl_bo_fa.Columns[3].Visible = false;
        }

        private void Listar_cl_bo_fa(string Ctexto)
        {
            try
            {
                Dgv_listado_cl_bo_fa.DataSource = N_RegistrarPedido.Listar_cl_bo_fa(Ctexto);
                this.Formato_cl_bo_fa();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_cl_bo_fa()
        {
            Txt_codigo_cl_bo_fa.Text = Convert.ToString(Dgv_listado_cl_bo_fa.CurrentRow.Cells["codigo_cl"].Value);
            Txt_cliente_bo_fa.Text = Convert.ToString(Dgv_listado_cl_bo_fa.CurrentRow.Cells["cliente"].Value);
            Txt_nrodocumento_bo_fa.Text = Convert.ToString(Dgv_listado_cl_bo_fa.CurrentRow.Cells["nrodocumento_cl"].Value);
            Txt_direccion_bo_fa.Text = Convert.ToString(Dgv_listado_cl_bo_fa.CurrentRow.Cells["direccion_cl"].Value);
            Txt_correlativo_bo_fa.Select();
        }
        #endregion

        #region "Método para cargar los tickets activos de la mesa seleccionada"
        private void Formato()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].Visible = false;
            Dgv_Listado.Columns[0].ReadOnly = true;
            Dgv_Listado.Columns[1].Width = 100;
            Dgv_Listado.Columns[1].ReadOnly = true;
            Dgv_Listado.Columns[1].HeaderText = "CÓDIGO TI";
            Dgv_Listado.Columns[2].Width = 240;
            Dgv_Listado.Columns[2].ReadOnly = true;
            Dgv_Listado.Columns[2].HeaderText = "CLIENTE";
            Dgv_Listado.Columns[3].Width = 120;
            Dgv_Listado.Columns[3].ReadOnly = true;
            Dgv_Listado.Columns[3].HeaderText = "FECHA EMISION";
            Dgv_Listado.Columns[4].Width = 120;
            Dgv_Listado.Columns[4].ReadOnly = true;
            Dgv_Listado.Columns[4].HeaderText = "TOTAL S/.";
            Dgv_Listado.Columns[5].Visible = false;
            Dgv_Listado.Columns[6].Visible = false;
        }

        private void Mostrar_tickets_mesa(int Ncodigo_me)
        {
            try
            {
                Dgv_Listado.DataSource = N_RegistrarPedido.Mostrar_tickets_mesa(Ncodigo_me);
                this.Formato();
                Lbl_total_general.Text= "Total Nro. Tickets x mesa: " + Convert.ToString(Dgv_Listado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato_ti()
        {
            Dgv_detalle_ticket.Columns[0].Width = 100;
            Dgv_detalle_ticket.Columns[0].Visible = false;
            Dgv_detalle_ticket.Columns[0].ReadOnly = true;
            Dgv_detalle_ticket.Columns[1].Width = 210;
            Dgv_detalle_ticket.Columns[1].ReadOnly = true;
            Dgv_detalle_ticket.Columns[1].HeaderText = "PRODUCTO";
            Dgv_detalle_ticket.Columns[2].Width = 75;
            Dgv_detalle_ticket.Columns[2].ReadOnly = true;
            Dgv_detalle_ticket.Columns[2].HeaderText = "P.UNIT.";
            Dgv_detalle_ticket.Columns[3].Width = 75;
            Dgv_detalle_ticket.Columns[3].ReadOnly = true;
            Dgv_detalle_ticket.Columns[3].HeaderText = "CANTIDAD";
            Dgv_detalle_ticket.Columns[4].Width = 75;
            Dgv_detalle_ticket.Columns[4].ReadOnly = true;
            Dgv_detalle_ticket.Columns[4].HeaderText = "TOTAL";
            Dgv_detalle_ticket.Columns[5].Width = 40;
            Dgv_detalle_ticket.Columns[5].ReadOnly = true;
            Dgv_detalle_ticket.Columns[5].HeaderText = "OBS";
            Dgv_detalle_ticket.Columns[6].Visible = false;
            Dgv_detalle_ticket.Columns[7].Visible = false;
            Dgv_detalle_ticket.Columns[8].Visible = false;

        }

        private void Formato_ti_boleta()
        {           
            Dgv_detalle_bo_fa.Columns[0].Width = 320;
            Dgv_detalle_bo_fa.Columns[0].ReadOnly = true;
            Dgv_detalle_bo_fa.Columns[0].HeaderText = "PRODUCTO";
            Dgv_detalle_bo_fa.Columns[1].Width = 75;
            Dgv_detalle_bo_fa.Columns[1].ReadOnly = true;
            Dgv_detalle_bo_fa.Columns[1].HeaderText = "P.UNIT.";
            Dgv_detalle_bo_fa.Columns[2].Width = 75;
            Dgv_detalle_bo_fa.Columns[2].ReadOnly = true;
            Dgv_detalle_bo_fa.Columns[2].HeaderText = "CANTIDAD";
            Dgv_detalle_bo_fa.Columns[3].Width = 75;
            Dgv_detalle_bo_fa.Columns[3].ReadOnly = true;
            Dgv_detalle_bo_fa.Columns[3].HeaderText = "TOTAL";
            Dgv_detalle_bo_fa.Columns[4].Width = 40;         
            Dgv_detalle_bo_fa.Columns[4].Visible = false;
            Dgv_detalle_bo_fa.Columns[5].Visible = false;
            Dgv_detalle_bo_fa.Columns[6].Visible = false;
            Dgv_detalle_bo_fa.Columns[7].Visible = false;

        }
        private void Selecciona_dgv()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_ti"].Value)))
            {
                MessageBox.Show("Seleccione un registro ", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Lbl_titulo_detalle_ticket.Text = "::: Detalle de ticket seleccionado :::";
                Pnl_detalle_ticket.Visible = true;
                int Xcodigo_ti = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_ti"].Value);
                Lbl_codigo_ti.Text =Convert.ToString(Xcodigo_ti);
                Lbl_tickets_seleccionados.Text ="Ticket # "+ Lbl_codigo_ti.Text;
                Txt_cliente_detalle_ticket.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["Cliente"].Value);
                Txt_nrodocumento_cliente_detalle.Text= Convert.ToString(Dgv_Listado.CurrentRow.Cells["Nrodocumento_cl"].Value);
                Lbl_total_detalle_ticket.Text= Convert.ToString(Dgv_Listado.CurrentRow.Cells["Total_ti"].Value);
                Dgv_detalle_ticket.DataSource = N_RegistrarPedido.Mostrar_ticket(Xcodigo_ti);
                this.Formato_ti();
                Btn_reimprimir_comanda.Visible = true;
                Btn_imprimir_precuenta.Visible = false;
            }
        }

        #endregion
        public Frm_MesaAbierta()
        {
            InitializeComponent();
            
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.Close();
        }

        private void Frm_MesaAbierta_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Btn_busquedarapida, "Busqueda rápida de productos");           
            this.EstadoPrecuenta = 0; //sin acción alguna
            tabControl1.Controls["tabPage1"].Enabled = false;
            tabControl1.Controls["tabPage2"].Enabled = false;           

            this.Crear_TablaDetalle();
            this.Mostrar_tickets_mesa(Convert.ToInt32(Lbl_codigo_me.Text));
            
        }

        private void Dgv_Listado_pr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.LLenarListadoProducto(Flp_listadoproductos); 
            
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text =Lbl_cantidad.Text.Trim()+ "1";
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "2";
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "3";
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "4";
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "5";
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "6";
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "7";
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "8";
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "9";
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = Lbl_cantidad.Text.Trim() + "0";
        }

        private void Btn_c_Click(object sender, EventArgs e)
        {
            Lbl_cantidad.Text = "";
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Txt_cliente.Text="";
            Txt_nrodocumento_cl.Text="";
            Chk_clientemanual.Checked = false;
            Lbl_cantidad.Text = "";
            Lbl_total.Text = "";
            TablaDetalle.Clear();
            TablaDetalle.AcceptChanges();
            tabControl1.Controls["tabPage1"].Enabled = false;
            tabControl1.Controls["tabPage2"].Enabled = false;
        }
                
        private void Btn_nuevopedido_Click(object sender, EventArgs e)
        {
            tabControl1.Controls["tabPage2"].Enabled = false;
            tabControl1.Controls["tabPage1"].Enabled = true; 
            tabControl1.SelectedIndex = 0;
            timer1.Enabled = true;
        }       

        private void Btn_visualizarpedido_Click(object sender, EventArgs e)
        {
            this.Mostrar_tickets_mesa(Convert.ToInt32(Lbl_codigo_me.Text));
            tabControl1.Controls["tabPage2"].Enabled = true;
            tabControl1.Controls["tabPage1"].Enabled = false;
            Btn_anularpedido.Enabled = true;
            Btn_emitirdocumento.Enabled = true;
            Btn_dividir_cuenta.Enabled = true;
            Btn_boleta.Enabled = true;
            Btn_factura.Enabled = true;
            tabControl1.SelectedIndex = 1;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\Public\Documents\" + Lbl_archivo_txt.Text.Trim() + ".txt") == true)
            {
                string Xdescripcion_pr;
                string Xpreciounitario_pr;
                string Xcodigo_pr;
                string Ximpresora;
                StreamReader Leer = new StreamReader(@"C:\Users\Public\Documents\" + Lbl_archivo_txt.Text.Trim() + ".txt");
                Xdescripcion_pr = Leer.ReadLine();
                Xpreciounitario_pr = Leer.ReadLine();
                Xcodigo_pr = Leer.ReadLine();
                Ximpresora = Leer.ReadLine();
                Leer.Close();
               File.Delete(@"C:\Users\Public\Documents\" + Lbl_archivo_txt.Text.Trim() + ".txt");

                this.Agregar_Item(Xdescripcion_pr.Substring(15, Xdescripcion_pr.Length - 15),
                                  Xpreciounitario_pr.Substring(18, Xpreciounitario_pr.Length - 18),
                                  " 1.00",
                                  Xpreciounitario_pr.Substring(18, Xpreciounitario_pr.Length - 18),
                                  "",
                                 Convert.ToInt32(Xcodigo_pr.Substring(10, Xcodigo_pr.Length - 10)),
                                 Ximpresora.Substring(10, Ximpresora.Length - 10));

                TablaDetalle.AcceptChanges();
                const int columna = 3;

                decimal suma = 0;
                foreach (DataGridViewRow row in Dgv_Detalle.Rows)
                {
                    suma += Convert.ToDecimal(row.Cells[columna].Value);
                }
                Lbl_total.Text = Convert.ToString(suma);

            }
        }

        private void Btn_actualizarcantidad_Click(object sender, EventArgs e)
        {
            if (Dgv_Detalle.SelectedRows.Count > 0 && Lbl_cantidad.Text.Length>0)
            {
                DataGridViewRow Nfila = Dgv_Detalle.CurrentRow;
                if (Nfila == null)
                {
                    return;
                }

                Nfila.Cells["Cantidad"].Value = " "+Lbl_cantidad.Text+".00";
                Nfila.Cells["Total"].Value =" "+Convert.ToString(Convert.ToDecimal(Nfila.Cells["Preciounitario_pr"].Value) *
                                                             Convert.ToDecimal(Lbl_cantidad.Text));
                
                TablaDetalle.AcceptChanges();

                const int columna = 3;

                decimal suma=0;
                foreach (DataGridViewRow row in Dgv_Detalle.Rows)
                {
                    suma += Convert.ToDecimal(row.Cells[columna].Value);
                }
                Lbl_total.Text = Convert.ToString(suma);
            }
        }

        private void Btn_quitarproducto_Click(object sender, EventArgs e)
        {
            if (Dgv_Detalle.SelectedRows.Count > 0)
            {
                Dgv_Detalle.Rows.Remove(Dgv_Detalle.CurrentRow);
                TablaDetalle.AcceptChanges();

                const int columna = 3;

                decimal suma = 0;
                foreach (DataGridViewRow row in Dgv_Detalle.Rows)
                {
                    suma += Convert.ToDecimal(row.Cells[columna].Value);
                }
                Lbl_total.Text = Convert.ToString(suma);
            }
        }

        private void Btn_generarcomanda_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_cliente.Text.Trim() == string.Empty || Lbl_total.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataTable TablaImpresora = new DataTable();
                    E_RegistrarPedido Erp = new E_RegistrarPedido();
                    
                    Erp.Codigo_us = Convert.ToInt32(Lbl_codigo_us.Text);
                    Erp.Codigo_cl = Convert.ToInt32(Txt_codigo_cl.Text);
                    Erp.Cliente = Txt_cliente.Text.Trim();
                    Erp.Nrodocumento_cl = Txt_nrodocumento_cl.Text.Trim();
                    Erp.Total_ti = Convert.ToDecimal(Lbl_total.Text);
                    Erp.Codigo_me = Convert.ToInt32(Lbl_codigo_me.Text);
                    Erp.Comanda_ti = true;
                    Erp.Codigo_tu = Convert.ToInt32(Lbl_codigo_tu.Text);
                    TablaDetalle.AcceptChanges();

                    TablaImpresora=N_RegistrarPedido.Guardar_rp( Erp, TablaDetalle);
                        if (TablaImpresora.Rows.Count>0)
                        {
                        #region "Impresión de Comandas"
                        //En esta posición lanzamos la impresión de comandas a ticketeras                      

                        for (int Nfila = 0; Nfila <= TablaImpresora.Rows.Count - 1; Nfila++)
                        {
                            X1impresora= Convert.ToString(TablaImpresora.Rows[Nfila][0]);
                            X1codigo_ti= Convert.ToInt32(TablaImpresora.Rows[Nfila][1]);
                            X1descripcion_pv= Convert.ToString(TablaImpresora.Rows[Nfila][2]);
                            X1fecha_emision= Convert.ToString(TablaImpresora.Rows[Nfila][3]);
                            X1descripcion_tu= Convert.ToString(TablaImpresora.Rows[Nfila][4]);
                            X1nombres_us= Convert.ToString(TablaImpresora.Rows[Nfila][5]);
                            X1descripcion_ca= Convert.ToString(TablaImpresora.Rows[Nfila][6]);
                            X1descripcion_me= Convert.ToString(TablaImpresora.Rows[Nfila][7]);
                            X1cliente= Convert.ToString(TablaImpresora.Rows[Nfila][8]);
                            X1nrodocumento_cl= Convert.ToString(TablaImpresora.Rows[Nfila][9]);

                            // creación del printdocument para la comanda
                            printDocument1 = new PrintDocument();
                            //PrinterSettings Ps = new PrinterSettings();
                            //printDocument1.PrinterSettings= Ps;

                            printDocument1.PrinterSettings.PrinterName = X1impresora.Trim();                     
                            printDocument1.PrintPage += Imprimir;
                            printDocument1.Print();

                        }        
                        //Fin de impresión
                        #endregion
                        MessageBox.Show("Pedido generado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                            Txt_cliente.Text = "";
                            Txt_nrodocumento_cl.Text = "";
                            Chk_clientemanual.Checked = false;
                            Lbl_cantidad.Text = "";
                            Lbl_total.Text = "";
                            TablaDetalle.Clear();
                            TablaDetalle.AcceptChanges();
                            this.timer1.Enabled = false;
                            tabControl1.Controls["tabPage1"].Enabled = false;
                            tabControl1.Controls["tabPage2"].Enabled = false;
                            this.Mostrar_tickets_mesa(Convert.ToInt32(Lbl_codigo_me.Text));
                        //this.Close();
                    }
                        else
                        {
                            MessageBox.Show("Comanda no generada, verifique el detalle del pedido", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            DataTable TablaImprimir = new DataTable();           

            Font font1 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            Font font2 = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
            Font font3 = new Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point);
            int ancho = 250;
            int y = 20;
            
            e.Graphics.DrawString("Comanda Ticket # "+X1codigo_ti , font1, Brushes.Black,new RectangleF(0,y+=20,ancho,20));
            e.Graphics.DrawString("Punto de Venta: " + X1descripcion_pv, font2, Brushes.Black, new RectangleF(0, y+=20, ancho, 20));
            e.Graphics.DrawString("Fecha emisión: " + X1fecha_emision, font2, Brushes.Black, new RectangleF(0, y +=20, ancho, 20));
            e.Graphics.DrawString("Turno: " + X1descripcion_tu, font2, Brushes.Black, new RectangleF(0, y +=20, ancho, 20));
            e.Graphics.DrawString("Usuario: " + X1nombres_us, font2, Brushes.Black, new RectangleF(0, y +=20, ancho, 20));
            e.Graphics.DrawString("Cargo: " + X1descripcion_ca, font2, Brushes.Black, new RectangleF(0, y +=20, ancho, 20));
            e.Graphics.DrawString("# Mesa: " + X1descripcion_me, font2, Brushes.Black, new RectangleF(0, y +=20, ancho, 20));
            e.Graphics.DrawString("Cliente: " + X1cliente, font2, Brushes.Black, new RectangleF(0, y +=20, ancho, 20));
            e.Graphics.DrawString("Nro. doc: " + X1nrodocumento_cl, font2, Brushes.Black, new RectangleF(0, y +=20, ancho, 20));
            e.Graphics.DrawString("--------- PRODUCTOS --------- ", font2, Brushes.Black, new RectangleF(0, y +=30, ancho, 20));
            //imprimir detalle de la comanda
            TablaImprimir = N_RegistrarPedido.Imprimir_Comanda(X1impresora, X1codigo_ti);
            for (int Yfila = 0; Yfila <= TablaImprimir.Rows.Count - 1; Yfila++)
            {
                e.Graphics.DrawString(Convert.ToString(TablaImprimir.Rows[Yfila][0])+"  "+
                                      Convert.ToString(TablaImprimir.Rows[Yfila][1]),                    
                    font3, Brushes.Black, new RectangleF(0, y +=20, ancho, 20));
                //observación por cada producto
                string Yobs = Convert.ToString(TablaImprimir.Rows[Yfila][2]);
                if (Yobs.Length > 0)
                {
                    e.Graphics.DrawString("     |-> "+ Yobs,
                   font3, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
                }

                //fin de observación

            }
                //fin de comanda x impresora
        }
        private void btn_lupa_Click(object sender, EventArgs e)
        {

            Pnl_listado_cl.Location = new Point(12, 53);
            Pnl_listado_cl.Visible = true;
            Txt_buscar_cl.Select();
            this.Listar_cl(Txt_buscar_cl.Text);
        }

        private void Dgv_Listado_cl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_cl();
            Pnl_listado_cl.Visible = false;
        }

        private void Chk_clientemanual_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_clientemanual.Checked == true)
            {
                Txt_codigo_cl.Text = "1";
                Txt_cliente.Text="";
                Txt_nrodocumento_cl.Text="";
                Txt_cliente.ReadOnly = false;
                Txt_nrodocumento_cl.ReadOnly = false;
                Txt_cliente.Focus();
            }
            else
            {
                Txt_codigo_cl.Text = "0";
                Txt_cliente.Text="";
                Txt_nrodocumento_cl.Text="";
                Txt_cliente.ReadOnly = true;
                Txt_nrodocumento_cl.ReadOnly = true;
            }
        }

        private void Btn_retornar_cl_Click(object sender, EventArgs e)
        {
            Pnl_listado_cl.Visible = false;
        }      

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_Listado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.EstadoPrecuenta == 0)
            {
                this.Selecciona_dgv(); // nos mostrará el detalle del ticket seleccionado
            }
           
        }

        private void Btn_anularpedido_Click(object sender, EventArgs e)
        {
            Pnl_detalle_bo_fa.Visible = false;
            Pnl_detalle_ticket.Visible = false;
            // Se valida tiene los permisos administrador para realizar dicha tarea
            int Xcodigo_si = 2;
            int Xcodigo_us;
            int Xresp = 0;
            Xcodigo_us = Convert.ToInt32(Lbl_codigo_us.Text);
            DataTable Tablatemp_admin = new DataTable();
            Tablatemp_admin = N_login.Usuario_Admin(Xcodigo_si,Xcodigo_us);
            if (Tablatemp_admin.Rows.Count > 0) //usuario si tiene permiso administrador
            {
                Xresp = 1;
            }
            else
            {
                Xresp = 2;
                MessageBox.Show("Usuario no tiene permiso para este proceso", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if ((Dgv_Listado.SelectedRows.Count > 0) && (Xresp ==1) )
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Anular Ticket ahora?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    Btn_anularpedido.Enabled = false;
                    Btn_emitirdocumento.Enabled = false;
                    Pnl_observacion_anulado.Visible = true;
                    Txt_obsanulado_ti.Text = "";
                    Txt_obsanulado_ti.Select();
                }
                else
                {
                    Pnl_observacion_anulado.Visible = false;
                }


            }
        }


        //Esta reimpresión solo es válida para la anulación de cuenta
        private void Reimprimir3(object sender, PrintPageEventArgs e)
        {
            DataTable TablaImprimir = new DataTable();

            Font font1 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            Font font2 = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
            Font font3 = new Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point);
            int ancho = 250;
            int y = 20;

            e.Graphics.DrawString("< ANULACIÓN DE CUENTA >", font1, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Comanda Ticket # " + X1codigo_ti, font1, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("MOTIVO: " + X1obsanulado_ti, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            e.Graphics.DrawString("Punto de Venta: " + X1descripcion_pv, font2, Brushes.Black, new RectangleF(0, y += 50, ancho, 20));
            e.Graphics.DrawString("Fecha emisión: " + X1fecha_emision, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Turno: " + X1descripcion_tu, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Usuario: " + X1nombres_us, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cargo: " + X1descripcion_ca, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("# Mesa: " + X1descripcion_me, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cliente: " + X1cliente, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Nro. doc: " + X1nrodocumento_cl, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--------- PRODUCTOS --------- ", font2, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            //imprimir detalle de la comanda
            TablaImprimir = N_RegistrarPedido.Imprimir_Comanda2(X1codigo_ti);
            for (int Yfila = 0; Yfila <= TablaImprimir.Rows.Count - 1; Yfila++)
            {
                e.Graphics.DrawString(Convert.ToString(TablaImprimir.Rows[Yfila][0]) + "  " +
                                      Convert.ToString(TablaImprimir.Rows[Yfila][1]),
                    font3, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
                //observación por cada producto
                string Yobs = Convert.ToString(TablaImprimir.Rows[Yfila][2]);
                if (Yobs.Length > 0)
                {
                    e.Graphics.DrawString("     |-> " + Yobs,
                   font3, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
                }

                //fin de observación

            }
            //fin de comanda x impresora
        }

        //Fin de reimpresión

        private void Btn_cancelar2_Click(object sender, EventArgs e)
        {
            Pnl_observacion_anulado.Visible = false;
            Btn_anularpedido.Enabled = true;
            Btn_emitirdocumento.Enabled = true;
        }

        private void Btn_confirmar_Click(object sender, EventArgs e)
        {
            if (Txt_obsanulado_ti.Text == string.Empty)
            {
                MessageBox.Show("Es necesario ingresar el motivo de la anulación del ticket", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txt_obsanulado_ti.Select();
            }
            else
            {
                int Xcodigo_ti;
                string Cobs;
                string XfechayHora;
                int Xcodigo_me;
                string Rpta = "";
                Xcodigo_ti = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_ti"].Value);
                Xcodigo_me = Convert.ToInt32(Lbl_codigo_me.Text);
                XfechayHora = "  :::Fecha/Hora: " + DateTime.Now;
                Cobs = Txt_obsanulado_ti.Text.Trim() + " ==>Anulado x usuario : "+Lbl_codigo_us.Text+XfechayHora;
                //MessageBox.Show(Cobs);
                Rpta = N_RegistrarPedido.Eliminar_ti(Xcodigo_ti, Xcodigo_me, Cobs);
                if (Rpta.Equals("OK"))
                {
                    // Iniciamos la previa para la impresión de la cuenta anulada
                  
                    DataTable TablaImpresora = new DataTable();

                    TablaImpresora = N_RegistrarPedido.Reimprimir_comanda(Xcodigo_ti);
                    if (TablaImpresora.Rows.Count > 0)
                    {
                        #region "Impresión de Comandas"
                        //En esta posición lanzamos la impresión de comandas a ticketeras                      

                        for (int Nfila = 0; Nfila <= TablaImpresora.Rows.Count - 1; Nfila++)
                        {
                            X1impresora = Convert.ToString(TablaImpresora.Rows[Nfila][0]);
                            X1codigo_ti = Convert.ToInt32(TablaImpresora.Rows[Nfila][1]);
                            X1descripcion_pv = Convert.ToString(TablaImpresora.Rows[Nfila][2]);
                            X1fecha_emision = Convert.ToString(TablaImpresora.Rows[Nfila][3]);
                            X1descripcion_tu = Convert.ToString(TablaImpresora.Rows[Nfila][4]);
                            X1nombres_us = Convert.ToString(TablaImpresora.Rows[Nfila][5]);
                            X1descripcion_ca = Convert.ToString(TablaImpresora.Rows[Nfila][6]);
                            X1descripcion_me = Convert.ToString(TablaImpresora.Rows[Nfila][7]);
                            X1cliente = Convert.ToString(TablaImpresora.Rows[Nfila][8]);
                            X1nrodocumento_cl = Convert.ToString(TablaImpresora.Rows[Nfila][9]);
                            X1obsanulado_ti= Convert.ToString(TablaImpresora.Rows[Nfila][10]);
                            // creación del printdocument para la comanda
                            printDocument1 = new PrintDocument();
                            //PrinterSettings Ps = new PrinterSettings();
                            //printDocument1.PrinterSettings= Ps;

                            //printDocument1.PrinterSettings.PrinterName = X1impresora.Trim();
                            _ = printDocument1.PrinterSettings.IsDefaultPrinter;
                            printDocument1.PrintPage += Reimprimir3;
                            printDocument1.Print();

                        }
                        //Fin de impresión
                        #endregion
                    }
                    //Fin de la impresión de cuenta anulada

                    this.Mostrar_tickets_mesa(Convert.ToInt32(Lbl_codigo_me.Text));
                    Pnl_detalle_ticket.Visible = false;
                    Pnl_observacion_anulado.Visible = false;
                    MessageBox.Show("Ticket anulado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Btn_anularpedido.Enabled = true;
                    Btn_emitirdocumento.Enabled = true;
                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void Pnl_tareas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_retornar_obs_Click(object sender, EventArgs e)
        {
            if (Dgv_Detalle.SelectedRows.Count > 0 )
            {
               DataGridViewRow Nfila = Dgv_Detalle.CurrentRow;
                if (Nfila == null)
                {
                    return;
                }
                Nfila.Cells["Obs"].Value = Txt_observacion.Text;  
                TablaDetalle.AcceptChanges();
                Pnl_observacion.Visible = false;
            }
        }

        private void Dgv_Detalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_Detalle.SelectedRows.Count > 0)
            {
                DataGridViewRow Nfila2 = Dgv_Detalle.CurrentRow;
                if (Nfila2 == null)
                {
                    return;
                }
                Txt_observacion.Text= Convert.ToString(Nfila2.Cells["Obs"].Value);
                Pnl_observacion.Visible = true;
                Txt_observacion.Select();
            }    
        }

        private void Btn_emitirdocumento_Click(object sender, EventArgs e)
        {
            Pnl_detalle_bo_fa.Visible = false;
            Pnl_detalle_ticket.Visible = false;
            if (Dgv_Listado.Rows.Count > 0)
            {
                this.EstadoPrecuenta = 1; //Listo para precuenta
                Pnl_detalle_ticket.Visible = false;
                Btn_anularpedido.Enabled = false;
                Btn_emitirdocumento.Enabled = false;
                Btn_dividir_cuenta.Enabled = false;
                Btn_boleta.Enabled = false;
                Btn_factura.Enabled = false;
                Dgv_Listado.Columns[0].Visible = true;
                Dgv_Listado.Columns[0].ReadOnly = false;
                Btn_cancelar3.Visible = true;
                Btn_confirmar3.Visible = true;
                Btn_cancelar4.Visible = false;
                Btn_confirmar4.Visible = false;
                Btn_cancelar5.Visible = false;
                Btn_confirmar5.Visible = false;
                Btn_imprimir_precuenta.Visible = false;
                Btn_grabar_division_cuenta.Visible = false;
                Btn_reimprimir_comanda.Visible = false;

            }
        }

        private void Btn_cancelar3_Click(object sender, EventArgs e)
        {
            Lbl_titulo_detalle_ticket.Text = "::: Detalle de ticket seleccionado :::";
            Pnl_detalle_bo_fa.Visible = false;
            Pnl_detalle_ticket.Visible = false;
            this.EstadoPrecuenta = 0; //sin ninguna acción
            Dgv_Listado.Columns[0].Visible = false;
            Dgv_Listado.Columns[0].ReadOnly = true;
            foreach (DataGridViewRow row in Dgv_Listado.Rows)
            {
                row.Cells["Seleccionar"].Value = false;
            }
            Btn_cancelar3.Visible = false;
            Btn_confirmar3.Visible = false;
            Btn_cancelar4.Visible = false;
            Btn_confirmar4.Visible = false;
            Btn_cancelar5.Visible = false;
            Btn_confirmar5.Visible = false;
            Btn_anularpedido.Enabled = true;
            Btn_emitirdocumento.Enabled = true;
            Btn_dividir_cuenta.Enabled = true;
            Btn_boleta.Enabled = true;
            Btn_factura.Enabled = true;
        }

        private void Btn_confirmar3_Click(object sender, EventArgs e)
        {
            try
            {
                //DialogResult Opcion;
                //Opcion = MessageBox.Show("¿Procesar Precuenta con los ticket seleccionado?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               //if (Opcion == DialogResult.Yes)
               // {
                    Lbl_titulo_detalle_ticket.Text = "< PRECUENTA > ::: Detalle de ticket seleccionado :::";
                    this.TablaTicket = new DataTable("TablaTicket");
                    this.TablaTicket.Columns.Add("Codigo_ti", System.Type.GetType("System.Int32"));
                  
                    int Codigo;
                    string Ticket_seleccionado="";
                    string Xcliente="";
                    string Xnrodocumento_cl = "";
                    decimal Xtotal_ti=Convert.ToDecimal("0.00");
                    foreach (DataGridViewRow row in Dgv_Listado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Ticket_seleccionado = Ticket_seleccionado +" Ticket # "+ Convert.ToString(row.Cells[1].Value) + " / ";
                            Xcliente =Convert.ToString(row.Cells[2].Value);
                            Xnrodocumento_cl= Convert.ToString(row.Cells[5].Value);
                            Xtotal_ti += Convert.ToDecimal(row.Cells[4].Value);
                            this.TablaTicket.Rows.Add(Codigo);                           
                        }
                    }
                    this.TablaTicket.AcceptChanges();
                    Dgv_detalle_ticket.DataSource = N_RegistrarPedido.Mostrar_ticket_precuenta(TablaTicket);
                    Txt_cliente_detalle_ticket.Text = Xcliente;
                    Txt_nrodocumento_cliente_detalle.Text = Xnrodocumento_cl;
                    Lbl_tickets_seleccionados.Text = Ticket_seleccionado;
                    Lbl_total_detalle_ticket.Text =Convert.ToString(Xtotal_ti);
                    Pnl_detalle_ticket.Visible = true;
                    Btn_reimprimir_comanda.Visible = false;
                    Btn_imprimir_precuenta.Location = Btn_reimprimir_comanda.Location;
                    Btn_imprimir_precuenta.Visible = true;
                    this.Formato_ti();
                    
                    Dgv_Listado.Columns[0].ReadOnly = true;
                    Btn_cancelar3.Visible = true;
                    Btn_confirmar3.Visible = true;
                   
               // }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_dividir_cuenta_Click(object sender, EventArgs e)
        {
            Pnl_detalle_bo_fa.Visible = false;
            Pnl_detalle_ticket.Visible = false;
            if (Dgv_Listado.Rows.Count > 0)
            {
                this.EstadoPrecuenta = 2; //Listo para dividir cuenta
                Pnl_detalle_ticket.Visible = false;
                Btn_anularpedido.Enabled = false;
                Btn_emitirdocumento.Enabled = false;
                Btn_dividir_cuenta.Enabled = false;
                Btn_boleta.Enabled = false;
                Btn_factura.Enabled = false;
                Dgv_Listado.Columns[0].Visible = true;
                Dgv_Listado.Columns[0].ReadOnly = false;
                Btn_cancelar4.Visible = true;
                Btn_confirmar4.Visible = true;
                Btn_cancelar3.Visible = false;
                Btn_confirmar3.Visible = false;
                Btn_cancelar5.Visible = false;
                Btn_confirmar5.Visible = false;
                Btn_cancelar4.Location = Btn_cancelar3.Location;
                Btn_confirmar4.Location = Btn_confirmar3.Location;
                Btn_imprimir_precuenta.Visible = false;
                Btn_grabar_division_cuenta.Visible = false;
                Btn_reimprimir_comanda.Visible = false;

            }
        }

        private void Btn_confirmar4_Click(object sender, EventArgs e)
        {
            try
            {
                //DialogResult Opcion;
                //Opcion = MessageBox.Show("¿Procesar Ticket(s) seleccionado(s) para división de cuenta?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (Opcion == DialogResult.Yes)
                //{
                    Lbl_titulo_detalle_ticket.Text = "< DIVISIÓN DE CUENTAS >::: Detalle de ticket seleccionado :::";
                    this.TablaTicket = new DataTable("TablaTicket");
                    this.TablaTicket.Columns.Add("Codigo_ti", System.Type.GetType("System.Int32"));

                    int Codigo;
                    string Xcliente = "";
                    string Xnrodocumento_cl = "";
                    decimal Xtotal_ti = Convert.ToDecimal("0.00");
                    foreach (DataGridViewRow row in Dgv_Listado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Xcliente = Xcliente + Convert.ToString(row.Cells[2].Value) + " - ";
                            Xnrodocumento_cl = Xnrodocumento_cl + Convert.ToString(row.Cells[5].Value) + " - ";
                            Xtotal_ti += Convert.ToDecimal(row.Cells[4].Value);
                            this.TablaTicket.Rows.Add(Codigo);
                        }
                    }
                    this.TablaTicket.AcceptChanges(); //se tiene los códigos de los tickets seleccionados para la división de cuenta
                    Dgv_detalle_ticket.DataSource = N_RegistrarPedido.Mostrar_ticket_precuenta(TablaTicket);                    
                    Txt_cliente_detalle_ticket.Text = Xcliente;
                    Txt_nrodocumento_cliente_detalle.Text = Xnrodocumento_cl;
                    Lbl_total_detalle_ticket.Text = Convert.ToString(Xtotal_ti);
                    Pnl_detalle_ticket.Visible = true;
                    Btn_reimprimir_comanda.Visible = false;                   
                    this.Formato_ti();
                    Dgv_Listado.Columns[0].ReadOnly = true;
                    Dgv_detalle_ticket.Columns[0].Visible = true;
                    Dgv_detalle_ticket.Columns[0].ReadOnly = false;
                    // colocamos el dato por default en el detalle de la division de cuenta
                        foreach (DataGridViewRow row in Dgv_detalle_ticket.Rows)
                        {
                            row.Cells["Cuentas"].Value="Cuenta 01";

                        }                    
                    //
                    Btn_cancelar4.Visible = true;
                    Btn_confirmar4.Visible = true;
                    Btn_grabar_division_cuenta.Visible = true;
                    Btn_grabar_division_cuenta.Location = Btn_reimprimir_comanda.Location;

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_cancelar4_Click(object sender, EventArgs e)
        {
            Lbl_titulo_detalle_ticket.Text = "::: Detalle de ticket seleccionado :::";
            Pnl_detalle_bo_fa.Visible = false;
            Pnl_detalle_ticket.Visible = false;
            this.EstadoPrecuenta = 0; //sin ninguna acción
            Dgv_Listado.Columns[0].Visible = false;
            Dgv_Listado.Columns[0].ReadOnly = true;
            foreach (DataGridViewRow row in Dgv_Listado.Rows)
            {
                row.Cells["Seleccionar"].Value = false;
            }
            Dgv_detalle_ticket.Columns[0].Visible = false;
            Dgv_detalle_ticket.Columns[0].ReadOnly = true;
            Btn_cancelar4.Visible = false;
            Btn_confirmar4.Visible = false;
            Btn_cancelar3.Visible = false;
            Btn_confirmar3.Visible = false;
            Btn_cancelar5.Visible = false;
            Btn_confirmar5.Visible = false;
            Btn_anularpedido.Enabled = true;
            Btn_emitirdocumento.Enabled = true;
            Btn_dividir_cuenta.Enabled = true;
            Btn_boleta.Enabled = true;
            Btn_factura.Enabled = true;
        }

        private void Btn_grabar_division_cuenta_Click(object sender, EventArgs e)
        {
            try
            {
                this.Crear_TablaDvision();
                int Ycodigo_us;
                int Ycodigo_cl;
                int Ycodigo_me;
                int Ycodigo_tu;               
                Ycodigo_us = Convert.ToInt32(Lbl_codigo_us.Text);
                Ycodigo_cl = Convert.ToInt32("1"); // por ser una división de cuenta colocamos al cliente por defecto en standard
                Ycodigo_me = Convert.ToInt32(Lbl_codigo_me.Text);
                Ycodigo_tu = Convert.ToInt32(Lbl_codigo_tu.Text);
                E_Division_Cuentas Edc = new E_Division_Cuentas();

                //Inicio el pase de detalle hacia la tabla división de cuentas
              

                foreach (DataGridViewRow row in Dgv_detalle_ticket.Rows)
                {
                    Edc.Cuentas=Convert.ToString(row.Cells["Cuentas"].Value);                    
                    Edc.Descripcion_pr = Convert.ToString(row.Cells["Descripcion_pr"].Value);
                    Edc.Preciounitario_ti = Convert.ToDecimal(row.Cells["Preciounitario_ti"].Value);
                    Edc.Cantidad_ti = Convert.ToDecimal(row.Cells["Cantidad_ti"].Value);
                    Edc.Total_ti = Convert.ToDecimal(row.Cells["Total_ti"].Value);
                    Edc.Observacion = Convert.ToString(row.Cells["Observacion"].Value);
                    Edc.Codigo_ti = Convert.ToInt32(row.Cells["Codigo_ti"].Value);
                    Edc.Codigo_pr = Convert.ToInt32(row.Cells["Codigo_pr"].Value);
                    Edc.Impresora = Convert.ToString(row.Cells["Impresora"].Value);                   
                    this.Tabla_Division.Rows.Add(Edc.Cuentas,
                                                 Edc.Descripcion_pr,
                                                 Edc.Preciounitario_ti,
                                                 Edc.Cantidad_ti,
                                                 Edc.Total_ti,
                                                 Edc.Observacion,
                                                 Edc.Codigo_ti,
                                                 Edc.Codigo_pr,
                                                 Edc.Impresora);                    
                }
                this.Tabla_Division.AcceptChanges();
                //
                DataTable Mitabla = new DataTable();
                Mitabla = N_RegistrarPedido.Guardar_Division_Cuentas(Ycodigo_us,Ycodigo_cl,Ycodigo_me,Ycodigo_tu, Tabla_Division);
                if (Mitabla.Rows.Count > 0) 
                {
                    for (int Xfila = 0; Xfila <= Mitabla.Rows.Count - 1; Xfila++) //Recorremos los códigos de la división de cuenta realizada
                    {
                        int Xcodigo_ti;
                        Xcodigo_ti= Convert.ToInt32(Mitabla.Rows[Xfila][0]);

                        //Iniciamos la impresión de la cuentas dividas en el formato de tickets.
                        DataTable TablaImpresora = new DataTable();

                        TablaImpresora = N_RegistrarPedido.Reimprimir_comanda(Xcodigo_ti);
                        if (TablaImpresora.Rows.Count > 0)
                        {
                            #region "Impresión de Comandas"
                            //En esta posición lanzamos la impresión de comandas a ticketeras                      

                            for (int Nfila = 0; Nfila <= TablaImpresora.Rows.Count - 1; Nfila++)
                            {
                                X1impresora = Convert.ToString(TablaImpresora.Rows[Nfila][0]);
                                X1codigo_ti = Convert.ToInt32(TablaImpresora.Rows[Nfila][1]);
                                X1descripcion_pv = Convert.ToString(TablaImpresora.Rows[Nfila][2]);
                                X1fecha_emision = Convert.ToString(TablaImpresora.Rows[Nfila][3]);
                                X1descripcion_tu = Convert.ToString(TablaImpresora.Rows[Nfila][4]);
                                X1nombres_us = Convert.ToString(TablaImpresora.Rows[Nfila][5]);
                                X1descripcion_ca = Convert.ToString(TablaImpresora.Rows[Nfila][6]);
                                X1descripcion_me = Convert.ToString(TablaImpresora.Rows[Nfila][7]);
                                X1cliente = Convert.ToString(TablaImpresora.Rows[Nfila][8]);
                                X1nrodocumento_cl = Convert.ToString(TablaImpresora.Rows[Nfila][9]);

                                // creación del printdocument para la comanda
                                printDocument1 = new PrintDocument();
                               
                                _ = printDocument1.PrinterSettings.IsDefaultPrinter;
                                printDocument1.PrintPage += Reimprimir2;
                                printDocument1.Print();

                            }
                            //Fin de impresión
                            #endregion
                        }
                    }
                        //Fin de la impresión.

                        MessageBox.Show("División de cuenta generada correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Pnl_detalle_ticket.Visible = false;
                    this.EstadoPrecuenta = 0; //sin ninguna acción
                    Dgv_Listado.Columns[0].Visible = false;
                    Dgv_Listado.Columns[0].ReadOnly = true;
                    foreach (DataGridViewRow row in Dgv_Listado.Rows)
                    {
                        row.Cells["Seleccionar"].Value = false;
                    }
                    Dgv_detalle_ticket.Columns[0].Visible = false;
                    Dgv_detalle_ticket.Columns[0].ReadOnly = true;
                    Btn_cancelar4.Visible = false;
                    Btn_confirmar4.Visible = false;
                    Btn_anularpedido.Enabled = true;
                    Btn_emitirdocumento.Enabled = true;
                    Btn_dividir_cuenta.Enabled = true;
                    Btn_boleta.Enabled = true;
                    Btn_factura.Enabled = true;
                    Tabla_Division.Clear();
                    Tabla_Division.AcceptChanges();
                    this.Mostrar_tickets_mesa(Convert.ToInt32(Lbl_codigo_me.Text));

                }
                    else
                    {
                        MessageBox.Show("No se ha logrado realizar la división de cuenta ... verifique", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        //Esta reimpresión solo es válida para la división de cuenta
        private void Reimprimir2(object sender, PrintPageEventArgs e)
        {
            DataTable TablaImprimir = new DataTable();

            Font font1 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            Font font2 = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
            Font font3 = new Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point);
            int ancho = 250;
            int y = 20;

            e.Graphics.DrawString("< DIVISIÓN DE CUENTA >", font1, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Comanda Ticket # " + X1codigo_ti, font1, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Punto de Venta: " + X1descripcion_pv, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Fecha emisión: " + X1fecha_emision, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Turno: " + X1descripcion_tu, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Usuario: " + X1nombres_us, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cargo: " + X1descripcion_ca, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("# Mesa: " + X1descripcion_me, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cliente: " + X1cliente, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Nro. doc: " + X1nrodocumento_cl, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--------- PRODUCTOS --------- ", font2, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            //imprimir detalle de la comanda
            TablaImprimir = N_RegistrarPedido.Imprimir_Comanda2(X1codigo_ti);
            for (int Yfila = 0; Yfila <= TablaImprimir.Rows.Count - 1; Yfila++)
            {
                e.Graphics.DrawString(Convert.ToString(TablaImprimir.Rows[Yfila][0]) + "  " +
                                      Convert.ToString(TablaImprimir.Rows[Yfila][1]),
                    font3, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
                //observación por cada producto
                string Yobs = Convert.ToString(TablaImprimir.Rows[Yfila][2]);
                if (Yobs.Length > 0)
                {
                    e.Graphics.DrawString("     |-> " + Yobs,
                   font3, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
                }

                //fin de observación

            }
            //fin de comanda x impresora
        }

        //Fin de reimpresión

        private void Btn_reimprimir_comanda_Click(object sender, EventArgs e)
        {
            try
            {
                // Se valida tiene los permisos administrador para realizar dicha tarea
                int Xcodigo_si = 2;
                int Xcodigo_us;
                int Xresp = 0;
                Xcodigo_us = Convert.ToInt32(Lbl_codigo_us.Text);
                DataTable Tablatemp_admin = new DataTable();
                Tablatemp_admin = N_login.Usuario_Admin(Xcodigo_si, Xcodigo_us);
                if (Tablatemp_admin.Rows.Count > 0) //usuario si tiene permiso administrador
                {
                    Xresp = 1;
                }
                else
                {
                    Xresp = 0;
                    MessageBox.Show("Usuario no tiene permiso para este proceso", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                

                if (Dgv_detalle_ticket.Rows.Count<=0)
                {
                    MessageBox.Show("No se tiene datos de detalle", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataTable TablaImpresora = new DataTable();                
                    

                    TablaImpresora = N_RegistrarPedido.Reimprimir_comanda(Convert.ToInt32(Lbl_codigo_ti.Text));
                    if ((TablaImpresora.Rows.Count > 0) && (Xresp==1))
                    {
                        #region "Impresión de Comandas"
                        //En esta posición lanzamos la impresión de comandas a ticketeras                      

                        for (int Nfila = 0; Nfila <= TablaImpresora.Rows.Count - 1; Nfila++)
                        {
                            X1impresora = Convert.ToString(TablaImpresora.Rows[Nfila][0]);
                            X1codigo_ti = Convert.ToInt32(TablaImpresora.Rows[Nfila][1]);
                            X1descripcion_pv = Convert.ToString(TablaImpresora.Rows[Nfila][2]);
                            X1fecha_emision = Convert.ToString(TablaImpresora.Rows[Nfila][3]);
                            X1descripcion_tu = Convert.ToString(TablaImpresora.Rows[Nfila][4]);
                            X1nombres_us = Convert.ToString(TablaImpresora.Rows[Nfila][5]);
                            X1descripcion_ca = Convert.ToString(TablaImpresora.Rows[Nfila][6]);
                            X1descripcion_me = Convert.ToString(TablaImpresora.Rows[Nfila][7]);
                            X1cliente = Convert.ToString(TablaImpresora.Rows[Nfila][8]);
                            X1nrodocumento_cl = Convert.ToString(TablaImpresora.Rows[Nfila][9]);

                            // creación del printdocument para la comanda
                            printDocument1 = new PrintDocument();
                            //PrinterSettings Ps = new PrinterSettings();
                            //printDocument1.PrinterSettings= Ps;

                            printDocument1.PrinterSettings.PrinterName = X1impresora.Trim();
                            printDocument1.PrintPage += Reimprimir;
                            printDocument1.Print();

                        }
                        //Fin de impresión
                        #endregion
                        MessageBox.Show("Reimpresión de comanda generada correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                    }
                    else
                    {
                        MessageBox.Show("Reimpresión de comanda no generada, verifique el detalle del pedido", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Reimprimir(object sender, PrintPageEventArgs e)
        {
            DataTable TablaImprimir = new DataTable();

            Font font1 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            Font font2 = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
            Font font3 = new Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point);
            int ancho = 250;
            int y = 20;
            
            e.Graphics.DrawString("< REIMPRESIÓN >", font1, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Comanda Ticket # " + X1codigo_ti, font1, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Punto de Venta: " + X1descripcion_pv, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Fecha emisión: " + X1fecha_emision, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Turno: " + X1descripcion_tu, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Usuario: " + X1nombres_us, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cargo: " + X1descripcion_ca, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("# Mesa: " + X1descripcion_me, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cliente: " + X1cliente, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Nro. doc: " + X1nrodocumento_cl, font2, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--------- PRODUCTOS --------- ", font2, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            //imprimir detalle de la comanda
            TablaImprimir = N_RegistrarPedido.Imprimir_Comanda(X1impresora, X1codigo_ti);
            for (int Yfila = 0; Yfila <= TablaImprimir.Rows.Count - 1; Yfila++)
            {
                e.Graphics.DrawString(Convert.ToString(TablaImprimir.Rows[Yfila][0]) + "  " +
                                      Convert.ToString(TablaImprimir.Rows[Yfila][1]),
                    font3, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
                //observación por cada producto
                string Yobs = Convert.ToString(TablaImprimir.Rows[Yfila][2]);
                if (Yobs.Length > 0)
                {
                    e.Graphics.DrawString("     |-> " + Yobs,
                   font3, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
                }

                //fin de observación

            }
            //fin de comanda x impresora
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_cl_Click(object sender, EventArgs e)
        {            
            this.Listar_cl(Txt_buscar_cl.Text);
        }

        private void Btn_boleta_Click(object sender, EventArgs e)
        {
            Pnl_detalle_bo_fa.Visible = false;
            Pnl_detalle_ticket.Visible = false;
            // Se valida tiene los permisos administrador para realizar dicha tarea
            int Xcodigo_si = 2;
            int Xcodigo_us;
            int Xresp = 0;
            Xcodigo_us = Convert.ToInt32(Lbl_codigo_us.Text);
            DataTable Tablatemp_admin = new DataTable();
            Tablatemp_admin = N_login.Usuario_Admin(Xcodigo_si, Xcodigo_us);
            if (Tablatemp_admin.Rows.Count > 0) //usuario si tiene permiso administrador
            {
                Xresp = 1;
            }
            else
            {
                Xresp = 2;
                MessageBox.Show("Usuario no tiene permiso para este proceso", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            if ((Dgv_Listado.Rows.Count > 0) && (Xresp>0))
            {
                this.EstadoPrecuenta = 3; //Listo para boletear
                Pnl_detalle_ticket.Visible = false;
                Pnl_detalle_bo_fa.Visible = false;

                Btn_anularpedido.Enabled = false;
                Btn_emitirdocumento.Enabled = false;
                Btn_dividir_cuenta.Enabled = false;
                Btn_boleta.Enabled = false;
                Btn_factura.Enabled = false;
                Dgv_Listado.Columns[0].Visible = true;
                Dgv_Listado.Columns[0].ReadOnly = false;

                Btn_cancelar5.Visible = true;
                Btn_confirmar5.Visible = true;
                Btn_cancelar3.Visible = false;
                Btn_confirmar3.Visible = false;
                Btn_confirmar4.Visible = false;
                Btn_cancelar4.Visible = false;
                Btn_cancelar5.Location = Btn_cancelar3.Location;
                Btn_confirmar5.Location = Btn_confirmar3.Location;
                Btn_imprimir_precuenta.Visible = false;
                Btn_grabar_division_cuenta.Visible = false;
                Btn_reimprimir_comanda.Visible = false;
            }
        }

        private void Btn_cancelar5_Click(object sender, EventArgs e)
        {
            Lbl_titulo_bo_fa.Text = "::: NINGUNO :::";
            Pnl_detalle_bo_fa.Visible = false;
            Pnl_detalle_ticket.Visible = false;
            this.EstadoPrecuenta = 0; //sin ninguna acción
            Dgv_Listado.Columns[0].Visible = false;
            Dgv_Listado.Columns[0].ReadOnly = true;
            foreach (DataGridViewRow row in Dgv_Listado.Rows)
            {
                row.Cells["Seleccionar"].Value = false;
            }
            Btn_cancelar5.Visible = false;
            Btn_confirmar5.Visible = false;
            Btn_cancelar3.Visible = false;
            Btn_confirmar3.Visible = false;
            Btn_cancelar4.Visible = false;
            Btn_confirmar4.Visible = false;
            Btn_anularpedido.Enabled = true;
            Btn_emitirdocumento.Enabled = true;
            Btn_dividir_cuenta.Enabled = true;
            Btn_boleta.Enabled = true;
            Btn_factura.Enabled = true;
        }

        private void Btn_confirmar5_Click(object sender, EventArgs e)
        {
            try
            {
                //DialogResult Opcion;
                //Opcion = MessageBox.Show("¿Procesar los ticket seleccionado ahora?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (Opcion == DialogResult.Yes)
                //{
                    if (this.EstadoPrecuenta == 3)
                    {
                        Lbl_titulo_bo_fa.Text = "::: DETALLE DE BOLETA :::";
                    } else if (this.EstadoPrecuenta == 4)
                    {
                        Lbl_titulo_bo_fa.Text = "::: DETALLE DE FACTURA :::";
                    }   
                    
                    this.TablaTicket = new DataTable("TablaTicket");
                    this.TablaTicket.Columns.Add("Codigo_ti", System.Type.GetType("System.Int32"));

                    int Codigo;
                    int Xcodigo_cli=0;
                    string Xcliente = "";
                    string Xnrodocumento_cl = "";
                    decimal Xtotal_ti = Convert.ToDecimal("0.00");
                    foreach (DataGridViewRow row in Dgv_Listado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Xcodigo_cli= Convert.ToInt32(row.Cells[6].Value);
                            Xcliente = Xcliente + Convert.ToString(row.Cells[2].Value) + " - ";
                            Xnrodocumento_cl = Xnrodocumento_cl + Convert.ToString(row.Cells[5].Value) + " - ";
                            Xtotal_ti += Convert.ToDecimal(row.Cells[4].Value);
                            this.TablaTicket.Rows.Add(Codigo);
                        }
                    }
                    this.TablaTicket.AcceptChanges();
                    Dgv_detalle_bo_fa.DataSource = N_RegistrarPedido.Mostrar_ticket_precuenta(TablaTicket);

                    Txt_codigo_cl_bo_fa.Text =Convert.ToString(Xcodigo_cli);
                    Txt_cliente_bo_fa.Text = Xcliente;
                    Txt_nrodocumento_bo_fa.Text = Xnrodocumento_cl;
                    if (this.EstadoPrecuenta == 3) //Boleta
                    {
                        Lbl_total_bo.Text = Convert.ToString(Xtotal_ti);
                        Pnl_totales_bo.Visible = true;
                        Pnl_totales_fa.Visible = false;
                    }
                    else if (this.EstadoPrecuenta == 4)//Factura
                    {
                        decimal Igv18;                        
                        Igv18 =Convert.ToDecimal(1.18);
                        Lbl_total_fa.Text= Convert.ToString(Xtotal_ti);
                        Lbl_subtotal_fa.Text =Convert.ToString(decimal.Round(Xtotal_ti/Igv18,2));
                        Lbl_igv_fa.Text = Convert.ToString(decimal.Round((Xtotal_ti / Igv18) * Convert.ToDecimal(0.18),2));
                        Pnl_totales_bo.Visible = false;
                        Pnl_totales_fa.Visible = true;
                    }
                        
                    
                    Pnl_detalle_bo_fa.Location = Pnl_detalle_ticket.Location;
                    Pnl_totales_bo.Location = Pnl_totales_fa.Location;
                   
                    Pnl_detalle_bo_fa.Visible = true;                   
                    this.Formato_ti_boleta();

                    Dgv_Listado.Columns[0].ReadOnly = true;
                    Btn_cancelar5.Visible = true;
                    Btn_confirmar5.Visible = true;

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_imprimir_bo_fa_Click(object sender, EventArgs e)
        {                      
            if (this.EstadoPrecuenta == 3)// Se imprime para la boleta
            {
                try
                {
                    this.Crear_TablaDetalleBoleta();
                    int Ycodigo_cl;
                    string Ycliente;
                    string Ynrodocumento_cl;
                    string Ydireccion_cl;
                    decimal Ytotal_bo;
                    string Ynro_boleta;
                    int Ycodigo_us;                   
                    int Ycodigo_me;                    
                    
                    Ycodigo_cl = Convert.ToInt32(Txt_codigo_cl_bo_fa.Text);
                    Ycliente = Txt_cliente_bo_fa.Text.Trim();
                    Ynrodocumento_cl = Txt_nrodocumento_bo_fa.Text.Trim();
                    Ydireccion_cl = Txt_direccion_bo_fa.Text.Trim();
                    Ytotal_bo = Convert.ToDecimal(Lbl_total_bo.Text);
                    Ynro_boleta = Txt_correlativo_bo_fa.Text.Trim();
                    Ycodigo_us = Convert.ToInt32(Lbl_codigo_us.Text);                   
                    Ycodigo_me = Convert.ToInt32(Lbl_codigo_me.Text);
                    E_Detalle_Boleta Edb = new E_Detalle_Boleta();

                    //Inicio el pase de detalle hacia la tabla división de cuentas


                    foreach (DataGridViewRow row in Dgv_detalle_bo_fa.Rows)
                    {
                        Edb.Codigo_pr = Convert.ToInt32(row.Cells["Codigo_pr"].Value);
                        Edb.Preciounitario_pr = Convert.ToDecimal(row.Cells["Preciounitario_ti"].Value);
                        Edb.Cantidad_bo = Convert.ToDecimal(row.Cells["Cantidad_ti"].Value);
                        Edb.Total_bo = Convert.ToDecimal(row.Cells["Total_ti"].Value);                      
                        Edb.Codigo_ti = Convert.ToInt32(row.Cells["Codigo_ti"].Value);

                        this.Tabla_detalle_boleta.Rows.Add(Edb.Codigo_pr,
                                                           Edb.Preciounitario_pr,
                                                           Edb.Cantidad_bo,
                                                           Edb.Total_bo,                                                    
                                                           Edb.Codigo_ti);
                        
                    }
                    this.Tabla_detalle_boleta.AcceptChanges();
                    //
                    DataTable Tabla_Resul_bol = new DataTable();
                    Tabla_Resul_bol = N_RegistrarPedido.Guardar_Boleta(Ycodigo_cl,
                                                            Ycliente,
                                                            Ynrodocumento_cl,
                                                            Ydireccion_cl,
                                                            Ytotal_bo,
                                                            Ynro_boleta,
                                                            Ycodigo_us,
                                                            Ycodigo_me,
                                                            Tabla_detalle_boleta);
                    if (Tabla_Resul_bol.Rows.Count>0)
                    {     
                        Pnl_detalle_bo_fa.Visible = false;                      
                        this.EstadoPrecuenta = 0; //sin ninguna acción

                        Dgv_Listado.Columns[0].Visible = false;
                        Dgv_Listado.Columns[0].ReadOnly = true;
                        foreach (DataGridViewRow row in Dgv_Listado.Rows)
                        {
                            row.Cells["Seleccionar"].Value = false;
                        }
                      
                        Btn_cancelar5.Visible = false;
                        Btn_confirmar5.Visible = false;
                        Btn_anularpedido.Enabled = true;
                        Btn_emitirdocumento.Enabled = true;
                        Btn_dividir_cuenta.Enabled = true;
                        Btn_boleta.Enabled = true;
                        Btn_factura.Enabled = true;
                        Tabla_detalle_boleta.Clear();
                        Tabla_detalle_boleta.AcceptChanges();
                        this.Mostrar_tickets_mesa(Convert.ToInt32(Lbl_codigo_me.Text));

                        //iniciamos el proceso de envío de impresión de boleta
                        string Xcodigo_bo;
                        Xcodigo_bo = Convert.ToString(Tabla_Resul_bol.Rows[0][0]);
                        MessageBox.Show("Boleta # " + Xcodigo_bo + " generada correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Reportes.Frm_Rpt_Imprimir_Boleta ORpt_bo = new Reportes.Frm_Rpt_Imprimir_Boleta();
                        ORpt_bo.Txt_p1.Text = Xcodigo_bo;
                        ORpt_bo.ShowDialog();
                        //Finalizando el proceso de impresión de boleta.


                    }
                    else
                    {
                        MessageBox.Show("Boleta no generada... Revise por favor", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }

            if (this.EstadoPrecuenta == 4)// Se imprime para la factura
            {
                try
                {
                    this.Crear_TablaDetalleFactura();
                    int Ycodigo_cl;
                    string Ycliente;
                    string Ynrodocumento_cl;
                    string Ydireccion_cl;
                    decimal Ysubtotal_fa;
                    decimal Yigv_fa;
                    decimal Ytotal_fa;
                    string Ynro_factura;
                    int Ycodigo_us;
                    int Ycodigo_me;

                    Ycodigo_cl = Convert.ToInt32(Txt_codigo_cl_bo_fa.Text);
                    Ycliente = Txt_cliente_bo_fa.Text.Trim();
                    Ynrodocumento_cl = Txt_nrodocumento_bo_fa.Text.Trim();
                    Ydireccion_cl = Txt_direccion_bo_fa.Text.Trim();
                    Ysubtotal_fa = Convert.ToDecimal(Lbl_subtotal_fa.Text);
                    Yigv_fa = Convert.ToDecimal(Lbl_igv_fa.Text);
                    Ytotal_fa = Convert.ToDecimal(Lbl_total_fa.Text);
                    Ynro_factura = Txt_correlativo_bo_fa.Text.Trim();
                    Ycodigo_us = Convert.ToInt32(Lbl_codigo_us.Text);
                    Ycodigo_me = Convert.ToInt32(Lbl_codigo_me.Text);
                    E_Detalle_Factura Edf = new E_Detalle_Factura();

                    //Inicio el pase de detalle hacia la tabla división de cuentas


                    foreach (DataGridViewRow row in Dgv_detalle_bo_fa.Rows)
                    {
                        Edf.Codigo_pr = Convert.ToInt32(row.Cells["Codigo_pr"].Value);
                        Edf.Preciounitario_pr = Convert.ToDecimal(row.Cells["Preciounitario_ti"].Value);
                        Edf.Cantidad_fa = Convert.ToDecimal(row.Cells["Cantidad_ti"].Value);
                        Edf.Total_fa = Convert.ToDecimal(row.Cells["Total_ti"].Value);
                        Edf.Codigo_ti = Convert.ToInt32(row.Cells["Codigo_ti"].Value);

                        // EMD DEBUG
                        this.Tabla_detalle_factura.Rows.Add(Edf.Codigo_pr,
                                                           Edf.Preciounitario_pr,
                                                           Edf.Cantidad_fa,
                                                           Edf.Total_fa,
                                                           Edf.Codigo_ti);



                        this.Tabla_detalle_boleta.Rows.Add(Edf.Codigo_pr,
                                                           Edf.Preciounitario_pr,
                                                           Edf.Cantidad_fa,
                                                           Edf.Total_fa,
                                                           Edf.Codigo_ti);

                    }
                    this.Tabla_detalle_boleta.AcceptChanges();
                    //
                    DataTable Tabla_Resul_bol = new DataTable();
                    Tabla_Resul_bol = N_RegistrarPedido.Guardar_Factura(Ycodigo_cl,
                                                                        Ycliente,
                                                                        Ynrodocumento_cl,
                                                                        Ydireccion_cl,
                                                                        Ysubtotal_fa,
                                                                        Yigv_fa,
                                                                        Ytotal_fa,
                                                                        Ynro_factura,
                                                                        Ycodigo_us,
                                                                        Ycodigo_me,
                                                                        Tabla_detalle_factura);
                    if (Tabla_Resul_bol.Rows.Count > 0)
                    {
                        Pnl_detalle_bo_fa.Visible = false;
                        this.EstadoPrecuenta = 0; //sin ninguna acción

                        Dgv_Listado.Columns[0].Visible = false;
                        Dgv_Listado.Columns[0].ReadOnly = true;
                        foreach (DataGridViewRow row in Dgv_Listado.Rows)
                        {
                            row.Cells["Seleccionar"].Value = false;
                        }

                        Btn_cancelar5.Visible = false;
                        Btn_confirmar5.Visible = false;
                        Btn_anularpedido.Enabled = true;
                        Btn_emitirdocumento.Enabled = true;
                        Btn_dividir_cuenta.Enabled = true;
                        Btn_boleta.Enabled = true;
                        Btn_factura.Enabled = true;
                        Tabla_detalle_boleta.Clear();
                        Tabla_detalle_boleta.AcceptChanges();
                        this.Mostrar_tickets_mesa(Convert.ToInt32(Lbl_codigo_me.Text));

                        //iniciamos el proceso de envío de impresión de boleta
                        string Xcodigo_fa;
                        Xcodigo_fa = Convert.ToString(Tabla_Resul_bol.Rows[0][0]);
                        MessageBox.Show("Factura #  " + Xcodigo_fa + " generada correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Reportes.Frm_Rpt_Imprimir_Factura ORpt_fa = new Reportes.Frm_Rpt_Imprimir_Factura();
                        ORpt_fa.Txt_p1.Text = Xcodigo_fa;
                        ORpt_fa.ShowDialog();
                        //Finalizando el proceso de impresión de boleta.


                    }
                    else
                    {
                        MessageBox.Show("Factura no generada... Revise por favor", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }

        }

        private void Btn_lupa2_Click(object sender, EventArgs e)
        {
            Pnl_listado_cl_bo_fa.Visible = true;
            Txt_buscar_cl_bo_fa.Select();
            this.Listar_cl_bo_fa(Txt_buscar_cl_bo_fa.Text);
        }

        private void Btn_buscar_cl_bo_fa_Click(object sender, EventArgs e)
        {
            this.Listar_cl_bo_fa(Txt_buscar_cl_bo_fa.Text);
        }

        private void Btn_retornar_cl_bo_fa_Click(object sender, EventArgs e)
        {
            Pnl_listado_cl_bo_fa.Visible = false;
        }

        private void Dgv_listado_cl_bo_fa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_cl_bo_fa();
            Pnl_listado_cl_bo_fa.Visible = false;
        }

        private void Btn_factura_Click(object sender, EventArgs e)
        {
            Pnl_detalle_bo_fa.Visible = false;
            Pnl_detalle_ticket.Visible = false;
            // Se valida tiene los permisos administrador para realizar dicha tarea
            int Xcodigo_si = 2;
            int Xcodigo_us;
            int Xresp = 0;
            Xcodigo_us = Convert.ToInt32(Lbl_codigo_us.Text);
            DataTable Tablatemp_admin = new DataTable();
            Tablatemp_admin = N_login.Usuario_Admin(Xcodigo_si, Xcodigo_us);
            if (Tablatemp_admin.Rows.Count > 0) //usuario si tiene permiso administrador
            {
                Xresp = 1;
            }
            else
            {
                Xresp = 2;
                MessageBox.Show("Usuario no tiene permiso para este proceso", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if ((Dgv_Listado.Rows.Count > 0) && (Xresp>0))
            {
                this.EstadoPrecuenta = 4; //Listo para facturar
                Pnl_detalle_ticket.Visible = false;
                Pnl_detalle_bo_fa.Visible = false;

                Btn_anularpedido.Enabled = false;
                Btn_emitirdocumento.Enabled = false;
                Btn_dividir_cuenta.Enabled = false;
                Btn_boleta.Enabled = false;
                Btn_factura.Enabled = false;
                Dgv_Listado.Columns[0].Visible = true;
                Dgv_Listado.Columns[0].ReadOnly = false;

                Btn_cancelar5.Visible = true;
                Btn_confirmar5.Visible = true;
                Btn_cancelar5.Location = Btn_cancelar3.Location;
                Btn_confirmar5.Location = Btn_confirmar3.Location;
                Btn_imprimir_precuenta.Visible = false;
                Btn_grabar_division_cuenta.Visible = false;
                Btn_reimprimir_comanda.Visible = false;
            }
        }

        private void Btn_imprimir_precuenta_Click(object sender, EventArgs e)
        {
            //OPCIÓN DE IMPRESIÓN DE PRECUENTA CON VISTA PREVIA
            string Ycliente;
            string Ynrodocumento_cl;
            string Ytickets_seleccionados;

            Ycliente = Txt_cliente_detalle_ticket.Text.Trim();
            Ynrodocumento_cl = Txt_nrodocumento_cliente_detalle.Text.Trim();
            Ytickets_seleccionados = Lbl_tickets_seleccionados.Text.Trim();

            Reportes.Frm_Rpt_Imprimir_Precuenta ORpt_tp = new Reportes.Frm_Rpt_Imprimir_Precuenta();
            ORpt_tp.USP_Precuenta_Tickets_SeleccionadosTableAdapter.Fill(ORpt_tp.DS_PuntoVenta.USP_Precuenta_Tickets_Seleccionados,Ccliente: Ycliente,Cnrodocumento_cl: Ynrodocumento_cl,Cticket_seleccionados: Ytickets_seleccionados,TD_TP: TablaTicket);

            ORpt_tp.reportViewer1.RefreshReport();
            
            _ =ORpt_tp.reportViewer1.PrinterSettings.IsDefaultPrinter;
            
            ORpt_tp.ShowDialog();   

            //FIN DE OPCIÓN DE VISTA PREVIA DE PRECUENTA         


        }

        private void Pnl_tareas_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Btn_busquedarapida_Click(object sender, EventArgs e)
        {
            Pnl_listado_pr.Location = new Point(3,42);
            Pnl_listado_pr.Visible = true;
            Txt_buscar_pr.Select();
            this.Listar_busqueda_pr(Txt_buscar_pr.Text);
        }

        private void Btn_buscar_pr_Click(object sender, EventArgs e)
        {
            this.Listar_busqueda_pr(Txt_buscar_pr.Text);
        }

        private void Btn_retornar_pr_Click(object sender, EventArgs e)
        {
            Pnl_listado_pr.Visible = false;
        }

        private void Dgv_Listado_Busqueda_pr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_busqueda_pr();
            Pnl_listado_pr.Visible = false;
        }

        private void Txt_buscar_pr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.Listar_busqueda_pr(Txt_buscar_pr.Text);
            }
        }
    }
}
