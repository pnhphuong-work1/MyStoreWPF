using BusinessObjects.DTOs;
using Services.Abstractions;
using Services.Services;
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

namespace Presentation
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private readonly IProductService _iProductService;

        public ProductWindow()
        {
            InitializeComponent();
            _iProductService = new ProductService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var productList = _iProductService.GetAllProducts();
            var productViewList = new List<ProductDTO>();
            foreach( var product in productList )
            {
                productViewList.Add(new ProductDTO
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    CategoryId = product.CategoryId,
                    UnitsInStock = product.UnitsInStock,
                    UnitPrice = product.UnitPrice,
                    CategoryName = product.Category.CategoryName
                });
            }
            dgData.ItemsSource = productViewList;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
