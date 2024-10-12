using app_autores.Modelos;

namespace app_autores
{
    public partial class App : Application
    {
        static AutorDatabase database;

        public static AutorDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new AutorDatabase(Constants.DatabasePath);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
