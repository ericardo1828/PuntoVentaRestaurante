using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Sol_PuntoVenta.Entidades
{
    public class E_Productos
    {
        public int Codigo_pr { get; set; }
        public string Descripcion_pr { get; set; }
        public decimal Medida_pr { get; set; }
        public int Codigo_um { get; set; }
        public decimal Preciounitario_pr { get; set; }
        public int Codigo_sf { get; set; }
        public string Observacion_pr { get; set; }
        public int Codigo_ad { get; set; }
        public byte[] Imagen_pr { get; set; }
        public bool Estado { get; set; }       
    }
}
