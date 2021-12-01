using BLL.Service;
using DataAccess.DbFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Northwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CategoryService categoryService = new CategoryService();
            Category kategori = new Category();
            
            kategori.CategoryID = 9;
            categoryService.CategoryRemove(kategori);


            foreach (Category category in categoryService.CategoryList())
            {
                listBox1.Items.Add(category.CategoryName);
            }


          


        
        }
    }
}
