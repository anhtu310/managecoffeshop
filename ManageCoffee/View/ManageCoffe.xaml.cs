using ManageCoffee.DTO;
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
    /// Interaction logic for ManageCoffe.xaml
    /// </summary>
    public partial class ManageCoffe : Window
    {
        private ProductService productService;
       // private List<OrderDTO> orderDTOs = new List<OrderDTO>();
        private List<OrderDTO> _orderDTOs;
        public ManageCoffe(List<OrderDTO> orderDTOs)
        {
            InitializeComponent();
            productService = new ProductService();
            var products = productService.GetAll();
            _orderDTOs = orderDTOs;
            list_product.DataContext = products;
            if (orderDTOs.Count > 0) { 
                select_grid.DataContext = _orderDTOs;
             }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Close();
            if (e.AddedItems.Count > 0)
            {
                var selectedProduct = e.AddedItems[0] as Product;
                if (selectedProduct != null)
                {
                    var dialog = new AddDialog(_orderDTOs, selectedProduct);
                    if (dialog.ShowDialog() == true)
                    {
                        // Handle OK result, if needed
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuManage menuManage = new MenuManage();
            menuManage.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var products = productService.GetByIdCategory(1);
            list_product.DataContext = products;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var products = productService.GetByIdCategory(2);
            list_product.DataContext = products;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var products = productService.GetAll();
            list_product.DataContext = products;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (_orderDTOs.Count > 0)
            {
                float total = 0;
                foreach (OrderDTO item in _orderDTOs)
                {
                    var money = productService.GetById(item.Id).Price * item.soluong;
                    total += (float)money;
                }
              this.txt_total.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào được chọn");
               
            }
            
        }
    }
}
