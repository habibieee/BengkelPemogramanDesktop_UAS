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
    /// Interaction logic for halamanEdit.xaml
    /// </summary>
    public partial class halamanEdit : Window
    {
        public dbWsOrderEntities2 _db = new dbWsOrderEntities2();
        public int Id;

        public halamanEdit(int Idp)
        {
            InitializeComponent();
            hargamenu.Text = hargamenu.ToString();
            Id = Idp;
            

        }

        private void Total_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Harga_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Jumlah_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_update(object sender, RoutedEventArgs e)
        {
            ListPemesanan lp = new ListPemesanan();
            pemesanan updatePemesanan = (from m in _db.pemesanans
                                   where m.Id == Id
                                   select m).Single();

            updatePemesanan.nama_menu = namamenu.Text;
            updatePemesanan.harga = int.Parse(hargamenu.Text);
            updatePemesanan.jumlah = int.Parse(Jumlahmenu.Text);
            updatePemesanan.total_harga = int.Parse(totalmenu.Text);

            _db.SaveChanges();
            lp.dataPemesanan.ItemsSource = _db.pemesanans.ToList();
            lp.Show();
            this.Close();
        }

        private void Namamenu_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
