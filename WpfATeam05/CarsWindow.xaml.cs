using ClassLibRentStrumentTeam05.Data.Framework;
using ClassLibTeam05.Business;
using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfATeam05
{
    public partial class CarsWindow : Window
    {
        public CarsWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DgdCar.ItemsSource = null;
            DgdCar.ItemsSource = Cars.List();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            StackNewCar.Visibility = Visibility.Hidden;
        }

        private void BtnNewCar_Click(object sender, RoutedEventArgs e)
        {
            StackNewCar.Visibility = Visibility.Visible;
        }

        private void BtnAddCar_Click(object sender, RoutedEventArgs e)
        {
            if (TxtMake.Text.Length > 0 && TxtModel.Text.Length > 0 && TxtYear.Text.Length > 0 && TxtPrice.Text.Length > 0)
            {
                if (int.TryParse(TxtYear.Text, out int year) && decimal.TryParse(TxtPrice.Text, out decimal price))
                {
                    Cars.Add(TxtMake.Text, TxtModel.Text, year, price);
                    LoadData();
                    StackNewCar.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("Incorrect year or price format!");
                }
            }
            else
            {
                MessageBox.Show("Incomplete data!");
            }
        }

        private void MnuNewCar_Click(object sender, RoutedEventArgs e)
        {
            StackNewCar.Visibility = Visibility.Visible;
        }

        private void BtnInsert_Click(object sender, RoutedEventArgs e)
        {
            InsertResult result = Cars.Add(TxtFirst.Text, TxtLast.Text);
        }
    }
}
