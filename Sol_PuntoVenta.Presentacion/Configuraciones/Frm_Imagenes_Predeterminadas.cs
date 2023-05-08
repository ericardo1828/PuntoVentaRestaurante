using Sol_PuntoVenta.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Sol_PuntoVenta.Entidades;

namespace Sol_PuntoVenta.Presentacion.Configuraciones
{
    public partial class Frm_Imagenes_Predeterminadas : Form
    {
        public Frm_Imagenes_Predeterminadas()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int nCodigo_im = 0;
        int EstadoGuarda = 0;
        #endregion

        #region "Mis Métodos"
        private void Formato_pred()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].HeaderText = "CODIGO_IM";
            Dgv_Listado.Columns[1].Width = 300;
            Dgv_Listado.Columns[1].HeaderText = "NOMBRE IMAGEN PREDETERMINADA";
        }

        private void Listado_pred(string cTexto)
        {
            Dgv_Listado.DataSource = N_Imagenes_Predeterminadas.Listado_img_pred(cTexto);
            this.Formato_pred();
            Lbl_total.Text = "Total: "+ Dgv_Listado.Rows.Count;
        }

        private void Mostrar_img(int nCodigo_im)
        {
            Byte[] Bimagen = new byte[0];
            Bimagen = N_Imagenes_Predeterminadas.Mostrar_img_pred(nCodigo_im);
            MemoryStream ms = new MemoryStream(Bimagen);
            Pct_foto.Image = System.Drawing.Bitmap.FromStream(ms);
        }

        private void Selecciona_dgv()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_im"].Value)))
            {
                MessageBox.Show("Seleccione un registro ", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo_im = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_im"].Value);
                Txt_descripcion_im.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_im"].Value); 
                this.Mostrar_img(nCodigo_im);
            }
        }

        private void Estado_BotonesPrincipales(bool Lestado)
        {
            Btn_nuevo.Enabled = Lestado;
            Btn_actualizar.Enabled = Lestado;           
            Btn_salir.Enabled = Lestado;
           
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

        private void Estado_Limpiar(bool Lestado)
        {
            Btn_cancelar.Visible = Lestado;
            Btn_guardar.Visible = Lestado;
            Btn_retornar.Visible = !Lestado;

            Txt_buscar.Text = "";

            Txt_descripcion_im.Text = "";
            Txt_descripcion_im.ReadOnly = !Lestado;
        }

        #endregion

        private void Frm_Imagenes_Predeterminadas_Load(object sender, EventArgs e)
        {
            this.Listado_pred("%");
        }

        private void Dgv_Listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Estado_Limpiar(false);
            this.Selecciona_dgv();
            Tbp_general.SelectedIndex = 1;
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.EstadoGuarda = 1; //Nuevo registro
            nCodigo_im = 0;
            this.Estado_BotonesPrincipales(false);
            this.Estado_Limpiar(true);
            Tbp_general.SelectedIndex = 1;
            Txt_descripcion_im.Select();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Estado_Limpiar(false);
            nCodigo_im = 0;
            this.EstadoGuarda = 0;
            Tbp_general.SelectedIndex = 0;
            this.Estado_BotonesPrincipales(true);
        }

        private void Btn_retornar_Click(object sender, EventArgs e)
        {
            this.Estado_Limpiar(false);
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
                Txt_descripcion_im.Select();
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_descripcion_im.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    E_Imagenes_Predeterminadas oPropiedad = new E_Imagenes_Predeterminadas();
                    string Rpta = "";
                    oPropiedad.Codigo_im = nCodigo_im;
                    oPropiedad.Descripcion_im = Txt_descripcion_im.Text.Trim();
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    Pct_foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    oPropiedad.Imagen = ms.GetBuffer();

                    // Verificamos si la información que se intenta guardar ya existe en la tabla

                    Rpta = N_Imagenes_Predeterminadas.Guardar_img_pred(this.EstadoGuarda, oPropiedad);
                        if (Rpta.Equals("OK"))
                        {
                            MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Estado_Limpiar(false);
                            nCodigo_im = 0;
                            this.EstadoGuarda = 0;
                            this.Listado_pred("%");
                            Tbp_general.SelectedIndex = 0;
                            this.Estado_BotonesPrincipales(true);
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

        private void Btn_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog Foto = new OpenFileDialog();
            Foto.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (Foto.ShowDialog() == DialogResult.OK)
            {
                Pct_foto.Image = Image.FromFile(Foto.FileName);
            }
        }
    }
}
