using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UltimaApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        // Se crea el metodo que se llama cuando se da click al boton
        async private void ButtonClicked(object sender, EventArgs e)
        {
            // Vamos a validar que los campos no esten vacios
            if (string.IsNullOrEmpty(entryUser.Text) || string.IsNullOrEmpty(entryPasword.Text))

            {

                await DisplayAlert("Error", "Debe escribir usuario y contraseña", "OK");
            }
            else
            {

                await DisplayAlert("Correcto", "Bienvenido", "OK");
                await Navigation.PushAsync(new home());
            }

        }

        async private void ButtonRegistro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
        }

    }
}
