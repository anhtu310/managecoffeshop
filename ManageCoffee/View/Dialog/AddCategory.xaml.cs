using ManageCoffee.Models;
using ManageCoffee.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ManageCoffee.View.Dialog
{
    /// <summary>
    /// Interaction logic for AddCategory.xaml
    /// </summary>
    public partial class AddCategory : Window
    {
        private CategoryService categoryService;
        public AddCategory()
        {
            InitializeComponent();
            categoryService = new CategoryService();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = this.txt_name.Text;
                Category category = new Category();
                category.Name = name;
                categoryService.Add(category);
                MessageBox.Show("thêm mới thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("thêm mới thất bại");
            }
            

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            ManageCategory category = new ManageCategory();
            category.Show();
        }
    }
}
