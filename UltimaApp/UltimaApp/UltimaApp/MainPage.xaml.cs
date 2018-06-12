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
        private const string UrlRoot = "https://pipeapicarnaval.herokuapp.com/";
        private const string UrlValidarUser = UrlRoot + "validateUser";
        private readonly HttpClient client = new HttpClient();

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Application.Current.Properties.ContainsKey("id_user"))
            {
                Home();
            }
        }

        // Se crea el metodo que se llama cuando se da click al boton

    
    async private void ButtonClicked(object sender, EventArgs e)
        {
             Users user = new Users() { Username = entryUser.Text, Password = entryPasword.Text };

            var json = JsonConvert.SerializeObject(user);
                     var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(UrlValidarUser, content);
            string message = await response.Content.ReadAsStringAsync();
            List<Users> users = JsonConvert.DeserializeObject<List<Users>>(message);

            

            if (users[0].Success)
             {
              Application.Current.Properties["id_user"] = users[0].Id;
                await DisplayAlert("Correcto", "Acaba de iniciar sesion", "OK");
                Home();
             }
             else
             {
               await DisplayAlert("Error", "El usuario no existe", "OK");
             }
            
            
        }

           
        async private void ButtonRegistro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
        }

        async private void Home()
        {
            await Navigation.PushAsync(new home());
        }
    }
    
}
