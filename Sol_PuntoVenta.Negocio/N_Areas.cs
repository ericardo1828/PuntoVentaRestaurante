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
    public class N_Areas
    {
        public static DataTable Mostrar_ar(string Valor)
        {
            D_Areas Datos = new D_Areas();
            return Datos.Mostrar_ar(Valor);
        }

        public static string Guardar_ar(int Nopcion, E_Areas oPro)
        {
            D_Areas Datos = new D_Areas();
            return Datos.Guardar_ar(Nopcion, oPro);
        }

        public static string Eliminar_ar(int Ncodigo)
        {
            D_Areas Datos = new D_Areas();
            return Datos.Eliminar_ar(Ncodigo);
        }

        public static string Verifica_duplicado_ar(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Areas Datos = new D_Areas();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_ar(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_ar"].ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
