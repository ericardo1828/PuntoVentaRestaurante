using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Sol_PuntoVenta.Presentacion.Configuraciones;

namespace Sol_PuntoVenta.Presentacion
{
    public partial class Frm_MiDashBoard : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;       
        //Constructor
        public Frm_MiDashBoard()
        {
            InitializeComponent();
            customizeDesing();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 46);
            Pnl_menu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;            
        }
        #region "Mis Variables"
            internal int iCodigo_us { get; set; }
            internal int iCodigo_ru { get; set; }

        #endregion

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight; 
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblTitleChildForm.Text = currentBtn.Text;
                lblTitleChildForm.ForeColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(250, 130,49);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(24, 161, 251);
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
           
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Black;
            lblTitleChildForm.Text = "Home";
        }

        private void customizeDesing()
        {
            Pnl_procesos.Visible = false;
            Pnl_reportes.Visible = false;
            Pnl_datosmaestros.Visible = false;
            Pnl_configuracion.Visible = false;
        }

        private void hideSubMenu()
        {
            if (Pnl_procesos.Visible == true)
                Pnl_procesos.Visible = false;
            if (Pnl_reportes.Visible == true)
                Pnl_reportes.Visible = false;
            if (Pnl_datosmaestros.Visible == true)
                Pnl_datosmaestros.Visible = false;
            if (Pnl_configuracion.Visible == true)
                Pnl_configuracion.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Pnl_escritorio.Controls.Add(childForm);
            Pnl_escritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void openChildForm_aux()
        {
            if (activeForm != null)
                activeForm.Close();
            Frm_RegistrarPedidos Ofrm_registrarpedidos = new Frm_RegistrarPedidos();
            Ofrm_registrarpedidos.Codigo_us = iCodigo_us;
            Ofrm_registrarpedidos.TopLevel = false;
            Ofrm_registrarpedidos.FormBorderStyle = FormBorderStyle.None;
            Ofrm_registrarpedidos.Dock = DockStyle.Fill;
            Pnl_escritorio.Controls.Add(Ofrm_registrarpedidos);
            Pnl_escritorio.Tag = Ofrm_registrarpedidos;
            Ofrm_registrarpedidos.BringToFront();
            Ofrm_registrarpedidos.Show();
            
        }

        private void Btn_procesos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            showSubMenu(Pnl_procesos);
        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            showSubMenu(Pnl_reportes);
        }

        private void Btn_datosmaestros_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            showSubMenu(Pnl_datosmaestros);
        }

        private void DM_puntoventa_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_PuntoVenta());
            //hideSubMenu();
        }

        private void DM_areadespacho_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_AreaDespacho());
            //hideSubMenu();
        }

        private void DM_categorias_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Categorias());
           //hideSubMenu();
        }

        private void DM_familias_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Familias());
            //hideSubMenu();
        }

        private void DM_subfamilias_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_SubFamilias());
            //hideSubMenu();
        }

        private void Btn_dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            customizeDesing();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            
            Reset();
            customizeDesing();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Pnl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DM_mesas_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Mesas());
            //hideSubMenu();
        }

        private void PR_BoletasFacturas_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Consultas_Boletas_Facturas());
            //hideSubMenu();
        }

        private void PR_registrar_pedido_Click(object sender, EventArgs e)
        {
            //openChildForm(new Frm_RegistrarPedidos());
            openChildForm_aux(); // este método es especial para pasar el dato del código del usuario.
            //hideSubMenu();
        }

        private void Btn_cerrarsesion_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Deseas cerrar sesión el Sistema?", "Sistema de Punto de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void DM_productos_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Productos());
            //hideSubMenu();
        }

        private void PR_cierreturno_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Cierre_Turnos());
            //hideSubMenu();
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Reporte_Tickets_PV());
            //hideSubMenu();
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Reporte_Tickets_PV_anulados());
            //hideSubMenu();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Reporte_Boletas_Fecha());
            //hideSubMenu();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {            
            openChildForm(new Frm_Reporte_Facturas_Fecha());
            //hideSubMenu();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Reporte_Personalizados());
            //hideSubMenu();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_hora.Text = DateTime.Now.ToLongTimeString();
            Lbl_Fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var VFrm_AP = new Controles.Frm_ActualizarPasswordUsuario();
            VFrm_AP.Txt_codigo_us.Text = iCodigo_us.ToString();
            VFrm_AP.Txt_nombres_us.Text =Lbl_nombre_us.Text;
            VFrm_AP.Txt_password_us.Text = "";
            VFrm_AP.Txt_password_us.Select();
            VFrm_AP.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var VFrm_AP = new Controles.Frm_ActualizarPasswordUsuario();
            VFrm_AP.Txt_codigo_us.Text = iCodigo_us.ToString();
            VFrm_AP.Txt_nombres_us.Text = Lbl_nombre_us.Text;
            VFrm_AP.Txt_password_us.Text = "";
            VFrm_AP.Txt_password_us.Select();
            VFrm_AP.ShowDialog();
        }

        private void CO_Imagenes_pred_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Imagenes_Predeterminadas());
            //hideSubMenu();
        }

        private void Btn_configuracion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            showSubMenu(Pnl_configuracion);
        }

        private void CO_usuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Usuarios());
            //hideSubMenu();
        }

        private void CO_areas_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Areas());
            //hideSubMenu();
        }

        private void CO_cargos_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Cargos());
            //hideSubMenu();
        }
    }
}
