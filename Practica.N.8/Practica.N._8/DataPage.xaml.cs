using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace Practica.N._8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataPage : ContentPage
    { 
        public ObservableCollection<TESHDatos> Items { get; set; }
        SQLiteConnection database;


        public DataPage()
        {
            InitializeComponent();
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("TESHDB.db");
            database = new SQLiteConnection(db);
            database.CreateTable<TESHDatos>();
            Items = new ObservableCollection<TESHDatos>(database.Table<TESHDatos>());
            BindingContext = this;
        }

        private void Button_inserta(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertPage());
        }
        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushAsync(new SelectPage(e.SelectedItem as TESHDatos));
        }

        
       
    }
}