﻿using System;
using System.Collections.Generic;
using System.Data;
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
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete;
using Entites.DTOs;

namespace WPFInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CarManager _carManager = new CarManager(new EfCarDal());
        BrandManager _brandManager = new BrandManager(new EfBrandDal());
        ColorManager _colorManager = new ColorManager(new EfColorDal());
        Car _car;

        private List<Car> _cars;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCars();
            ListBrand();
            ListColors();

        }

        private void LoadCars()
        {
            //_cars = _carManager.GetAll();
            //DataGridCars.ItemsSource = _cars;
            DataGridCars.ItemsSource = _carManager.GetCarDetails();
        }

        private void DataGridCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(DataGridCars.SelectedIndex.ToString());
            //var car2 = DataGridCars.SelectedItem as Car;
            //MessageBox.Show(car2.Id.ToString());

            //_car = DataGridCars.SelectedItem as Car;
            //int AlinanId = _car.Id;
            //MessageBox.Show(AlinanId.ToString());

            //DataRowView dw = (DataRowView)DataGridCars.SelectedItem;
            //int deneme2 = (int) dw.Row[0];
            //MessageBox.Show(deneme2.ToString());

            //CbxBrand.Text =  selectedItem.BrandId.ToString();
            //var br = _brandManager.GetById(selectedItem.BrandId);
            //CbxBrand.Text = br.BrandName;
            //var clr = _colorManager.GetById(selectedItem.ColorId);
            //CbxColor.Text = clr.ColorName;
            var _selectedDto = (CarDetailDto)DataGridCars.SelectedItem;
            if (_selectedDto != null)
            {
                try
                {
                    TxtCarId.Text = _selectedDto.CarId.ToString();
                    CbxColor.Text = _selectedDto.ColorName;
                    CbxBrand.Text = _selectedDto.BrandName;
                    TxtDailyPrice.Text = _selectedDto.DailyPrice.ToString();
                    TxtModelYear.Text = _selectedDto.ModelYear;
                    TxtDescription.Text = _selectedDto.Description;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message + " " + exception.InnerException);
                }
            }

        }

        void ListBrand()
        {
            try
            {
                CbxBrand.ItemsSource = _brandManager.GetAll();
                CbxBrand.DisplayMemberPath = "BrandName";
                CbxBrand.SelectedValuePath = "Id";

                CbxFilterType.ItemsSource = _brandManager.GetAll();
                CbxFilterType.DisplayMemberPath = "BrandName";
                CbxFilterType.SelectedValuePath = "Id";

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + " " + exception.InnerException);
            }
        }

        void ListColors()
        {
            try
            {
                CbxColor.ItemsSource = _colorManager.GetAll();
                CbxColor.DisplayMemberPath = "ColorName";
                CbxColor.SelectedValuePath = "Id";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + " " + exception.InnerException);
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddCar();
        }

        private void AddCar()
        {
            _carManager.Add(new Car
            {
                BrandId = Convert.ToInt32(CbxBrand.SelectedValue),
                ColorId = Convert.ToInt32(CbxColor.SelectedValue),
                ModelYear = TxtModelYear.Text,
                DailyPrice = Convert.ToDecimal(TxtDailyPrice.Text),
                Description = TxtDescription.Text
            });
            LoadCars();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //var _selectedDto2 = (CarDetailDto)DataGridCars.SelectedItem;
            _carManager.Update(new Car
            {
                Id = Convert.ToInt32(TxtCarId.Text),
                //Id = _selectedDto2.CarId,
                BrandId = Convert.ToInt32(CbxBrand.SelectedValue),
                ColorId = Convert.ToInt32(CbxColor.SelectedValue),
                ModelYear = TxtModelYear.Text,
                DailyPrice = Convert.ToDecimal(TxtDailyPrice.Text),
                Description = TxtDescription.Text
            });
            LoadCars();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCarId.Text))
            {
                _carManager.Delete(new Car
                {
                    Id = Convert.ToInt32(TxtCarId.Text),
                    //Id = _selectedDto2.CarId,
                    BrandId = Convert.ToInt32(CbxBrand.SelectedValue),
                    ColorId = Convert.ToInt32(CbxColor.SelectedValue),
                    ModelYear = TxtModelYear.Text,
                    DailyPrice = Convert.ToDecimal(TxtDailyPrice.Text),
                    Description = TxtDescription.Text
                });
                LoadCars();
            }
        }
    }
}
