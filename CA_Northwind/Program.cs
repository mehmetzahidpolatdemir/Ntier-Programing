using BLL.Service;
using DataAccess.DbFirst;
using System;

namespace CA_Northwind
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryService categoryService = new CategoryService();
            Category kategori = new Category();
            kategori.CategoryName = "Elektronik";
            kategori.Description = "Ateşli";
            categoryService.CategoryAdd(kategori);

            foreach (Category category in categoryService.CategoryList())
            {
                Console.WriteLine(category.CategoryName);
            }
            Console.Read();
        }
    }
}
