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
    public class N_Productos
    {
        public static DataTable Listado_pr(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listado_pr(cTexto);
        }
        public static DataTable Mostrar_pr(string Valor)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Mostrar_pr(Valor);
        }

        public static string Guardar_pr(int Nopcion, E_Productos Oproductos, DataTable PD_PV)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Guardar_pr(Nopcion, Oproductos, PD_PV);
        }

        public static string Eliminar_pr(int Ncodigo)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Eliminar_pr(Ncodigo);
        }

        public static string Verifica_duplicado_pr(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Productos Datos = new D_Productos();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_pr(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_pr"].ToString();
            }
            else
            {
                return "";
            }
        }

        public static DataTable Listar_um(string Valor)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listar_um(Valor);
        }

        public static DataTable Listar_sf(string Valor)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listar_sf(Valor);
        }

        public static DataTable Listar_ad(string Valor)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listar_ad(Valor);
        }

        public static DataTable Mostrar_PV(int Nopcion, int Ncodigo)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Mostrar_PV(Nopcion,Ncodigo);
        }

        public static Byte[] Mostrar_img(int Ncodigo)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Mostrar_img(Ncodigo);
        }

        public static Byte[] Mostrar_img_pred()
        {
            D_Productos Datos = new D_Productos();
            return Datos.Mostrar_img_pred();
        }
    }
}
