using ManageCoffee.DTO;
using ManageCoffee.Models;
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
    /// Interaction logic for AddDialog.xaml
    /// </summary>
    public partial class AddDialog : Window
    {
        private List<OrderDTO> _orderDTOs;
        public AddDialog( List<OrderDTO> orderDTOs, Product product)
        {
            InitializeComponent();
            this.DataContext = product;
            _orderDTOs = orderDTOs;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            OrderDTO order = new OrderDTO();
            order.Id = int.Parse(this.txt_id.Text);
            order.Name = this.txt_name.Text;
            order.soluong = int.Parse(this.number_quantity.Text);
            _orderDTOs.Add(order);
            
            this.DialogResult = true;
            this.Close();
            ManageCoffe manage = new ManageCoffe(_orderDTOs);
            manage.Show();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
