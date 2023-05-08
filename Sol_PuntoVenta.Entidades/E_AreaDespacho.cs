using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_PuntoVenta.Entidades
{
    public class E_AreaDespacho
    {
        public int Codigo_ad { get; set; }
        public  string Descripcion_ad { get; set; }
        public int Codigo_pv { get; set; }
        public string Impresora { get; set; }
        public bool Estado { get; set; }
    }
}
