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
    public class N_Mesas
    {
        public static DataTable Mostrar_me(string Valor)
        {
            D_Mesas Datos = new D_Mesas();
            return Datos.Mostrar_me(Valor);
        }

        public static string Guardar_me(int Nopcion, E_Mesas Omesas)
        {
            D_Mesas Datos = new D_Mesas();
            return Datos.Guardar_me(Nopcion, Omesas);
        }

        public static string Eliminar_me(int Ncodigo)
        {
            D_Mesas Datos = new D_Mesas();
            return Datos.Eliminar_me(Ncodigo);
        }

        public static string Verifica_duplicado_me(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Mesas Datos = new D_Mesas();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_me(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_fa"].ToString();
            }
            else
            {
                return "";
            }
        }

        public static DataTable Listar_pv(string Valor)
        {
            D_Mesas Datos = new D_Mesas();
            return Datos.Listar_pv(Valor);
        }
    }
}
