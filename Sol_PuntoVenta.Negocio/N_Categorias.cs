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
    public class N_Categorias
    {
        public static DataTable Mostrar_ca(string Valor)
        {
            D_Categorias Datos = new D_Categorias();
            return Datos.Mostrar_ca(Valor);
        }

        public static string Guardar_ca(int Nopcion, E_Categorias Ocategorias)
        {
            D_Categorias Datos = new D_Categorias();
            return Datos.Guardar_ca(Nopcion, Ocategorias);
        }

        public static string Eliminar_ca(int Ncodigo)
        {
            D_Categorias Datos = new D_Categorias();
            return Datos.Eliminar_ca(Ncodigo);
        }

        public static string Verifica_duplicado_ca(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Categorias Datos = new D_Categorias();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_ca(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_ca"].ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
