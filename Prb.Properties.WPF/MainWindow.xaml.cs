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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Prb.Properties.CORE;

namespace Prb.Properties.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Car> cars;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cars = new List<Car>();
        }

        private void lstCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstCars.SelectedItem == null) return;

            Car car = (Car)lstCars.SelectedItem;

            txtCarBrand.Text = car.brand;
            txtColor.Text = car.color;
            txtPrice.Text = car.price.ToString();
        }
        private void UpdateCarListbox()
        {
            lstCars.Items.Clear();
            foreach (Car car in cars)
            {
                lstCars.Items.Add(car);
            }
        }
        private void btnAddCar_Click(object sender, RoutedEventArgs e)
        {
            string carColor = txtColor.Text;
            string carBrand = txtCarBrand.Text;
            decimal carPrice = Convert.ToDecimal(txtPrice.Text);

            Car newCar = new Car();
            newCar.color = carColor;
            newCar.brand = carBrand;
            newCar.price = carPrice;

            // OF via constructor:
            //Car newCar = new Car(carBrand, carColor, carPrice);

            cars.Add(newCar);
            UpdateCarListbox();
        }
    }
}
