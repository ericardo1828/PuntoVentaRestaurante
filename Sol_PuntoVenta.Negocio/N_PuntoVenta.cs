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
    public class N_PuntoVenta
    {
        public static DataTable Mostrar_pv(string Valor)
        {
            D_PuntoVenta Datos = new D_PuntoVenta();
            return Datos.Mostrar_pv(Valor);
        }

        public static string Guardar_pv(int Nopcion, E_PuntoVenta Opuntoventa)
        {
            D_PuntoVenta Datos = new D_PuntoVenta();
            return Datos.Guardar_pv(Nopcion, Opuntoventa);
        }

        public static string Eliminar_pv(int Ncodigo)
        {
            D_PuntoVenta Datos = new D_PuntoVenta();
            return Datos.Eliminar_pv(Ncodigo);
        }

        public static string Verifica_duplicado_pv(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_PuntoVenta Datos = new D_PuntoVenta();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_pv(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_pv"].ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
