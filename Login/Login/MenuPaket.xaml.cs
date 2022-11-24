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

namespace Login
{
    /// <summary>
    /// Interaction logic for MenuPaket.xaml
    /// </summary>
    public partial class MenuPaket : Window
    {
        public string nama_menu = " ";
        public int harga = 0;
        public MenuPaket()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu MenuMinuman = new Menu();
            MenuMinuman.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            nama_menu = "Paket Chicko";
            harga = 20455;
            this.Hide();
            MenuDetail menudetail = new MenuDetail(nama_menu, harga);
            menudetail.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            nama_menu = "Paket Sirlo";
            harga = 22273;
            this.Hide();
            MenuDetail menudetail = new MenuDetail(nama_menu, harga);
            menudetail.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string menu = "Paket Sirlo";
            int harga = 22273;
            MessageBox.Show("Nama Menu : " + menu + "\n" + "Harga : Rp." + harga);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            string menu = "Paket Chicko";
            int harga = 20455;
            MessageBox.Show("Nama Menu : " + menu + "\n" + "Harga : Rp." + harga);
    }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
