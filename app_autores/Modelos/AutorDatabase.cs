using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_autores.Modelos
{
    public class AutorDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public AutorDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Autor>().Wait();
        }

        public Task<List<Autor>> GetAutoresAsync()
        {
            return _database.Table<Autor>().ToListAsync();
        }

        public Task<Autor> GetAutorAsync(int id)
        {
            return _database.Table<Autor>().Where(i => i.id_autor == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveAutorAsync(Autor autor)
        {  
                return _database.InsertAsync(autor);   
        }

    }
}
