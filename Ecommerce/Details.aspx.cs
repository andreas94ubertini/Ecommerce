using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Ecommerce
{
    public partial class Details : System.Web.UI.Page
    {
        private static Product product;
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                int index = Convert.ToInt32(Request.QueryString["index"]);
                product = Product.GetProduct(index);
                productImage.ImageUrl = product.Image;
                writeDetails();
                alert.Visible = false;
            }

        }
        protected void writeDetails()
        {
            productName.InnerText = product.Name;
            description.InnerText = product.Description;
        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {
            int index = ShoppingCart.Cart.Count();
            Product Added = new Product(product.ProductId, product.Name, product.Description, product.Price, product.Image, index);
            ShoppingCart.addToCart(Added);
           
            alert.Visible = true;
        }
    }
}