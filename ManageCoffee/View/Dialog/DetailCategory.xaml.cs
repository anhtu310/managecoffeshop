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
    /// Interaction logic for DetailCategory.xaml
    /// </summary>
    public partial class DetailCategory : Window
    {
        private CategoryService categoryService;
        public DetailCategory(Category category)
        {
            InitializeComponent();
            categoryService = new CategoryService();   
            this.DataContext = category;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = int.Parse(this.txt_id.Text);
                string name = this.txt_name.Text;
                Category category = new Category();
                category.Id = id;
                category.Name = name;
                categoryService.Update(category);
                MessageBox.Show("Cập nhật thành công");
            } catch (Exception ex) {
                MessageBox.Show("Cập nhật thất bại");
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
