using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prueba_Wal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void btnMostrar_Clicked_1(object sender, EventArgs e)
        {
            var numeroing12 = double.Parse(txtnone2.Text);
            var resultado = numeroing12 + 0;
            var r12 = 2;
           
            var primeros2 = Convert.ToInt32(resultado.ToString().Substring(0, r12));
            int resultadoff = primeros2 - 4;
            Resultfinal.Text = resultadoff.ToString();
            txtnone2.Text = "";
        }

    }
}