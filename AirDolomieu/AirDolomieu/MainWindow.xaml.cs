using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AirDolomieu.Class;

namespace AirDolomieu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<ViewVol> ListVol { get; set; }
        public ObservableCollection<Pilote> _Pilote { get; set; }
        public ObservableCollection<Avion> _Avion { get; set; }


        public MainWindow()
        {
            try
            {
                InitializeComponent();

                Data data = new Data();
                _Pilote = new ObservableCollection<Pilote>();
                _Pilote = data.GetAllPilote();

                _Avion = new ObservableCollection<Avion>();
                _Avion = data.GetAllAvion();

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace.ToString());
            }
            
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            if (ListPilote.SelectedIndex == -1 && ListAvion.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing Selected !");
            } 
            else 
            {
                Data data = new Data();
                bool onlyavion = ListPilote.SelectedIndex == -1;
                bool onlypilote = ListAvion.SelectedIndex == -1;

                if (onlypilote)
                {
                    
                    ListVol = data.GetViewVolsbyPilote((Pilote)ListPilote.SelectedItem);
                }
                else if (onlyavion)
                {
                    ListVol = data.GetViewVolsbyAvion((Avion)ListAvion.SelectedItem);
                }
                else
                {
                    ListVol = data.GetViewVolsbyAll((Pilote)ListPilote.SelectedItem, (Avion)ListAvion.SelectedItem);
                }
            }
            vol.ItemsSource = ListVol;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            vol.ItemsSource = null ;
            ListPilote.SelectedIndex = -1;
            ListAvion.SelectedIndex = -1;

        }

        private void AddVolButton_Click(object sender, RoutedEventArgs e)
        {
            Data data = new Data();
            Vol Newvol = new Vol();
            
            Newvol.Numvol = NewNumVol.Text;
            Newvol.Villedep = NewVilleDep.Text;
            Newvol.Heuredep = NewDateDep.Text;
            Newvol.Villearr = NewVilleArr.Text;
            Newvol.Heurearr = NewDateArr.Text;

            string message = data.PutNewVol(Newvol, (Pilote)ListPilote.SelectedItem, (Avion)ListAvion.SelectedItem);

            if (message == "OK")
            {
                vol.ItemsSource = null;
                ListPilote.SelectedIndex = -1;
                ListAvion.SelectedIndex = -1;
                MessageBox.Show("Vol ajouté !");
            }
            else
            {
                MessageBox.Show(message);
            }
        }

    }
}
