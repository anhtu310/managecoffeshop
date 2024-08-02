using ManageCoffee.Models;
using ManageCoffee.Services;
using ManageCoffee.View.Dialog;
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

namespace ManageCoffee.View
{
    /// <summary>
    /// Interaction logic for ManageCategory.xaml
    /// </summary>
    public partial class ManageCategory : Window
    {
        private CategoryService _categoryService;
        public ManageCategory()
        {
            InitializeComponent();
            _categoryService = new CategoryService();
            this.DataContext = _categoryService.GetAll();
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            this.Close();
            AddCategory category = new AddCategory();
            category.Show();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Close();
            if (e.AddedItems.Count > 0)
            {
                var selected = e.AddedItems[0] as Category;

                if (selected != null)
                {
                    var dialog = new DetailCategory(selected);
                    if (dialog.ShowDialog() == true)
                    {
                        // Handle OK result, if needed
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string txt_search = this.txt_search.Text;
            if (txt_search.Length > 0)
            {
                this.DataContext = _categoryService.GetByName(txt_search);

            }
            else {
                this.DataContext = _categoryService.GetAll();
            }
        }
    }
}
