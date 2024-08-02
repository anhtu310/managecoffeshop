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
    /// Interaction logic for DetailProduct.xaml
    /// </summary>
    public partial class DetailProduct : Window
    {
        private ProductService productService;
        public DetailProduct(Product product)
        {
            InitializeComponent();
            productService = new ProductService();
            this.DataContext = product;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = int.Parse(this.txt_id.Text);
                int category = (int)this.cb_category.SelectedValue;
                var name = this.txt_title.Text;
                var price = this.txt_price.Text;
                var decription = this.txt_description.Text;
                Product product = new Product();
                product.Id = id;
                product.Thumbnail = "";
                product.Title = name;
                product.Description = decription;
                product.Price = int.Parse(price);
                product.Status = this.txt_status.Text;
                product.IdCat = category;
                productService.Update(product);

                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            ManageProduct product = new ManageProduct();
            product.Show();
        }
    }
}
