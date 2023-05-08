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
namespace Sol_PuntoVenta.Presentacion.Controles
{
    public partial class Frm_ActualizarPasswordUsuario : Form
    {
        public Frm_ActualizarPasswordUsuario()
        {
            InitializeComponent();
        }

        private void Btn_actualizar_ahora_Click(object sender, EventArgs e)
        {
            if (Txt_password_us.Text != string.Empty)
            {
                string Rpta = "";
                int Ccodigo_us =Convert.ToInt32(Txt_codigo_us.Text);
                string Cpassword = Txt_password_us.Text.Trim();

                Rpta = N_login.Restablecer_clave_us2(Ccodigo_us, Cpassword);
                if (Rpta.Equals("OK"))
                {
                  MessageBox.Show("Nueva contraseña registrada correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  this.Close();

                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("La nueva contraseña no es idéntica", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
