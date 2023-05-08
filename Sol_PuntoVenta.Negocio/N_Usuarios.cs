using Sol_PuntoVenta.Datos;
using Sol_PuntoVenta.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_PuntoVenta.Negocio
{
    public class N_Usuarios
    {
        public static DataTable Listado_us(string cTexto)
        {
            D_Usuarios Datos = new D_Usuarios();
            return Datos.Listado_us(cTexto);
        }

        public static DataTable Cargar_Cargos()
        {
            D_Usuarios Datos = new D_Usuarios();
            return Datos.Cargar_Cargos();
        }

        public static DataTable Cargar_RolesUsuarios()
        {
            D_Usuarios Datos = new D_Usuarios();
            return Datos.Cargar_RolesUsuarios();
        }

        public static string Verifica_duplicado_us(int Nopcion, int Ncodigo, string cEmail_us)
        {
            D_Usuarios Datos = new D_Usuarios();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_us(Nopcion, Ncodigo, cEmail_us);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_us"].ToString();
            }
            else
            {
                return "";
            }
        }

        public static string Guardar_us(int nOpcion, E_Usuarios oUs)
        {
            D_Usuarios Datos = new D_Usuarios();
            return Datos.Guardar_us(nOpcion, oUs);
        }

        public static string Eliminar_us(int nCodigo_us)
        {
            D_Usuarios Datos = new D_Usuarios();
            return Datos.Eliminar_us(nCodigo_us);
        }
    }
}
