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
    public partial class Frm_Recuperar_Password : Form
    {
        #region "Mis Variables"
        string Ccodigo_verificacion = "";
        #endregion
        public Frm_Recuperar_Password()
        {
            InitializeComponent();
        }

        private void Btn_enviar_Click(object sender, EventArgs e)
        {
            string NumAleatorio = Convert.ToString(DateTime.Now.Ticks);
            Ccodigo_verificacion = NumAleatorio;
            var Resultado = N_login.recoverPassword(Txt_email.Text.Trim(), NumAleatorio);
            Lbl_mensaje.Text = Resultado;
        }

        private void Btn_verificar_Click(object sender, EventArgs e)
        {
            if(Txt_codigo_verificacion.Text == Ccodigo_verificacion && Txt_codigo_verificacion.Text != string.Empty){
                MessageBox.Show("Código de verificación correcta, genere su nueva contraseña", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_nuevaclave1.Enabled = true;
                Txt_nuevaclave2.Enabled = true;
                Txt_nuevaclave1.Text = "";
                Txt_nuevaclave2.Text = "";
                Btn_actualizar_ahora.Enabled = true;
                Txt_nuevaclave1.Select();
            }
            else
            {
                Txt_nuevaclave1.Enabled = false;
                Txt_nuevaclave2.Enabled = false;
                Txt_nuevaclave1.Text = "";
                Txt_nuevaclave2.Text = "";
                Btn_actualizar_ahora.Enabled = false;
                MessageBox.Show("Código de verificación incorrecta, Consulte con el Administrador del Sistema", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void Btn_actualizar_ahora_Click(object sender, EventArgs e)
        {
            if (Txt_nuevaclave1.Text.Trim() == Txt_nuevaclave2.Text.Trim() && Txt_nuevaclave1.Text != string.Empty && Txt_nuevaclave2.Text != string.Empty)
            {
                string Rpta = "";
                string Cemail = Txt_email.Text.Trim();
                string Cpassword = Txt_nuevaclave1.Text.Trim();

                Rpta = N_login.Restablecer_clave_us(Cemail, Cpassword);
                if (Rpta.Equals("OK"))
                {
                    Txt_nuevaclave1.Text = "";
                    Txt_nuevaclave2.Text = "";
                    Btn_actualizar_ahora.Enabled = false;
                    Txt_nuevaclave1.Enabled = false;
                    Txt_nuevaclave2.Enabled = false;
                    MessageBox.Show("Nueva contraseña registrada correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
