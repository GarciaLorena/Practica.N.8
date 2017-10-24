using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica.N._8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Ingresar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DataPage());
        }
    }
}
