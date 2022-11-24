using System;
using System.Collections.Generic;
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
    /// Interaction logic for ListPemesanan.xaml
    /// </summary>
    public partial class ListPemesanan : Window
    {
        public dbWsOrderEntities2 _db = new dbWsOrderEntities2();
        public static DataGrid dataGrid;
        public int Id;

        private void harga()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLOCALDB;Initial Catalog=dbWsOrder;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("SELECT SUM(total_harga) FROM pemesanan ", con);
            SqlDataReader a = command.ExecuteReader();
            while (a.Read())
            {
                totalsemua.Text = a.GetValue(0).ToString();
            };
        }

        public ListPemesanan()
        {
            InitializeComponent();
            load();
            harga();
            //this.Id = Id;
        }

        public void load()
        {
            dataPemesanan.ItemsSource = _db.pemesanans.ToList();
            dataGrid = dataPemesanan;
            dataPemesanan.Columns[1].Width = 140;
            dataPemesanan.Columns[2].Width = 140;
            dataPemesanan.Columns[3].Width = 140;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLOCALDB;Initial Catalog=dbWsOrder;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("SELECT id FROM pemesanan", con);
            SqlDataReader a = command.ExecuteReader();
            while (a.Read())
            {
                pembayaran pembayaran = new pembayaran()
                {
                    nama = atasnama.Text,
                    order = order.Text,
                    no_pemesanan = int.Parse(a.GetValue(0).ToString()),
                    //status = int.Parse(totalmenu.Text);

                };
                _db.pembayarans.Add(pembayaran);
                _db.SaveChanges();
                selesai s = new selesai();
                s.Show();

            };
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MenuMakanan menu_makanan = new MenuMakanan();
            menu_makanan.Show();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Hapus(object sender, RoutedEventArgs e)
        {
            Id = (dataPemesanan.SelectedItem as pemesanan).Id;
            var hapusPemesanan = _db.pemesanans.Where(m => m.Id == Id).Single();
            _db.pemesanans.Remove(hapusPemesanan);
            _db.SaveChanges();
            dataPemesanan.ItemsSource = _db.pemesanans.ToList();
            harga();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Atasnama_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        

        private void Button_edit(object sender, RoutedEventArgs e)
        {
            //int Id = dataPemesanan.SelectedItem as pemesanan;
            Id = (dataPemesanan.SelectedItem as pemesanan).Id;
            halamanEdit edit = new  halamanEdit(Id);
            edit.Show();
            //int Id = (dataPemesanan.SelectedItem as pemesanan).Id;
            //this.Hide();

            //pemesanan selectedpes = (from m in _db.pemesanans
            //                         where m.Id == Id
            //                         select m).Single();

            //halamanEdit haledit = new halamanEdit(Id);
            //haledit.namamenu.Text  = selectedpes.nama_menu + " ";
            //haledit.hargamenu.Text = selectedpes.harga + " ";
            //haledit.Jumlahmenu.Text = selectedpes.jumlah + " ";
            //haledit.totalmenu.Text = selectedpes.total_harga + " ";
            //haledit.Show();
        }
    }
}
