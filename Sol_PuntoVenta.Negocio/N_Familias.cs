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
    public class N_Familias
    {
        public static DataTable Mostrar_fa(string Valor)
        {
            D_Familias Datos = new D_Familias();
            return Datos.Mostrar_fa(Valor);
        }

        public static string Guardar_fa(int Nopcion, E_Familias Ofamilias)
        {
            D_Familias Datos = new D_Familias();
            return Datos.Guardar_fa(Nopcion, Ofamilias);
        }

        public static string Eliminar_fa(int Ncodigo)
        {
            D_Familias Datos = new D_Familias();
            return Datos.Eliminar_fa(Ncodigo);
        }

        public static string Verifica_duplicado_fa(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Familias Datos = new D_Familias();
            DataTable Tabla = new DataTable();
            Tabla= Datos.Verifica_duplicado_fa(Nopcion,Ncodigo,Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_fa"].ToString();
            }
            else
            {
                return "";
            }
        }

        public static DataTable Listar_ca(string Valor)
        {
            D_Familias Datos = new D_Familias();
            return Datos.Listar_ca(Valor);
        }
    }
}
