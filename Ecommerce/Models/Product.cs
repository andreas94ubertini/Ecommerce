using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public int CartIndex { get; set; }
        public static List<Product> Products = new List<Product>();
        public Product() { }
        public Product(int productID, string name, string description, double price, string image)
        {
            ProductId = productID;
            Name = name;
            Description = description;
            Price = price;
            Image = image;
        }
        public Product(int productID, string name, string description, double price, string image, int cartid)
        {
            ProductId = productID;
            Name = name;
            Description = description;
            Price = price;
            Image = image;
            CartIndex = cartid;
        }
        public static List<Product> PopulateList()
        {
            Product[] pdr = {

                new Product(0,"Iphone 14", "Apple Iphone 14 pro 120gb nero", 1200, "~/Content/img/iphone.png"),
                new Product(1,"Samsung S23", "Nuovo Samsung Galaxy S23 foto mai viste prima", 989, "~/Content/img/galaxy.png"),
                new Product(2,"Nokia 3310", "Un telefono...Indistruttibile", 180, "~/Content/img/nokia.png"),
                new Product(3,"Huawei Mate 5", "Non ti sta spiando proprio nessuno...", 700, "~/Content/img/Huawei.png"),
                new Product(4,"Motorola Razr", "Super sottile", 1000, "~/Content/img/razr.png"),
                new Product(5,"Xiaomi Mi Mix Fold", "Doppio schermo", 1300, "~/Content/img/fold.png"),
            };
            Products.AddRange(pdr);
            return Products;
        }

        public static Product GetProduct(int Id)
        {
            return Products[Id];
        }
        
    }
}