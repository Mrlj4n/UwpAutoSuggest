using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UwpAutoSuggest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private DispatcherTimer tajmer = new DispatcherTimer();

        private List<Radnik> listaRadnika = Podaci.Radnici;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            tajmer.Interval = new TimeSpan(0, 0, 1);
            TextBlockDatum.Text = DateTime.Now.ToString("dd.MM.yyyy");
            TextBlockVreme.Text = DateTime.Now.ToString("hh:mm:ss");
            tajmer.Tick += Tajmer_Tick;
            tajmer.Start();
        }

        private void Tajmer_Tick(object sender, object e)
        {
            TextBlockVreme.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void AutoSuggestBox1_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (!string.IsNullOrWhiteSpace(AutoSuggestBox1.Text))
            {
                IEnumerable<string> imena = listaRadnika
                    .Where(r => r.Ime.StartsWith(AutoSuggestBox1.Text, 
                    StringComparison.CurrentCultureIgnoreCase))
                    .Select(r => r.Ime);
                AutoSuggestBox1.ItemsSource = imena;
            }
        }

        private void Pronadji(string pretraga)
        {
            IEnumerable<Radnik> radnici = listaRadnika
                .Where(r => r.Ime.StartsWith(pretraga,
                StringComparison.CurrentCultureIgnoreCase));
            ListBox1.ItemsSource = radnici.ToList();
        }

        private void AutoSuggestBox1_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            string pretraga = AutoSuggestBox1.Text;
            Pronadji(pretraga);
        }

        private void ButtonPronadji_Click(object sender, RoutedEventArgs e)
        {
            string pretraga = AutoSuggestBox1.Text;
            Pronadji(pretraga);
        }
    }
}
