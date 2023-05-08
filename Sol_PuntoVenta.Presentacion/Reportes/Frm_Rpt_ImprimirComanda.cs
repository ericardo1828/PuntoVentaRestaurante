using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_PuntoVenta.Presentacion.Reportes
{
    public partial class Frm_Rpt_ImprimirComanda : Form
    {
        public Frm_Rpt_ImprimirComanda()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_ImprimirComanda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_PuntoVenta.USP_Imprimir_comanda' Puede moverla o quitarla según sea necesario.
            this.USP_Imprimir_comandaTableAdapter.Fill(this.DS_PuntoVenta.USP_Imprimir_comanda, Cimpresora: Txt_p1.Text, Ncodigo_ti:Convert.ToInt32(Txt_p2.Text));

            this.reportViewer1.RefreshReport();
            this.reportViewer1.PrinterSettings.PrinterName = Txt_p1.Text;            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
