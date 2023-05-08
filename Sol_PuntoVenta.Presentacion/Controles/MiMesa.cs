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
using Sol_PuntoVenta.Negocio;
namespace Sol_PuntoVenta.Presentacion.Controles
{
    public partial class MiMesa : UserControl
    {
        #region "Variables y Propiedades"
        public int Codigo
        {
            get { return Convert.ToInt32(Lbl_codigo_me.Text); }
            set { Lbl_codigo_me.Text =Convert.ToString(value); }
        } 

        public string Descripcion
        {
            get { return Lbl_descripcion_me.Text;}
            set { Lbl_descripcion_me.Text = value; }
        }

        public Image Disponible
        {
            get { return Pct_estado.Image; }
            set { Pct_estado.Image = value; }
        }

        public int Codigo_pv
        {
            get { return Convert.ToInt32(Lbl_codigo_pv.Text); }
            set { Lbl_codigo_pv.Text = Convert.ToString(value); }
        }

        public string Descripcion_pv
        {
            get { return Lbl_descripcion_pv.Text; }
            set { Lbl_descripcion_pv.Text = value; }
        }

        public int Codigo_us
        {
            get { return Convert.ToInt32(Lbl_codigo_us.Text); }
            set { Lbl_codigo_us.Text = Convert.ToString(value); }
        }
        public int Codigo_tu
        {
            get { return Convert.ToInt32(Lbl_codigo_tu.Text); }
            set { Lbl_codigo_tu.Text = Convert.ToString(value); }
        }

        #endregion
        #region "Mis Métodos"

        #endregion
        public MiMesa()
        {
            InitializeComponent();          

        }       

        private void Pct_imagenmesa_Click(object sender, EventArgs e)
        {

            
           Frm_MesaAbierta OFrm = new Frm_MesaAbierta();
            OFrm.Lbl_descripcion_me.Text = Descripcion;
            OFrm.Lbl_codigo_me.Text =Convert.ToString(Codigo);
            OFrm.Lbl_descripcion_pv.Text = Descripcion_pv;
            OFrm.Lbl_codigo_pv.Text = Convert.ToString(Codigo_pv);
            OFrm.Lbl_archivo_txt.Text =Convert.ToString(DateTime.Now.Ticks);
            OFrm.Lbl_codigo_us.Text = Convert.ToString(Codigo_us);
            OFrm.Lbl_codigo_tu.Text = Convert.ToString(Codigo_tu);
            //Cargamos los Datos al Grid de SubFamilia
            try
            {
                OFrm.Dgv_Listado_pr.DataSource = N_RegistrarPedido.Listar_SubFamilia_rp(Codigo_pv);
                //Dando Formato a la Grid de SubFamilia
                OFrm.Dgv_Listado_pr.Columns[0].Width = 250;
                OFrm.Dgv_Listado_pr.Columns[0].HeaderText = "SUBFAMILIAS";
                OFrm.Dgv_Listado_pr.Columns[1].Visible = false;
                /////////////////////////////////////
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            /////////////////////////////////////////

            OFrm.ShowDialog();
        }

        private void Pnl_mesa_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
