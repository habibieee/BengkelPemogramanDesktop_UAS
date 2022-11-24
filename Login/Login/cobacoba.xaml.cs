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
    /// Interaction logic for cobacoba.xaml
    /// </summary>
    public partial class cobacoba : Window
    {
        public dbWsOrderEntities2 _db = new dbWsOrderEntities2();
        public static DataGrid dataGrid;
       
       

        public cobacoba()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pemesanan newpemesanan = new pemesanan()
            {
                nama_menu = namatxt.Text,
                harga = int.Parse(hargatxt.Text),
                jumlah = int.Parse(jumlahtxt.Text),
                total_harga = int.Parse(totaltxt.Text)
            };

            _db.pemesanans.Add(newpemesanan);
            _db.SaveChanges();
            this.Hide();
            ListPemesanan lp = new ListPemesanan();
            lp.dataPemesanan.ItemsSource = _db.pemesanans.ToList();
            lp.Show();
        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_5(object sender, TextChangedEventArgs e)
        {

        }
    }
}
