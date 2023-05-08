using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_PuntoVenta.Entidades;
using Sol_PuntoVenta.Datos;

namespace Sol_PuntoVenta.Negocio
{
    public class N_Imagenes_Predeterminadas
    {
        public static DataTable Listado_img_pred(string Valor)
        {
            D_Imagenes_Predeterminadas Datos = new D_Imagenes_Predeterminadas();
            return Datos.Listado_img_pred(Valor);
        }

        public static Byte[] Mostrar_img_pred(int nCodigo_im)
        {
            D_Imagenes_Predeterminadas Datos = new D_Imagenes_Predeterminadas();
            return Datos.Mostrar_img_pred(nCodigo_im);
        }

        public static string Guardar_img_pred(int nOpcion, E_Imagenes_Predeterminadas oImg_pred)
        {
            D_Imagenes_Predeterminadas Datos = new D_Imagenes_Predeterminadas();
            return Datos.Guardar_img_pred(nOpcion, oImg_pred);
        }       
    }
}
