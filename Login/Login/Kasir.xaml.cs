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
    /// Interaction logic for Kasir.xaml
    /// </summary>
    public partial class Kasir : Window
    {
        public dbWsOrderEntities2 _db = new dbWsOrderEntities2();
        public static DataGrid dataGrid;
        public Kasir()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            datakasir.ItemsSource = _db.pembayarans.ToList();
            dataGrid = datakasir;
            datakasir.Columns[2].Width = 140;
            datakasir.Columns[1].Width = 140;
            datakasir.Columns[3].Width = 140;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TablePemesanan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Hapus(object sender, RoutedEventArgs e)
        {
            int Id = (datakasir.SelectedItem as pembayaran).Id;
            var hapusPembayaran = _db.pembayarans.Where(m => m.Id == Id).Single();
            _db.pembayarans.Remove(hapusPembayaran);
            _db.SaveChanges();
            datakasir.ItemsSource = _db.pembayarans.ToList();
        }
    }
}
