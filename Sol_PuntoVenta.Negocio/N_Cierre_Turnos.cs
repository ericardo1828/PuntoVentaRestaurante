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
   public class N_Cierre_Turnos
    {
        public static DataTable Listar_PV_CierreTurno()
        {
            D_Cierre_turnos Datos = new D_Cierre_turnos();
            return Datos.Listar_PV_CierreTurno();
        }

        public static DataTable Estado_turno_pv2(int Ncodigo_pv)
        {
            D_Cierre_turnos Datos = new D_Cierre_turnos();
            return Datos.Estado_turno_pv2(Ncodigo_pv);
        }

        public static string Cerrar_turno(string Cfecha_ct, int Ncodigo_pv, int Ncodigo_tu)
        {
            D_Cierre_turnos Datos = new D_Cierre_turnos();
            return Datos.Cerrar_turno(Cfecha_ct,Ncodigo_pv,Ncodigo_tu);
        }

        public static string Abrir_turno(string Cfecha_ct, int Ncodigo_pv, int Ncodigo_tu)
        {
            D_Cierre_turnos Datos = new D_Cierre_turnos();
            return Datos.Abrir_turno(Cfecha_ct, Ncodigo_pv, Ncodigo_tu);
        }
    }
}
