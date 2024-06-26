﻿using ClassLibRentStrumentTeam05.Data.Framework;
using ClassLibTeam05.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace WpfATeam05
{
    /// <summary>
    /// Interaction logic for SqlWindow.xaml
    /// </summary>
    public partial class SqlWindow : Window
    {
        public SqlWindow()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, RoutedEventArgs e)
        {
            GetConnection();
        }

        private SqlConnection GetConnection()
        {
            SqlConnection conn;
            try
            {
                string connectionString = "user id = sa;";
                connectionString += "password=pxl;";
                connectionString += $@"server={TxtServer.Text};";
                connectionString += $"Database={TxtDb.Text}";
                conn = new SqlConnection(connectionString);
                conn.Open();
                conn.Close();
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            
        }
        private void BtnGetData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string cmd = $"Select * from {TxtTable.Text}";
                SqlCommand sql = new SqlCommand(cmd, GetConnection());
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DgdSql.ItemsSource = dt.DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
