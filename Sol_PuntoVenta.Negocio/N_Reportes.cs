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
    public class N_Reportes
    {
        public static DataTable Listar_PuntoVenta()
        {
            D_Reportes Datos = new D_Reportes();
            return Datos.Listar_PuntoVenta();
        }

        public static DataTable Mostrar_PV()
        {
            D_Reportes Datos = new D_Reportes();
            return Datos.Mostrar_PV();
        }
    }
}
