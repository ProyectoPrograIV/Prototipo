using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Reflection;

namespace AD.ADSolicitudViaticos
{
    public class Cls_Solicitud_AD
    {
        public static Boolean GuardarSolicitud(TBL_SOLICITUDVIATICOS Obj_Solicitud)
        {
            EmpresaPK2Entities Entidad = null;
            try
            {
                Entidad = new EmpresaPK2Entities();
                Entidad.SP_GUARDAR_SOLICITUDES_FUNCIONARIO(Obj_Solicitud.NOMBREUSUARIO, Obj_Solicitud.FECHACREACION, Obj_Solicitud.FECHASALIDA, Obj_Solicitud.FECHAREGRESO,
                    Obj_Solicitud.JUSTIFICACION, Obj_Solicitud.DESTINO, Obj_Solicitud.HORAREGRESO, Obj_Solicitud.HORASALIDA);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                if(Entidad != null)
                {
                    Entidad.Dispose();
                }
            }
        }
        public static DataTable ListarSolicitudes(TBL_SOLICITUDVIATICOS Obj_Solicitud)
        {
            DataTable Solicitudes = new DataTable();
            EmpresaPK2Entities Entidad = null;
            try
            {
                Entidad = new EmpresaPK2Entities();
                Solicitudes = LINQToDataTable(Entidad.SP_LISTAR_SOLICITUDES_FUNCIONARIO(Obj_Solicitud.NOMBREUSUARIO));
                return Solicitudes;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        private static DataTable LINQToDataTable<T>(IEnumerable<T> varlist)
        {
            DataTable dtReturn = new DataTable();


            // column names
            PropertyInfo[] oProps = null;


            if (varlist == null) return dtReturn;


            foreach (T rec in varlist)
            {
                // Use reflection to get property names, to create table, Only first time, others will follow
                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    foreach (PropertyInfo pi in oProps)
                    {
                        Type colType = pi.PropertyType;


                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }


                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }


                DataRow dr = dtReturn.NewRow();


                foreach (PropertyInfo pi in oProps)
                {
                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue
                    (rec, null);
                }


                dtReturn.Rows.Add(dr);
            }
            return dtReturn;
        }
    }
}
