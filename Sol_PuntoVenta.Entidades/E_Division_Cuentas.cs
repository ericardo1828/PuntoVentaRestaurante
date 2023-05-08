using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_PuntoVenta.Entidades
{
   public class E_Division_Cuentas
    {
        public string Cuentas { get; set; }
        public string Descripcion_pr { get; set; }
        public decimal Preciounitario_ti { get; set; }
        public decimal Cantidad_ti { get; set; }
        public decimal Total_ti { get; set; }
        public string Observacion { get; set; }
        public int Codigo_ti { get; set; }
        public int Codigo_pr { get; set; }
        public string Impresora { get; set; }
    }
}
