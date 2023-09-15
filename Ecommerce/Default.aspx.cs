using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Default : System.Web.UI.Page
    {
        private static List<Product> products = new List<Product>();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (products.Count <= 0)
                {
                    products = Product.PopulateList();
                }
            }
            RepeaterCol.DataSource = products;
            RepeaterCol.DataBind();
        }
    }
}