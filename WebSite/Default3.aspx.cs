using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LIBNEGOCIO;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = ClsAplicacion1.DatosdelEmpleados(
                   Convert.ToString(Session["idempleados"]));
        GridView1.DataBind();
    }
}