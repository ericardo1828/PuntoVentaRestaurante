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
using System.IO;

namespace Sol_PuntoVenta.Presentacion
{
    public partial class Frm_Productos : Form
    {
        public Frm_Productos()
        {
           InitializeComponent();
        }
        #region "Mis Variables"
        internal int iCodigo_us { get; set; }
        int nCodigo_pr = 0;
        int nCodigo_um = 0;
        int nCodigo_sf = 0;
        int nCodigo_ad = 0;
        int EstadoGuarda = 0;
        DataTable Dtdetalle = new DataTable();
        MemoryStream ms_pred;
        #endregion

        #region "Mis Métodos"
        private void Formato()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].Visible = false;
            Dgv_Listado.Columns[1].Width = 90;
            Dgv_Listado.Columns[1].HeaderText = "CÓDIGO PR";
            Dgv_Listado.Columns[2].Width = 260;
            Dgv_Listado.Columns[2].HeaderText = "PRODUCTO";
            Dgv_Listado.Columns[3].Width = 100;
            Dgv_Listado.Columns[3].HeaderText = "UNID.MEDIDA";
            Dgv_Listado.Columns[4].Width = 95;
            Dgv_Listado.Columns[4].HeaderText = "NRO.MEDIDA";
            Dgv_Listado.Columns[5].Width = 90;
            Dgv_Listado.Columns[5].HeaderText = "P.UNITARIO";
            Dgv_Listado.Columns[6].Width = 200;
            Dgv_Listado.Columns[6].HeaderText = "SUBFAMILIA";
            Dgv_Listado.Columns[7].Width = 180;
            Dgv_Listado.Columns[7].HeaderText = "ÁREA DESPACHO";
            Dgv_Listado.Columns[8].Visible= false;
            Dgv_Listado.Columns[9].Visible= false;
            Dgv_Listado.Columns[10].Visible= false;
            Dgv_Listado.Columns[11].Visible= false;
        }   

        private void Listado_pr(string cTexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Productos.Listado_pr(cTexto);
                this.Formato();
                Lbl_total.Text = "Total registros: " + Convert.ToString(Dgv_Listado.RowCount);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Mostrar(string Ctexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Productos.Mostrar_pr(Ctexto);
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
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_pr"].Value)))
            {
                MessageBox.Show("Seleccione un registro ", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo_pr = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_pr"].Value);
                Txt_descripcion_pr.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_pr"].Value);
                Cmb_Medidas.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_um"].Value);
                nCodigo_um = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_um"].Value);
                Txt_medida_pr.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["medida_pr"].Value);
                Txt_preciounitario_pr.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["preciounitario_pr"].Value);
                Txt_descripcion_sf.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_sf"].Value);
                nCodigo_sf = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_sf"].Value);
                Cmb_AreasDespachos.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_ad"].Value);
                nCodigo_ad = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_ad"].Value);
                Txt_observacion_pr.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["observacion_pr"].Value);

                this.Mostrar_pv(this.EstadoGuarda, nCodigo_pr);
                this.Mostrar_img(nCodigo_pr);  
            
            }
        }
        #region "Formato para la lista de Unidades de medidas"

        private void Cargar_Medidas()
        {
            try
            {
                Cmb_Medidas.DataSource = N_Productos.Listar_um("%");
                Cmb_Medidas.ValueMember = "codigo_um";
                Cmb_Medidas.DisplayMember = "descripcion_um";               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        #endregion

        #region "Formato para el listado de SubFamilias"
        private void Formato_sf()
        {
            Dgv_Listado_sf.Columns[0].Width = 220;
            Dgv_Listado_sf.Columns[0].HeaderText = "SUBFAMILIA";
            Dgv_Listado_sf.Columns[1].Width = 200;
            Dgv_Listado_sf.Columns[1].HeaderText = "FAMILIA";
            Dgv_Listado_sf.Columns[2].Width = 200;
            Dgv_Listado_sf.Columns[2].HeaderText = "CATEGORIA";
            Dgv_Listado_sf.Columns[3].Visible = false;
        }

        private void Listar_sf(string Ctexto)
        {
            try
            {
                Dgv_Listado_sf.DataSource = N_Productos.Listar_sf(Ctexto);
                this.Formato_sf();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_sf()
        {
            nCodigo_sf = Convert.ToInt32(Dgv_Listado_sf.CurrentRow.Cells["codigo_sf"].Value);
            Txt_descripcion_sf.Text = Convert.ToString(Dgv_Listado_sf.CurrentRow.Cells["descripcion_sf"].Value);
        }
        #endregion

        #region "Formato para el listado de Área de despacho"

        private void Cargar_AreasDespachos()
        {
            try
            {
                Cmb_AreasDespachos.DataSource = N_Productos.Listar_ad("%");
                Cmb_AreasDespachos.ValueMember = "codigo_ad";
                Cmb_AreasDespachos.DisplayMember = "descripcion_ad";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }       
        #endregion
        private void Estado_Limpiar(bool Lestado)
        {
            Btn_cancelar.Visible = Lestado;
            Btn_guardar.Visible = Lestado;
            Btn_retornar.Visible = !Lestado;

            Txt_buscar.Text="";            
            Txt_descripcion_pr.Text="";
            Txt_medida_pr.Text = "1.00";
            Txt_preciounitario_pr.Text = "0.00";
            Txt_descripcion_pr.ReadOnly = !Lestado;
            Cmb_Medidas.Enabled = Lestado;
            Cmb_AreasDespachos.Enabled= Lestado;
            Txt_medida_pr.ReadOnly = !Lestado;
            Txt_preciounitario_pr.ReadOnly = !Lestado;
            Pct_foto.Image = System.Drawing.Bitmap.FromStream(ms_pred);
            Txt_observacion_pr.ReadOnly = !Lestado;            
            Pnl_listado_sf.Visible = false;
           
        }

        private void Estado_BotonesPrincipales(bool Lestado)
        {
            Btn_nuevo.Enabled = Lestado;
            Btn_actualizar.Enabled = Lestado;
            Btn_eliminar.Enabled = Lestado;
            Btn_reporte.Enabled = Lestado;
            Btn_salir.Enabled = Lestado;           
            Btn_lupa2.Visible = !Lestado;            
            Btn_foto.Visible = !Lestado;

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

        private void Crear_Tabla_pv()
        {
            this.Dtdetalle = new DataTable("Detalle");
            this.Dtdetalle.Columns.Add("Descripcion_pv", System.Type.GetType("System.String"));
            this.Dtdetalle.Columns.Add("Estado", System.Type.GetType("System.Boolean"));
            this.Dtdetalle.Columns.Add("Codigo_pv", System.Type.GetType("System.Int32"));
           
            Dgv_puntoventa.DataSource = this.Dtdetalle;

            Dgv_puntoventa.Columns[0].Width = 220;
            Dgv_puntoventa.Columns[0].HeaderText = "PUNTO DE VENTA";
            Dgv_puntoventa.Columns[1].Width = 40;
            Dgv_puntoventa.Columns[1].HeaderText = "OK";
            Dgv_puntoventa.Columns[2].Visible = false;

            Dgv_puntoventa.Columns[0].ReadOnly = true;
            Dgv_puntoventa.Columns[1].ReadOnly = true;
        }
      
        private void Agregar_PV(string Descripcion_pv, bool Estado, int Codigo_pv)
        {
            DataRow Fila = Dtdetalle.NewRow();
            Fila["Descripcion_pv"] = Descripcion_pv;
            Fila["Estado"] = Estado;
            Fila["Codigo_pv"] = Codigo_pv;
            this.Dtdetalle.Rows.Add(Fila);
        }
        private void Mostrar_pv(int Nopcion ,int Ncodigo)
        {
            try
            {
                DataTable Tablatemp = new DataTable();
                Tablatemp = N_Productos.Mostrar_PV(Nopcion, Ncodigo);
                Dtdetalle.Clear();                
                for (int Nfila=0; Nfila<=Tablatemp.Rows.Count-1; Nfila++)
                {
                    this.Agregar_PV(Convert.ToString(Tablatemp.Rows[Nfila][0]),Convert.ToBoolean(Tablatemp.Rows[Nfila][1]),Convert.ToInt32(Tablatemp.Rows[Nfila][2]));
                }
                
                Dgv_puntoventa.DataSource = Dtdetalle;                
                if (Nopcion >= 1){
                    Dgv_puntoventa.Columns["estado"].ReadOnly = false;                   
                }
                else
                {
                    Dgv_puntoventa.Columns["estado"].ReadOnly = true;
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Mostrar_img(int Ncodigo)
        {
            Byte[] Bimagen = new byte[0];
            Bimagen = N_Productos.Mostrar_img(Ncodigo);
            MemoryStream ms = new MemoryStream(Bimagen);
            Pct_foto.Image = System.Drawing.Bitmap.FromStream(ms);
        }

        private void Mostrar_img_pred()
        {
            Byte[] Bimagen_pred = new byte[0];
            Bimagen_pred = N_Productos.Mostrar_img_pred();
            ms_pred = new MemoryStream(Bimagen_pred);            
        }

        #endregion

        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            this.Cargar_Medidas();
            this.Cargar_AreasDespachos();
            this.Mostrar("%");
            this.Crear_Tabla_pv();
            this.Mostrar_img_pred();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Mostrar(Txt_buscar.Text);
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            { 
                if (Txt_descripcion_pr.Text == string.Empty||
                    Cmb_Medidas.Text == string.Empty||
                    Cmb_AreasDespachos.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    nCodigo_um =Convert.ToInt32(Cmb_Medidas.SelectedValue);
                    nCodigo_ad = Convert.ToInt32(Cmb_AreasDespachos.SelectedValue);
                    E_Productos Epr = new E_Productos();
                    string Cduplica, Rpta = "";
                    Epr.Codigo_pr= nCodigo_pr;
                    Epr.Descripcion_pr = Txt_descripcion_pr.Text.Trim();
                    Epr.Medida_pr =Convert.ToDecimal(Txt_medida_pr.Text);
                    Epr.Preciounitario_pr = Convert.ToDecimal(Txt_preciounitario_pr.Text);
                    Epr.Observacion_pr = Txt_observacion_pr.Text.Trim();
                    Epr.Codigo_um = nCodigo_um;
                    Epr.Codigo_sf = nCodigo_sf;
                    Epr.Codigo_ad = nCodigo_ad;
                    Epr.Estado = true;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    Pct_foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    Epr.Imagen_pr = ms.GetBuffer();

                    // Verificamos si la información que se intenta guardar ya existe en la tabla
                    Cduplica = N_Productos.Verifica_duplicado_pr(this.EstadoGuarda, Epr.Codigo_pr, Epr.Descripcion_pr);
                    if (Cduplica == "")
                    {
                        Rpta = N_Productos.Guardar_pr(this.EstadoGuarda, Epr,Dtdetalle);
                        if (Rpta.Equals("OK"))
                        {
                            MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Estado_Limpiar(false);
                            nCodigo_pr = 0;
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
            Tbp_general.SelectedIndex = 1;
            this.Mostrar_pv(this.EstadoGuarda, 0);           
            Txt_descripcion_pr.Select();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Estado_Limpiar(false);
            nCodigo_pr = 0;
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
                Txt_descripcion_pr.Select();
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
                            Rpta = N_Productos.Eliminar_pr(Codigo);
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
            Reportes.Frm_Rpt_Productos ORpt_pr = new Reportes.Frm_Rpt_Productos();
            ORpt_pr.Txt_p1.Text = Txt_buscar.Text;
            ORpt_pr.ShowDialog();
        }

        private void Btn_lupa2_Click(object sender, EventArgs e)
        {
            Pnl_listado_sf.Location = new Point(78, 21);
            Pnl_listado_sf.Visible = true;
            Txt_buscar_sf.Select();
            this.Listar_sf(Txt_buscar_sf.Text);
        }

        private void Btn_retornar_sf_Click(object sender, EventArgs e)
        {
            Pnl_listado_sf.Visible = false;
        }

        private void Btn_buscar_sf_Click(object sender, EventArgs e)
        {
            this.Listar_sf(Txt_buscar_sf.Text);
        }

        private void Dgv_Listado_sf_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_sf();
            Pnl_listado_sf.Visible = false;
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Txt_descripcion_sf_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog Foto = new OpenFileDialog();
            Foto.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (Foto.ShowDialog() == DialogResult.OK)
            {
                Pct_foto.Image = Image.FromFile(Foto.FileName);
            }
        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void Dgv_puntoventa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
