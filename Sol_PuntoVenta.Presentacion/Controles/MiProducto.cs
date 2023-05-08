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

namespace Sol_PuntoVenta.Presentacion.Controles
{
    public partial class MiProducto : UserControl
    {
        #region "Variables y Propiedades"
        public int Codigo_pr
        {
            get { return Convert.ToInt32(Lbl_codigo_pr.Text); }
            set { Lbl_codigo_pr.Text = Convert.ToString(value); }
        }

        public string Descripcion_pr
        {
            get { return Lbl_descripcion_pr.Text; }
            set { Lbl_descripcion_pr.Text = value; }
        }

        public string Preciounitario_pr
        {
            get { return Lbl_preciounitario_pr.Text; }
            set { Lbl_preciounitario_pr.Text = value; }
        }

        public string Impresora
        {
            get { return Lbl_impresora.Text; }
            set { Lbl_impresora.Text = value; }
        }

        public Image Imagen_pr
        {
            get { return Pct_imagen_pr.Image; }
            set { Pct_imagen_pr.Image = value; }
        }

        public string Archivo_txt
        {
            get { return Lbl_archivo_txt.Text; }
            set { Lbl_archivo_txt.Text = value; }
        }
        #endregion
        public MiProducto()
        {
            InitializeComponent();
        }

        private void Pct_imagen_pr_Click(object sender, EventArgs e)
        {
            //StreamWriter Escribir = new StreamWriter(@"C:\\Users\\Public\\Documents\\"+ DateTime.Now.Ticks+".txt", true );

            StreamWriter Escribir = new StreamWriter(@"C:\Users\Public\Documents\"+Archivo_txt.Trim()+".txt", true);
            try
            {               
                Escribir.WriteLine("Descripcion_pr: " + Descripcion_pr);
                Escribir.WriteLine("Preciounitario_pr: " + Preciounitario_pr);                                         
                Escribir.WriteLine("Codigo_pr: " + Codigo_pr);
                Escribir.WriteLine("Impresora: " + Impresora);
                Escribir.WriteLine("\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            Escribir.Close();            

        }
    }
}
