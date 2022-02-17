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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FrancoProvaComune5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Maratone maratone;
        public MainWindow()
        {
            InitializeComponent();
            maratone = new Maratone();
            DgMaratona.ItemsSource = maratone.elencoMaratone;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            maratone.LeggiDati();
            DgMaratona.Items.Refresh();
        }

        private void btnTempoInMinuti_Click(object sender, RoutedEventArgs e)
        {
            string nomeAtleta = txtNomeAtleta.Text;
            string nomeCittà = txtNomeCittà.Text;

            int durata = maratone.CalcolaTempoMinuti(nomeCittà, nomeAtleta);
            lblTempoFinale.Content = durata;

          
        }

        private void btnCercaAtletiPerCittà_Click(object sender, RoutedEventArgs e)
        {
            string nomeCittà = txtNomeCittà.Text;
        }
    }
}
