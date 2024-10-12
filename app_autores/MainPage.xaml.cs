using app_autores.Modelos;

namespace app_autores
{

    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            CargarPaises();
        }

        async void OnAddAutorClicked(object sender, EventArgs e)
        {
            var nombre = nombreEntry.Text;
            var pais = paisesPicker.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                await DisplayAlert("Error", "Por favor, ingrese un nombre", "OK");
                return;
            }


            var nuevoAutor = new Autor
            {
                nombre = nombre,
                pais = pais
            };

           

            await App.Database.SaveAutorAsync(nuevoAutor);

            ResetCampos();
          
            await Navigation.PushAsync(new ListPage());

        }

        void ResetCampos()
        {
            nombreEntry.Text = string.Empty; 
            paisesPicker.SelectedIndex = -1;   
        }

        void CargarPaises()
        {
            var paises = new List<string>
        {
            "Argentina",
            "Bolivia",
            "Brasil",
            "Chile",
            "Colombia",
            "Costa Rica",
            "Cuba",
            "Ecuador",
            "El Salvador",
            "España",
            "Estados Unidos",
            "Guatemala",
            "Honduras",
            "México",
            "Nicaragua",
            "Panamá",
            "Paraguay",
            "Perú",
            "República Dominicana",
            "Uruguay",
            "Venezuela"
        };

            paisesPicker.ItemsSource = paises;
        }
    }

}
