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
    public class N_SubFamilias
    {
        public static DataTable Mostrar_sf(string Valor)
        {
            D_SubFamilias Datos = new D_SubFamilias();
            return Datos.Mostrar_sf(Valor);
        }

        public static string Guardar_sf(int Nopcion, E_SubFamilias Osubfamilias)
        {
            D_SubFamilias Datos = new D_SubFamilias();
            return Datos.Guardar_sf(Nopcion, Osubfamilias);
        }

        public static string Eliminar_sf(int Ncodigo)
        {
            D_SubFamilias Datos = new D_SubFamilias();
            return Datos.Eliminar_sf(Ncodigo);
        }

        public static string Verifica_duplicado_sf(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_SubFamilias Datos = new D_SubFamilias();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_sf(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_sf"].ToString();
            }
            else
            {
                return "";
            }
        }

        public static DataTable Listar_fa(string Valor)
        {
            D_SubFamilias Datos = new D_SubFamilias();
            return Datos.Listar_fa(Valor);
        }
    }
}
