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

namespace Login
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public string nama_menu = " ";
        public int harga = 0;
        public Menu()
        {
            InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MenuMakanan MenuMakanan = new MenuMakanan();
            MenuMakanan.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MenuPaket MenuPaket = new MenuPaket();
            MenuPaket.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MenuPaket MenuPaket = new MenuPaket();
            MenuPaket.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            nama_menu = "Iced Lychee Tea";
            harga = 14091;
            this.Hide();
            MenuDetail menudetail = new MenuDetail(nama_menu, harga);
            menudetail.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu MenuMinuman = new Menu();
            MenuMinuman.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MenuMakanan MenuMakanan = new MenuMakanan();
            MenuMakanan.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string menu = "Nama Manu : Iced Lychee Tea";
            int harga = 14091;
            MessageBox.Show("Nama Menu: " + menu + "\n"+ "Harga : Rp." + harga);
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string menu = "Nama Manu : Fresh Lime";
            int harga = 12273;
            MessageBox.Show("Nama Menu: " + menu + "\n" + "Harga : Rp." + harga);

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            string menu = "Milkshake Special";
            int harga = 22272;
            MessageBox.Show("Nama Menu: " + menu + "\n" + "Harga : Rp." + harga);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLOCALDB;Initial Catalog=WsOrder;Integrated Security=True");
            //try
           // {
             //   if (con.State == ConnectionState.Closed)
                //{
                 //   con.Open;
                 //   String query = "SELECR COUNT(1) FROM tb_pemesanan "
               // }

            //}

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            nama_menu = "Fresh Lime";
            harga = 12273;
            MenuDetail menudetail = new MenuDetail(nama_menu, harga);
            menudetail.Show();

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            nama_menu = "Milkshake Special";
            harga = 22272;
            MenuDetail menudetail = new MenuDetail(nama_menu, harga);
            menudetail.Show();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
    }
