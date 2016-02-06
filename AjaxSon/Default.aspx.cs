using Jorsh.AjaxSon.Business;
using Jorsh.AjaxSon.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    [WebMethod]
    public static string ObtenerUnidadNegocio()
    {
        List<EntUnidadNegocio> lst = new BusQueja().ObtenerUnidadNegocio();
        JavaScriptSerializer oSerializer = new JavaScriptSerializer();
        string sJSON = oSerializer.Serialize(lst);
        return sJSON;
    }

    [WebMethod]
    public static string ObtenerTableroGestion(string fechaInicial, string FechaFinal, string Queja, string UnidadNegocio, string TipoServicio, string EjecutivoSAC, string NoServicio, string Cliente, string Etapa, string Definicion, string Estado, string Municipio)
    {
        EntTableroGestionQueja ent = new EntTableroGestionQueja();
        ent.FechaInicial = Convert.ToDateTime(fechaInicial);
        ent.FechaFinal = Convert.ToDateTime(FechaFinal);
        ent.Sistema = UnidadNegocio;
        List<EntQueja> lst = new BusQueja().ObtenerTableroGestion(ent);
        JavaScriptSerializer oSerializer = new JavaScriptSerializer();
        string sJSON = oSerializer.Serialize(lst);
        return sJSON;
    }
}