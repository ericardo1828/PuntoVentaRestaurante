using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sol_PuntoVenta.Datos
{
   public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "BD_MIPUNTOVENTA";
            this.Servidor = "DESKTOP-4DM1QKB\\SQLEXPRESS";            
            this.Usuario = "sa";
            this.Clave = "123";
            this.Seguridad = false;
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                if (Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id=" + this.Usuario + "; Password=" + this.Clave;
                }
            }
            catch (Exception ex)
            {

               Cadena = null;
               throw ex;
            }
            return Cadena;
        }
        public static Conexion getInstancia()
        {
            if (Con== null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
