using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UltimaApp.Models;
using Xamarin.Forms;

namespace UltimaApp
{
    public partial class MainPage : ContentPage
    {
        private const string Url = "https://jonmidpruebanode.herokuapp.com/users";
        private readonly HttpClient client = new HttpClient();
       
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
            else if (entryUser.Text=="pipe")
            {
               // pasar();
                await DisplayAlert("Correcto", "Bienvenido", "OK");
                await Navigation.PushAsync(new home());
            }
            else
            {
                await DisplayAlert("Error", "EL USUARIO NO EXISTE", "OK");
            }

            
        }

           
        async private void ButtonRegistro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
        }

    }
    
}
