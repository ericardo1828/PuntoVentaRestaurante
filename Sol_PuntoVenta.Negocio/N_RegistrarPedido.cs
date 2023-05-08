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
    public class N_RegistrarPedido
    {
        public static DataTable Mostrar_tickets_mesa(int Ncodigo_me)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Mostrar_tickets_mesa(Ncodigo_me);
        }

        public static DataTable Mostrar_ticket(int Ncodigo_ti)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Mostrar_ticket(Ncodigo_ti);
        }

        public static DataTable Mostrar_ticket_precuenta(DataTable Tickets_precuenta)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Mostrar_ticket_precuenta(Tickets_precuenta);
        }

        public static DataTable Guardar_Division_Cuentas(int Ncodigo_us, int Ncodigo_cl, int Ncodigo_me, int Ncodigo_tu, DataTable Tickets_division_cuenta)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Guardar_Division_Cuentas(Ncodigo_us,Ncodigo_cl,Ncodigo_me,Ncodigo_tu,Tickets_division_cuenta);
        }

        public static DataTable Guardar_Boleta(int Ncodigo_cl,
                                        string Ccliente,
                                        string Cnrodocumento_cl,
                                        string Cdireccion_cl,
                                        decimal Dtotal_bo,
                                        string Cnro_boleta,
                                        int Ncodigo_us,
                                        int Ncodigo_me,
                                        DataTable Dt_Boleta)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Guardar_Boleta(Ncodigo_cl,
                                        Ccliente,
                                        Cnrodocumento_cl,
                                        Cdireccion_cl,
                                        Dtotal_bo,
                                        Cnro_boleta,
                                        Ncodigo_us,
                                        Ncodigo_me,
                                        Dt_Boleta);
        }

        public static DataTable Guardar_Factura(int Ncodigo_cl,
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
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Guardar_Factura(Ncodigo_cl,
                                        Ccliente,
                                        Cnrodocumento_cl,
                                        Cdireccion_cl,
                                        Dsubtotal_fa,
                                        Digv_fa,
                                        Dtotal_fa,
                                        Cnro_factura,
                                        Ncodigo_us,
                                        Ncodigo_me,
                                        Dt_factura);
        }

        public static DataTable Mostrar_rp(int Ncodigo)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Mostrar_rp(Ncodigo);
        }

        public static Byte[] Img_predeterminada(int Ncodigo)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Img_predeterminada(Ncodigo);
        }

        public static DataTable Listar_SubFamilia_rp(int Ncodigo_pv)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Listar_SubFamilia_rp(Ncodigo_pv);
        }

        public static DataTable ListarProductos_SubFamilias(int Ncodigo_pv, int Ncodigo_sf)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.ListarProductos_SubFamilias(Ncodigo_pv, Ncodigo_sf);
        }

        public static DataTable Guardar_rp(E_RegistrarPedido Oregistrarpedido, DataTable Detalle_ticket)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Guardar_rp(Oregistrarpedido, Detalle_ticket);
        }

        public static DataTable Imprimir_Comanda(string CImpresora, int Ncodigo_ti)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Imprimir_Comanda(CImpresora, Ncodigo_ti);
        }

        public static DataTable Imprimir_Comanda2(int Ncodigo_ti)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Imprimir_Comanda2(Ncodigo_ti);
        }

        public static DataTable Reimprimir_comanda(int Ncodigo_ti)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Reimprimir_comanda(Ncodigo_ti);
        }

        public static DataTable Listar_cl(string Valor)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Listar_cl(Valor);
        }

        public static DataTable Listar_busqueda_pr(string Valor)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Listar_busqueda_pr(Valor);
        }

        public static DataTable Listar_cl_bo_fa(string Valor)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Listar_cl_bo_fa(Valor);
        }

        public static DataTable Estado_turno_pv(int Ncodigo_pv)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Estado_turno_pv(Ncodigo_pv);
        }

        public static string Eliminar_ti(int Ncodigo_ti,int Ncodigo_me, string Cobs)
        {
            D_RegistrarPedido Datos = new D_RegistrarPedido();
            return Datos.Eliminar_ti(Ncodigo_ti,Ncodigo_me, Cobs);
        }
    }
}
