using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LIBNEGOCIO;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("<h2><b>Numero de Pedidos " +
                        Session["idpedidos"].ToString());
        GridView1.DataSource = ClsAplicacion1.ProductosVendidosporPedidos(
                                Session["idpedidos"].ToString());
        GridView1.DataBind();
    }
}