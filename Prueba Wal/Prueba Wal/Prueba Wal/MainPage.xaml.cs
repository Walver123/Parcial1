using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prueba_Wal
{
    
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();
            
            }

       
        private async void pagina1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina_1());
        }


        private async void pagina2_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Page2());
        }
    }

     
}

