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

        public DataTable ObtenerUnidadNegocio()
        {
            try
            {
                SqlCommand com = new SqlCommand("spSelectSitemas", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al Obtener Sistemas: " + ex.Message);
            }
        }

        public DataTable ObtenerTableroGestion()
        {
            try
            {
                SqlCommand com = new SqlCommand("spSelectTableroQuejaGestoria", con);
                com.CommandType = CommandType.StoredProcedure;
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
