using System.Collections.ObjectModel;

namespace GiorioDemoListe
{
    public partial class MainPage : ContentPage
    {

        ObservableCollection<Libro> elenco = new ObservableCollection<Libro>();
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            elenco.Clear();

            Random random = new Random();
            for (int i = 0; i < 10; i++) { 
            
            int n = random.Next(100);
                Libro unLibro = new Libro();
                unLibro.Titolo ="i Love the number "+ i.ToString();
                unLibro.Costo = random.Next(1,50);
                unLibro.Pagine = random.Next(1,500);
                unLibro.Vuoto = "-----------------------------------------------------------";
               elenco.Add(unLibro);
            }
            lst_elenco.ItemsSource = elenco;

        }
    }

}
