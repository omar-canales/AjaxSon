using Jorsh.AjaxSon.Business.Entity;
using Jorsh.AjaxSon.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jorsh.AjaxSon.Business
{
    public class BusQueja
    {
        public BusQueja() { }
        public List<EntQueja> Obtener()
        {
            DataTable dt = new DatPrincipal().Obtener();
            List<EntQueja> lst = new List<EntQueja>();
            foreach (DataRow dr in dt.Rows)
            {
                EntQueja ent = new EntQueja();
                ent.Id = Convert.ToInt32(dr["QUEJA_ID"]);
                ent.Anio = Convert.ToInt32(dr["QUEJA_ANIO"]);
                ent.Prefijo = dr["QUEJA_PREFIJO"].ToString();
                ent.Numero = Convert.ToInt32(dr["QUEJA_NUMERO"]);
                ent.Reporte = dr["QUEJA_REPORTE"].ToString();
                ent.ViaActivacionId = Convert.ToInt32(dr["QUEJA_VIA_ACTIVACION_ID"]);
                ent.ResponsableId = dr["QUEJA_RESPONSABLE_ID"] is DBNull ? 0 : Convert.ToInt32(dr["QUEJA_RESPONSABLE_ID"]);
                ent.Descripcion = dr["QUEJA_DESCRIPCION"].ToString();
                ent.EstatusSeguimiento = Convert.ToBoolean(dr["QUEJA_ESTATUS_SEGUIMIENTO"]);
                ent.UnidadNegocioId = Convert.ToInt32(dr["QUEJA_UNIDAD_NEGOCIO_ID"]);
                ent.NumeroServicio = dr["QUEJA_NUMERO_SERVICIO"].ToString();
                ent.EjecutivoSACId = dr["QUEJA_EJECUTIVO_SAC_ID"] is DBNull ? 0 : Convert.ToInt32(dr["QUEJA_EJECUTIVO_SAC_ID"]);
                ent.Definicion = dr["QUEJA_DEFINICION"] is DBNull ? false : Convert.ToBoolean(dr["QUEJA_DEFINICION"]);
                ent.FechaAlta = Convert.ToDateTime(dr["QUEJA_FECHA_ALTA"]);
                ent.Procedente = Convert.ToBoolean(dr["QUEJA_PROCEDENTE"]);
                ent.EnvioCorreo = Convert.ToBoolean(dr["QUEJA_ENVIO_CORREO"]);
                ent.UsuarioId = dr["QUEJA_USUARIO_ID"] is DBNull ? 0 : Convert.ToInt32(dr["QUEJA_USUARIO_ID"]);
                lst.Add(ent);
            }
            return lst;
        }
        public List<EntUnidadNegocio> ObtenerUnidadNegocio()
        {
            DataTable dt = new DatPrincipal().ObtenerUnidadNegocio();
            List<EntUnidadNegocio> lst = new List<EntUnidadNegocio>();
            foreach (DataRow dr in dt.Rows)
            {
                EntUnidadNegocio ent = new EntUnidadNegocio();
                ent.Id = Convert.ToInt32(dr["SIST_ID"]);
                ent.Nombre = dr["SIST_NOMBRE"].ToString();
                ent.Descripcion = dr["SIST_DESCRIPCION"].ToString();
                ent.Prefijo = dr["SIST_PREFIJO"].ToString();
                lst.Add(ent);
            }
            return lst;
        }

        public List<EntQueja> ObtenerTableroGestion()
        {
            DataTable dt = new DatPrincipal().ObtenerTableroGestion();
            List<EntQueja> lst = new List<EntQueja>();
            foreach (DataRow dr in dt.Rows)
            {
                EntQueja ent = new EntQueja();
                ent.Id = Convert.ToInt32(dr["QUEJA_ID"]);
                ent.Anio = Convert.ToInt32(dr["QUEJA_ANIO"]);
                ent.Prefijo = dr["QUEJA_PREFIJO"].ToString();
                ent.Numero = Convert.ToInt32(dr["QUEJA_NUMERO"]);
                ent.Reporte = dr["QUEJA_REPORTE"].ToString();
                ent.ViaActivacionId = Convert.ToInt32(dr["QUEJA_VIA_ACTIVACION_ID"]);
                ent.ResponsableId = dr["QUEJA_RESPONSABLE_ID"] is DBNull ? 0 : Convert.ToInt32(dr["QUEJA_RESPONSABLE_ID"]);
                ent.Descripcion = dr["QUEJA_DESCRIPCION"].ToString();
                ent.EstatusSeguimiento = Convert.ToBoolean(dr["QUEJA_ESTATUS_SEGUIMIENTO"]);
                ent.UnidadNegocioId = Convert.ToInt32(dr["QUEJA_UNIDAD_NEGOCIO_ID"]);
                ent.NumeroServicio = dr["QUEJA_NUMERO_SERVICIO"].ToString();
                ent.EjecutivoSACId = dr["QUEJA_EJECUTIVO_SAC_ID"] is DBNull ? 0 : Convert.ToInt32(dr["QUEJA_EJECUTIVO_SAC_ID"]);
                ent.Definicion = Convert.ToBoolean(dr["QUEJA_DEFINICION"]);
                ent.FechaAlta = Convert.ToDateTime(dr["QUEJA_FECHA_ALTA"]);
                ent.Procedente = Convert.ToBoolean(dr["QUEJA_PROCEDENTE"]);
                ent.EnvioCorreo = Convert.ToBoolean(dr["QUEJA_ENVIO_CORREO"]);
                ent.UsuarioId = Convert.ToInt32(dr["QUEJA_USUARIO_ID"]);
                lst.Add(ent);
            }
            return lst;
        }
    }
}
