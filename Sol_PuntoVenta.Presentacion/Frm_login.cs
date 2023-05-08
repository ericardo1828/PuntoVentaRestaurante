using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Sol_PuntoVenta.Negocio;
using Sol_PuntoVenta.Entidades;
using System.IO;

namespace Sol_PuntoVenta.Presentacion
{
    public partial class Frm_login : Form
    {
        #region "Métodos"
        private void Acceder_us(string Cemail_us, string Cpassword_us)
        {
            try
            {             
                
                DataTable Tablatemp = new DataTable();
                Tablatemp =  N_login.Acceder_us(Cemail_us, Cpassword_us);
                if (Tablatemp.Rows.Count > 0)
                {                    
                  
                    Frm_MiDashBoard Omidashboard = new Frm_MiDashBoard();
                    Omidashboard.iCodigo_us = Convert.ToInt32(Tablatemp.Rows[0][0]);
                    Omidashboard.Lbl_nombre_us.Text = Convert.ToString(Tablatemp.Rows[0][2]);
                    Omidashboard.Lbl_descripcion_cr.Text = Convert.ToString(Tablatemp.Rows[0][3]);
                    Omidashboard.iCodigo_ru = Convert.ToInt32(Tablatemp.Rows[0][4]);

                    if (Omidashboard.iCodigo_ru == 1) // Administrador del Negocio
                    {
                        Omidashboard.Btn_dashboard.Enabled = true;
                        Omidashboard.Btn_procesos.Enabled = true;
                        Omidashboard.Btn_reportes.Enabled = true;
                        Omidashboard.Btn_datosmaestros.Enabled = true;
                        Omidashboard.Btn_configuracion.Enabled = true;
                    }
                    if (Omidashboard.iCodigo_ru == 2) // Usuarios
                    {
                        Omidashboard.Btn_dashboard.Enabled = false;
                        Omidashboard.Btn_procesos.Enabled = true;
                        Omidashboard.Btn_reportes.Enabled = true;
                        Omidashboard.Btn_datosmaestros.Enabled = false;
                        Omidashboard.Btn_configuracion.Enabled = false;
                    }

                    Omidashboard.Show();
                    Omidashboard.FormClosed += Logout;
                    this.Hide();   
                }
                else
                {
                    MessageBox.Show("Usuario y/o Clave son incorrecto ... verifique", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        #endregion
        public Frm_login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Pct_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pct_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            this.Txt_email_us.Select();
        }

        private void Frm_login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_acceder_Click(object sender, EventArgs e)
        {
            this.Acceder_us(Txt_email_us.Text.Trim(), Txt_password_us.Text.Trim());
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            Txt_email_us.Text="";
            Txt_password_us.Text="";
            this.Show();
            Txt_email_us.Select();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var VFrm_RP = new Frm_Recuperar_Password();
            VFrm_RP.ShowDialog();
        }

        private void Txt_password_us_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.Acceder_us(Txt_email_us.Text.Trim(), Txt_password_us.Text.Trim());
            }
        }

        private void Txt_email_us_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.Acceder_us(Txt_email_us.Text.Trim(), Txt_password_us.Text.Trim());
            }
        }
    }
}
