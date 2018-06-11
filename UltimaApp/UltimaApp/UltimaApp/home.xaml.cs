using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UltimaApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class home : ContentPage
	{
		public home ()
		{
			InitializeComponent ();
		}


        async private void ButtonProgramacion(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Programacion());
        }

        async private void ButtonGaleria(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Galeria());
        }

        async private void ButtonRecorrido(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Recorrido());
        }

        async private void ButtonPatrocinadores(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Patrocinadores());
        }

        async private void ButtonHistoria(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Historia());
        }
    }
}