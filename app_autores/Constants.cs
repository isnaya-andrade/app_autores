using System;
using System.IO;

namespace app_autores
{
    public static class Constants
    {
        public const string DatabaseFilename = "AutoresSQLite.db3"; 

        public static string DatabasePath
        {
            get
            {
                
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }
    }
}