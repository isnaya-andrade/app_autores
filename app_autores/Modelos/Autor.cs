using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_autores.Modelos
{
    public class Autor
    {

        [PrimaryKey, AutoIncrement]

        public int id_autor { get; set; }

        [MaxLength(255)] 
        [NotNull] 
        public string nombre
            { get; set; }

        [MaxLength(255)] 
        [NotNull] 
        public string pais
            { get; set; }
    }
}
