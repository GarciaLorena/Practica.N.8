using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Practica.N._8.Droid;
using Xamarin.Forms;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

[assembly: Dependency(typeof(SQLiteAndroid))]

namespace Practica.N._8.Droid
{
   public class SQLiteAndroid : ISQLite
    {
        public string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}