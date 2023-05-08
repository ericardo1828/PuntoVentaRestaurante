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
    public class D_RegistrarPedido
    {
        public DataTable Mostrar_tickets_mesa(int Ncodigo_me)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Mostrar_tickets_mesa", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ncodigo_me", SqlDbType.Int).Value = Ncodigo_me;
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

        public DataTable Mostrar_ticket(int Ncodigo_ti)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Mostrar_ticket", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ncodigo_ti", SqlDbType.Int).Value = Ncodigo_ti;
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

        public DataTable Mostrar_ticket_precuenta(DataTable Tickets_precuenta)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Mostrar_tickets_precuenta", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@DT_TP", SqlDbType.Structured).Value = Tickets_precuenta;
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

        public DataTable Mostrar_rp(int Ncodigo)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Usp_mostrar_rp", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ncodigo", SqlDbType.Int).Value = Ncodigo;
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

        public Byte[] Img_predeterminada(int Ncodigo)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            Byte[] Bimagen = new byte[0];
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_imagen_predeterminada", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ncodigo", SqlDbType.Int).Value = Ncodigo;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                Bimagen = (byte[])Tabla.Rows[0][0];
                return Bimagen;
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

        public DataTable Listar_SubFamilia_rp(int Ncodigo_pv)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listar_SubFamilias_RP", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ncodigo_pv", SqlDbType.Int).Value = Ncodigo_pv;
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

        public DataTable ListarProductos_SubFamilias(int Ncodigo_pv, int Ncodigo_sf)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_ListarProductos_SubFamilias", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ncodigo_pv", SqlDbType.Int).Value = Ncodigo_pv;
                Comando.Parameters.Add("@Ncodigo_sf", SqlDbType.Int).Value = Ncodigo_sf;
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

        public DataTable Guardar_rp(E_RegistrarPedido Oregistrarpedido, DataTable Detalle_ticket)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Guardar_Ticket", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;              
                Comando.Parameters.Add("@NCodigo_us", SqlDbType.Int).Value = Oregistrarpedido.Codigo_us;
                Comando.Parameters.Add("@Ncodigo_cl", SqlDbType.Int).Value = Oregistrarpedido.Codigo_cl;
                Comando.Parameters.Add("@CCliente", SqlDbType.VarChar).Value = Oregistrarpedido.Cliente;
                Comando.Parameters.Add("@Cnrodocumento_cl", SqlDbType.VarChar).Value = Oregistrarpedido.Nrodocumento_cl;
                Comando.Parameters.Add("@Dtotal_ti", SqlDbType.Decimal).Value = Oregistrarpedido.Total_ti;
                Comando.Parameters.Add("@Ncodigo_me", SqlDbType.Int).Value = Oregistrarpedido.Codigo_me;
                Comando.Parameters.Add("@Bcomanda_ti", SqlDbType.Bit).Value = Oregistrarpedido.Comanda_ti;
                Comando.Parameters.Add("@Ncodigo_tu", SqlDbType.Int).Value = Oregistrarpedido.Codigo_tu;

                //Comando.Parameters.Add("@Detalle", SqlDbType.Structured).Value = Detalle_ticket;

                var param = Comando.Parameters.AddWithValue("@Detalle", Detalle_ticket);
                param.SqlDbType = SqlDbType.Structured;
                param.TypeName = "dbo.Ty_Detalle_Ticket";

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

        public DataTable Imprimir_Comanda(string CImpresora, int Ncodigo_ti)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Imprimir_comanda", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Cimpresora", SqlDbType.VarChar).Value = CImpresora;
                Comando.Parameters.Add("@Ncodigo_ti", SqlDbType.Int).Value = Ncodigo_ti;
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

        public DataTable Imprimir_Comanda2(int Ncodigo_ti)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Imprimir_comanda2", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;               
                Comando.Parameters.Add("@Ncodigo_ti", SqlDbType.Int).Value = Ncodigo_ti;
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

        public DataTable Reimprimir_comanda(int Ncodigo_ti)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Reimprimir_comanda", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ncodigo_ti", SqlDbType.Int).Value = Ncodigo_ti;
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

        public DataTable Guardar_Division_Cuentas(int Ncodigo_us, int Ncodigo_cl,int Ncodigo_me, int Ncodigo_tu, DataTable Tickets_division_cuenta)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Guardar_Division_Cuentas", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@NCodigo_us", SqlDbType.Int).Value = Ncodigo_us;
                Comando.Parameters.Add("@Ncodigo_cl", SqlDbType.Int).Value = Ncodigo_cl;
                Comando.Parameters.Add("@Ncodigo_me", SqlDbType.Int).Value = Ncodigo_me;
                Comando.Parameters.Add("@Ncodigo_tu", SqlDbType.Int).Value = Ncodigo_tu;
                Comando.Parameters.Add("@TB_DC", SqlDbType.Structured).Value = Tickets_division_cuenta;

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

        public DataTable Guardar_Boleta(int Ncodigo_cl,
                                        string Ccliente,
                                        string Cnrodocumento_cl,
                                        string Cdireccion_cl,
                                        decimal Dtotal_bo,
                                        string Cnro_boleta,
                                        int Ncodigo_us,
                                        int Ncodigo_me,
                                        DataTable Dt_Boleta)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Guardar_Boleta", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ncodigo_cl", SqlDbType.Int).Value = Ncodigo_cl;
                Comando.Parameters.Add("@Ccliente", SqlDbType.VarChar).Value = Ccliente;
                Comando.Parameters.Add("@Cnrodocumento_cl", SqlDbType.VarChar).Value = Cnrodocumento_cl;
                Comando.Parameters.Add("@Cdireccion_cl", SqlDbType.VarChar).Value = Cdireccion_cl;
                Comando.Parameters.Add("@Ntotal_bo", SqlDbType.Decimal).Value = Dtotal_bo;
                Comando.Parameters.Add("@Cnro_boleta", SqlDbType.VarChar).Value = Cnro_boleta;
                Comando.Parameters.Add("@Ncodigo_us", SqlDbType.Int).Value = Ncodigo_us;
                Comando.Parameters.Add("@Ncodigo_me", SqlDbType.Int).Value = Ncodigo_me;
                Comando.Parameters.Add("@TD_BO", SqlDbType.Structured).Value = Dt_Boleta;
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

        public DataTable Guardar_Factura(int Ncodigo_cl,
                                       string Ccliente,
                                       string Cnrodocumento_cl,
                                       string Cdireccion_cl,
                                       decimal Dsubtotal_fa,
                                       decimal Digv_fa,
                                       decimal Dtotal_fa,
                                       string Cnro_factura,
                                       int Ncodigo_us,
                                       int Ncodigo_me,
                                       DataTable Dt_factura)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Guardar_Factura", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ncodigo_cl", SqlDbType.Int).Value = Ncodigo_cl;
                Comando.Parameters.Add("@Ccliente", SqlDbType.VarChar).Value = Ccliente;
                Comando.Parameters.Add("@Cnrodocumento_cl", SqlDbType.VarChar).Value = Cnrodocumento_cl;
                Comando.Parameters.Add("@Cdireccion_cl", SqlDbType.VarChar).Value = Cdireccion_cl;
                Comando.Parameters.Add("@Nsubtotal_fa", SqlDbType.Decimal).Value = Dsubtotal_fa;
                Comando.Parameters.Add("@Nigv_fa", SqlDbType.Decimal).Value = Digv_fa;
                Comando.Parameters.Add("@Ntotal_fa", SqlDbType.Decimal).Value = Dtotal_fa;
                Comando.Parameters.Add("@Cnro_factura", SqlDbType.VarChar).Value = Cnro_factura;
                Comando.Parameters.Add("@Ncodigo_us", SqlDbType.Int).Value = Ncodigo_us;
                Comando.Parameters.Add("@Ncodigo_me", SqlDbType.Int).Value = Ncodigo_me;
                Comando.Parameters.Add("@TD_FA", SqlDbType.Structured).Value = Dt_factura;
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

        public DataTable Listar_cl(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USp_Listar_cl", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ctexto", SqlDbType.VarChar).Value = Valor;
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

        public DataTable Listar_busqueda_pr(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Busquedarapida_pr", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ctexto", SqlDbType.VarChar).Value = Valor;
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

        public DataTable Listar_cl_bo_fa(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USp_Listar_cl_bo_fa", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ctexto", SqlDbType.VarChar).Value = Valor;
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

        public DataTable Estado_turno_pv(int Ncodigo_pv)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Usp_Estado_turno_pv", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ncodigo_pv", SqlDbType.Int).Value = Ncodigo_pv;
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

        public string Eliminar_ti(int Ncodigo_ti,int Ncodigo_me ,string Cobs)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Usp_eliminar_ti", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ncodigo_ti", SqlDbType.Int).Value = Ncodigo_ti;
                Comando.Parameters.Add("@Ncodigo_me", SqlDbType.Int).Value = Ncodigo_me;
                Comando.Parameters.Add("@Cobsanulado_ti", SqlDbType.Text).Value = Cobs;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() > 0 ? "OK" : "No se pudo anular el registro";
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
    }
}
