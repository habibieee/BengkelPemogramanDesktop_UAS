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
    /// Interaction logic for MenuMakanan.xaml
    /// </summary>
    public partial class MenuMakanan : Window
    {

        public string nama_menu = " ";
        public int harga = 0 ;

        public MenuMakanan()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu MenuMinuman = new Menu();
            MenuMinuman.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MenuPaket MenuPaket = new MenuPaket();
            MenuPaket.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            nama_menu = "Beef Sambal Korek";
            harga = 22272;
            this.Hide();
            MenuDetail menudetail = new MenuDetail(nama_menu, harga);
            menudetail.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            string menu = "Beef Sambal Korek";
            int harga = 22272;
            MessageBox.Show("Nama Menu : " + menu + "\n" + "Harga : Rp." + harga);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            string menu = "Chicken Leg";
            int harga = 20000;
            MessageBox.Show("Nama Menu : " + menu + "\n" + "Harga : Rp." + harga);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            string menu = "Steak Black Pepper";
            int harga = 39091;
            MessageBox.Show("Nama Menu : " + menu + "\n" + "Harga : Rp." + harga);
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            string menu = "Cordon Blue Cheese";
            int harga = 35455;
            MessageBox.Show("Nama Menu : " + menu + "\n" + "Harga : Rp." + harga);
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            string menu = "Chicken Rice";
            int harga = 15909;
            MessageBox.Show("Nama Menu : " + menu + "\n" + "Harga : Rp." + harga);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            nama_menu = "Chicken Leg";
            harga = 20000;
            this.Hide();
            MenuDetail menudetail = new MenuDetail(nama_menu, harga);
            menudetail.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            nama_menu = "Steak Black Pepper";
            harga = 39091;
            this.Hide();
            MenuDetail menudetail = new MenuDetail(nama_menu, harga);
            menudetail.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            nama_menu = "Cordon Blue Cheese";
            harga = 35455;
            this.Hide();
            MenuDetail menudetail = new MenuDetail(nama_menu, harga);
            menudetail.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            nama_menu = "Chicken Rice";
            harga = 15909;
            this.Hide();
            MenuDetail menudetail = new MenuDetail(nama_menu, harga);
            menudetail.Show();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
