using Ecommerce.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class YourCart : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            GridView1.DataSource = ShoppingCart.Cart;
            GridView1.DataBind();
            if (ShoppingCart.Cart.Count > 0)
            {
                total.InnerHtml = $"<div class='alert alert-success text-center' role='alert'>Totale da pagare: {String.Format("{0:0.00 €}", ShoppingCart.GetTotal())}</div>";
                   
            }
            else
            {
                message.InnerHtml = $"<div class='alert alert-warning text-center' role='alert'>Nessun prodotto attualmente nel carrello</div>";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
{
    ShoppingCart.Cart.Clear();
    Response.Redirect("YourCart.aspx");

}

protected void DeleteFrom_Command(object sender, CommandEventArgs e)
{
    int index = Convert.ToInt32(e.CommandArgument.ToString());
    ShoppingCart.removeOne(index);
    Response.Redirect("YourCart.aspx");

}
    }
}