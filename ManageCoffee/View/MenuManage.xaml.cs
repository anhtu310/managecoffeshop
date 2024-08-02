using ManageCoffee.DTO;
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
    /// Interaction logic for MenuManage.xaml
    /// </summary>
    public partial class MenuManage : Window
    {
       
        public MenuManage()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<OrderDTO> orderDTOs = new List<OrderDTO>();
            ManageCoffe manageCoffe = new ManageCoffe(orderDTOs);
            manageCoffe.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ManageProduct manageProduct = new ManageProduct();
            manageProduct.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ManageCategory manageCategory = new ManageCategory();
            manageCategory.Show();
        }
    }
}
