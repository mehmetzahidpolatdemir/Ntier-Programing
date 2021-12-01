using DataAccess.DbFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
   public class ProductService
    {
        NorthwindEntities db = new NorthwindEntities();

        //Kategorilerin Listenmesi
        public List<Product> ProductList()
        {
            return db.Products.ToList();
        }


        //Kategori eklenmesi

        public string ProductAdd(Product product)

        {
            db.Products.Add(product);
            return "Başarılı bir şekilde eklendi.";
        }

        //Kategori silinmesi
        public string ProductRemove(Product product)
        {
            db.Products.Remove(product);

            return "Başarılı bir şekilde silindi.";
        }

        //Kategori güncellenmesi

        public string ProductUpdate(Product product)
        {
            Product Update = db.Products.Find(product.ProductID);

            Update.ProductName = product.ProductName;

            db.SaveChanges();

            return "Başarılı bir şekilde güncellendi.";
        }

    }
}
