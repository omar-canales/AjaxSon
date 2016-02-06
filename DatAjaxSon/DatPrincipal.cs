using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jorsh.AjaxSon.Data
{
   public class DatPrincipal : DatAbstracta
    {
        public DataTable Obtener()
        {
            try
            {
                SqlCommand com = new SqlCommand("GetQuejas", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt; 
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al Obtener Quejas: " + ex.Message);
            }
        }

        public DataSet ObtenerUnidadNegocio()
        {
            try
            {
                SqlCommand com = new SqlCommand("spSelectSitemasYEstados", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al Obtener Sistemas: " + ex.Message);
            }
        }

        public DataTable ObtenerTableroGestion(DateTime fechaInicial, DateTime fechaFinal, string queja, int unidadNegocio, int tiposervicio, int ejecuticoSAC, string numServicio, int cliente, int etapa, bool definicion, int estado, int municipio)
        {
            try
            {
                SqlCommand com = new SqlCommand("spSelectTableroQuejaGestoria", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.DateTime, Value = fechaInicial, ParameterName = "@FechaInicial" });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.DateTime, Value = fechaFinal, ParameterName = "@FechaFinal" });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, Value = queja, ParameterName = "@Queja" });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, Value = unidadNegocio, ParameterName = "@UnidadNegocio" });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, Value = tiposervicio, ParameterName = "@TipoServicio" });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, Value = ejecuticoSAC, ParameterName = "@EjecutivoSAC" });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, Value = numServicio, ParameterName = "@NoServicio" });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, Value = cliente, ParameterName = "@Cliente" });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, Value = etapa, ParameterName = "@Etapa" });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Bit, Value = definicion, ParameterName = "@Definicion" });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, Value = estado, ParameterName = "@Estado" });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, Value = municipio, ParameterName = "@Municipio" });
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return (dt);
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error al Obtener Tablero Gestion: " + ex.Message);
            }
        }
    }
}
