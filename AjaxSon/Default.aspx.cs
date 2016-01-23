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
        List<EntUnidadNegocio> lst = new BusPrincipal().ObtenerUnidadNegocio();
        JavaScriptSerializer oSerializer = new JavaScriptSerializer();
        string sJSON = oSerializer.Serialize(lst);
        return sJSON;
    }
}