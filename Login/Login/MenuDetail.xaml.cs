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
    /// Interaction logic for MenuDetail.xaml
    /// </summary>
    public partial class MenuDetail : Window
    {
        public dbWsOrderEntities2 _db = new dbWsOrderEntities2();
        public MenuDetail(string nama_menu,int harga)
        {
            InitializeComponent();
            namamenu.Text = nama_menu;
            hargamenu.Text = harga.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Namamenu_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Harga_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Total_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Jumlah_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Jumlahmenu.Text != "")
            {
                int jumlah = int.Parse(Jumlahmenu.Text);
                int harga = int.Parse(hargamenu.Text);
                totalmenu.Text = (jumlah * harga).ToString();
            }
            else
            {
                totalmenu.Text = "0";
            }

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pemesanan newpemesanan = new pemesanan()
            {
                nama_menu = namamenu.Text,
                harga = int.Parse(hargamenu.Text),
                jumlah = int.Parse(Jumlahmenu.Text),
                total_harga = int.Parse(totalmenu.Text)
            };
            _db.pemesanans.Add(newpemesanan);
            _db.SaveChanges();
            this.Hide();
            ListPemesanan lp = new ListPemesanan();
            lp.dataPemesanan.ItemsSource = _db.pemesanans.ToList();
            lp.Show();
        }
    }
}
