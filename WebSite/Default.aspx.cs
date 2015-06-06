using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LIBNEGOCIO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DataList1.DataSource = ClsAplicacion1.ListarPedidos();
            DataList1.DataBind();
        }
    }
    //Llamando a los linkbuttons dentro del datalist
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {   //e.CommandName =>recuperando el numero asociado en el LinkButton
        int numero = Convert.ToInt16(e.CommandName); //"1"
        switch (numero)
        {
            case 1: //control LinkButton1 - Consulta1
                {   //recuperar los numeros de pedidos seleccionados
                    string idpedidos = string.Empty;
                    //recorriendo el control datalist item por item
                    for (int i = 0; i < DataList1.Items.Count; i++)
                    {//recuperando el CheckBox dentro del Item
                        CheckBox chk = DataList1.Items[i].
                             FindControl("CheckBox1") as CheckBox;
                        if (chk.Checked)
                        {
                            idpedidos += (DataList1.Items[i].
                             FindControl("Label1") as Label).Text + ",";
                        }                        
                    }

                    if (idpedidos == "")
                    {
                        Response.Write("<h2><b>" +
                                    "Seleccione al Menos un Pedido");
                    }
                    else
                    {  
                        Session["idpedidos"] = idpedidos.
                                            Remove(idpedidos.Length-1);
                        Response.RedirectPermanent("Default2.aspx");
                    }
                    break;
                }
            case 2: //control LinkButton1 - Consulta2
                {   //recuperar los numeros de empleados seleccionados
                    string idempleados = string.Empty;
                    for (int i = 0; i < DataList1.Items.Count; i++)
                    {
                        CheckBox chk = DataList1.Items[i].
                           FindControl("CheckBox1") as CheckBox;
                        if (chk.Checked)
                        {
                            //Label id = DataList1.Items[i].
                            //    FindControl("Label3") as Label;
                            //idempleados += id.Text + ",";

                            idempleados += (DataList1.Items[i].
                             FindControl("Label3") as Label).Text + ",";
                        }
                    }
                    if (idempleados == "")
                    {
                        Response.Write("<h2><b>Seleccione al Menos " +
                            " un Empleado");
                    }
                    else
                    {
                        Session["idempleados"] = idempleados.Remove(
                                idempleados.Length - 1);
                        Response.RedirectPermanent("Default3.aspx");
                    }                    
                    break;
                }
        }       
    }
}