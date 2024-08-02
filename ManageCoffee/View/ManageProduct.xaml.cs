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
    /// Interaction logic for ManageProduct.xaml
    /// </summary>
    public partial class ManageProduct : Window
    {
        private ProductService service;
        private CategoryService categoryService;
        public ManageProduct()
        {
            InitializeComponent();

            service = new ProductService();
            categoryService = new CategoryService();
            var product = service.GetAll();
            this.DataContext = product;
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            this.Close();
            var Category = categoryService.GetAll();

            AddProduct addProduct = new AddProduct();
            Category.ForEach(e =>
            {
                addProduct.cb_category.Items.Add(e);
            });

            addProduct.Show();

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Close();
            if (e.AddedItems.Count > 0)
            {
                var selectedProduct = e.AddedItems[0] as Product;
                
                if (selectedProduct != null)
                {
                    var dialog = new DetailProduct(selectedProduct);
                    int id_cate = selectedProduct.IdCat.Value;
                    Category category = categoryService.GetById(id_cate);
                    dialog.cb_category.ItemsSource = categoryService.GetAll();
                    int select_id = category.Id;
                    dialog.cb_category.SelectedValue = select_id;
                    if (dialog.ShowDialog() == true)
                    {
                        // Handle OK result, if needed
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string txt_search = this.txt_product_search.Text;
            if (txt_search.Length > 0)
            {
                var product = service.GetByTitle(txt_search);
                this.DataContext = product;
            }
            else
            {
                var product = service.GetAll();
                this.DataContext = product;
            }
        }
    }
}
