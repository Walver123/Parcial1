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
    public partial class Pagina_1 : ContentPage
    {
        public Pagina_1()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var numeroing = double.Parse(txtnone.Text);
            var result = numeroing - 365;
            int r = 2;
            var primeros2 = Convert.ToInt32(result.ToString().Substring(0, r));

            lblRes.Text = primeros2.ToString();

            var result1 = numeroing - 365;
            int r1 = 2;
            var segundos2 = Convert.ToInt32(result1.ToString().Substring(2, r1));

            lblRes1.Text = segundos2.ToString();
            txtnone.Text = "";
        }

    }
}