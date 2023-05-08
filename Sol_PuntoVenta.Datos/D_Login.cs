using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_PuntoVenta.Entidades;

namespace Sol_PuntoVenta.Datos
{
   public class D_Login
    {
        public DataTable Acceder_us(string Cemail_us, string Cpassword_us)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Login", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;                
                Comando.Parameters.Add("@Cemail_us", SqlDbType.VarChar).Value = Cemail_us;
                Comando.Parameters.Add("@Cpassword_us", SqlDbType.VarChar).Value = Cpassword_us;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string recoverPassword(string Cemail, string Ccodigo_verificacion)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_RecuperarClaveUsuario", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;               
                Comando.Parameters.Add("@Cemail_us", SqlDbType.VarChar).Value = Cemail;                
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                if (Tabla.Rows.Count > 0)
                {
                    string Vusuario = Convert.ToString(Tabla.Rows[0][2]);
                    string Vemail = Convert.ToString(Tabla.Rows[0][3]);

                    var Vclave = Ccodigo_verificacion;
                    var mailService = new  MailServer.SystemSupportMail();

                    mailService.sendMail(
                      subject: "Sistema de Punto de Venta V2: Solicitud de recuperación de contraseña",
                      body: "Hola, " + Vusuario + "\nSolicitó recuperar su contraseña.\n" +
                      "Su código de verificación es: " + Vclave +
                      "\nsin embargo, le pedimos que cambie su contraseña inmediatamente y luego ingrese al sistema.",
                      recipientMail: new List<string> { Vemail }
                      );
                    return "Hola, " + Vusuario + "\n solicitó recuperar su contraseña. \n" +
                      "Por favor revise su correo electrónico: " + Vemail +
                      "\nsin embargo, le pedimos que cambie su contraseña inmediatamente y luego ingrese al sistema.";
                }
                else
                {
                    return "Lo sentimos, no tiene una cuenta con ese correo electrónico o nombre de usuario.";
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }      
        }

        public string Restablecer_clave_us(string Cemail, string CPassword)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Usp_restablecer_Password_us", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Cemail_us", SqlDbType.VarChar).Value = Cemail;
                Comando.Parameters.Add("@Cclave_us", SqlDbType.VarChar).Value = CPassword;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualiza la contraseña del usuario";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Restablecer_clave_us2(int Ccodigo_us, string CPassword)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Usp_restablecer_Password_us2", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ccodigo_us", SqlDbType.Int).Value = Ccodigo_us;
                Comando.Parameters.Add("@Cclave_us", SqlDbType.VarChar).Value = CPassword;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualiza la contraseña del usuario";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public DataTable Usuario_Admin(int Ncodigo_us)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Usuario_Admin", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;               
                Comando.Parameters.Add("@Ccodigo_us", SqlDbType.VarChar).Value = Ncodigo_us;
                
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}
