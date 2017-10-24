using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace Practica.N._8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectPage : ContentPage
    {
        SQLiteConnection database;
        public SelectPage(object SelectedItem)
        {
            var dato = SelectedItem as TESHDatos;
            BindingContext = dato;
            InitializeComponent();
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("TESHDB.db");
            database = new SQLiteConnection(db);
        }

        private void Button_Actualizar_Clicked(object sender, EventArgs e)
        {
            var datos = new TESHDatos
            {
                Id = Entry_Matricula.Text,
                Dato1 = Entry_Nombre.Text,
                Dato2 = Entry_Apellido.Text,
                Dato3 = Entry_Direccion.Text,
                Dato4 = Entry_Telefono.Text,
                Dato5 = Entry_Carrera.Text,
                Dato6 = Entry_Semestre.Text,
                Dato7 = Entry_Correo.Text,
                Dato8 = Entry_GitHub.Text
            };
            database.Update(datos);
            Navigation.PushAsync(new DataPage());

        }

        private void Button_Eliminar_Clicked(object sender, EventArgs e)
        {
            var datos = new TESHDatos
            {
                Id = Entry_Matricula.Text,
                Dato1 = Entry_Nombre.Text,
                Dato2 = Entry_Apellido.Text,
                Dato3 = Entry_Direccion.Text,
                Dato4 = Entry_Telefono.Text,
                Dato5 = Entry_Carrera.Text,
                Dato6 = Entry_Semestre.Text,
                Dato7 = Entry_Correo.Text,
                Dato8 = Entry_GitHub.Text
            };
            database.Delete(datos);
            Navigation.PushAsync(new DataPage());
        }
    }
}