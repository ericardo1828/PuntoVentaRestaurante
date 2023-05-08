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
    public class N_Cargos
    {
        public static DataTable Mostrar_cr(string Valor)
        {
            D_Cargos Datos = new D_Cargos();
            return Datos.Mostrar_cr(Valor);
        }

        public static string Guardar_cr(int Nopcion, E_Cargos oPro)
        {
            D_Cargos Datos = new D_Cargos();
            return Datos.Guardar_cr(Nopcion, oPro);
        }

        public static string Eliminar_cr(int Ncodigo)
        {
            D_Cargos Datos = new D_Cargos();
            return Datos.Eliminar_cr(Ncodigo);
        }

        public static string Verifica_duplicado_cr(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Cargos Datos = new D_Cargos();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_cr(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_cr"].ToString();
            }
            else
            {
                return "";
            }
        }

        public static DataTable Listar_ar(string Valor)
        {
            D_Cargos Datos = new D_Cargos();
            return Datos.Listar_ar(Valor);
        }
    }
}
