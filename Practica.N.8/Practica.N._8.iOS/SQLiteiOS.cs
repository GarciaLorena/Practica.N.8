using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Practica.N._8.iOS;
using Xamarin.Forms;

using Foundation;
using UIKit;
[assembly: Dependency(typeof(SQLiteiOS))]
namespace Practica.N._8.iOS
{
   public class SQLiteiOS : ISQLite
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libfolder = Path.Combine(docFolder, "..", "Library", "DataBase");
            if (!Directory.Exists(libfolder))
            {
                Directory.CreateDirectory(libfolder);
            }
            return Path.Combine(libfolder, filename);
        }
    }
}