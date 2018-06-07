using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UltimaApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UltimaApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registro : ContentPage
	{
        private const string Url = "https://jonmidpruebanode.herokuapp.com/users";
        private readonly HttpClient client = new HttpClient();

        public Registro ()
		{
			InitializeComponent ();
		}

        async public void CreateUser()
        {
            if (string.IsNullOrEmpty(entryUser.Text) || string.IsNullOrEmpty(entryPasword.Text))

            {

                await DisplayAlert("Error", "Debe escribir usuario y contraseña", "OK");
            }
            else
            {

                Users user = new Users()
                {
                    Name = entryUser.Text

                };



                var json = JsonConvert.SerializeObject(user);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                response = await client.PostAsync(Url, content);
                await DisplayAlert("CORRECTO", "El usuario se ha creado correctamente", "OK");

                entryUser.Text = " ";
                entryPasword.Text = " ";

            }



        }

        public void ClickCreateUser(object sender, EventArgs e)
        {
            CreateUser();
        }

        async private void ButtonMenu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

    }
}