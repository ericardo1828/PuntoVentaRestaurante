using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_PuntoVenta.Entidades
{
   public class E_Detalle_Factura
    {
        public int Codigo_pr { get; set; }
        public decimal Preciounitario_pr { get; set; }
        public decimal Cantidad_fa { get; set; }
        public decimal Total_fa { get; set; }
        public int Codigo_ti { get; set; }
    }
}
