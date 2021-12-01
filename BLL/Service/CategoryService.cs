using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DbFirst;

namespace BLL.Service
{
    public class CategoryService
    {

        NorthwindEntities db = new NorthwindEntities();

        //Kategorilerin Listenmesi
        public List<Category> CategoryList()
        {
            return db.Categories.ToList();
        }


        //Kategori eklenmesi

        public string CategoryAdd(Category category)

        {
            db.Categories.Add(category);
            db.SaveChanges();
            return "Başarılı bir şekilde eklendi.";
            
        }

        //Kategori silinmesi
        public string CategoryRemove(Category category)
        {
            Category Delete = db.Categories.Find(category.CategoryID);

            db.Categories.Remove(Delete);

            db.SaveChanges();
            return "Başarılı bir şekilde silindi.";
          
        }

        //Kategori güncellenmesi
       
        public string CategoryUpdate(Category category)
        {
            Category Update = db.Categories.Find(category.CategoryID);

            Update.CategoryName = category.CategoryName;

            db.SaveChanges();

            return "Başarılı bir şekilde güncellendi.";
        }
    }
}
