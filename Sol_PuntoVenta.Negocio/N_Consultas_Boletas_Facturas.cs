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
    public class N_Consultas_Boletas_Facturas
    {
        public static DataTable Listar_bo(string Valor)
        {
            D_Consultas_Boletas_Facturas Datos = new D_Consultas_Boletas_Facturas();
            return Datos.Listar_bo(Valor);
        }

        public static DataTable Listar_fa(string Valor)
        {
            D_Consultas_Boletas_Facturas Datos = new D_Consultas_Boletas_Facturas();
            return Datos.Listar_fa(Valor);
        }
    }
}
