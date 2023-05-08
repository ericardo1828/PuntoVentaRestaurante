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
   public class N_AreaDespacho
    {
        public static DataTable Mostrar_ad(string Valor)
        {
            D_AreaDespacho Datos = new D_AreaDespacho();
            return Datos.Mostrar_ad(Valor);
        }

        public static string Guardar_ad(int Nopcion, E_AreaDespacho Oareadespacho)
        {
            D_AreaDespacho Datos = new D_AreaDespacho();
            return Datos.Guardar_ad(Nopcion, Oareadespacho);
        }

        public static string Eliminar_ad(int Ncodigo)
        {
            D_AreaDespacho Datos = new D_AreaDespacho();
            return Datos.Eliminar_ad(Ncodigo);
        }

        public static string Verifica_duplicado_ad(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_AreaDespacho Datos = new D_AreaDespacho();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_ad(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_ad"].ToString();
            }
            else
            {
                return "";
            }
        }

        public static DataTable Listar_pv(string Valor)
        {
            D_AreaDespacho Datos = new D_AreaDespacho();
            return Datos.Listar_pv(Valor);
        }
    }
}
