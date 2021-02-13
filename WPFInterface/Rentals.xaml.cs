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
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace WPFInterface
{
    /// <summary>
    /// Interaction logic for Rentals.xaml
    /// </summary>
    public partial class Rentals : Window
    {
        RentalManager _rentalManager = new RentalManager(new EfRentalDal());
        public Rentals()
        {
            InitializeComponent();
            LoadRentals();
        }

        private void LoadRentals()
        {
            var result = _rentalManager.GetDetailedRentals();
            RentalDataGrid.ItemsSource = result.Data;
        }
    }
}
