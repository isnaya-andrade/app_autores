using app_autores.Modelos;
using System.Collections.ObjectModel;
namespace app_autores
{
    public partial class ListPage : ContentPage
    {
        ObservableCollection<Autor> autores = new ObservableCollection<Autor>();
        ObservableCollection<Autor> autoresFiltrados = new ObservableCollection<Autor>();
        public ListPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var listaAutores = await App.Database.GetAutoresAsync();
            autores = new ObservableCollection<Autor>(listaAutores);
            autoresFiltrados = new ObservableCollection<Autor>(autores);
            autoresListView.ItemsSource = autoresFiltrados;
            autoresListView.ItemsSource = await App.Database.GetAutoresAsync();
        }

        private void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
        {
            var textoBusqueda = e.NewTextValue?.ToLower() ?? string.Empty;
            autoresFiltrados.Clear();

            foreach (var autor in autores)
            {
                if (autor.nombre.ToLower().Contains(textoBusqueda) ||
                    autor.pais.ToLower().Contains(textoBusqueda))
                {
                    autoresFiltrados.Add(autor);
                }
            }
            autoresListView.ItemsSource = autoresFiltrados;
        }

    }
}