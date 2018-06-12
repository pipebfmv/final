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
        private const string UrlRoot = "https://pipeapicarnaval.herokuapp.com/";
        private const string UrlCreateUser = UrlRoot + "createUser";
        private readonly HttpClient client = new HttpClient();


        public Registro ()
		{
			InitializeComponent ();
		}

 

        public void ClickCreateUser(object sender, EventArgs e)
        {
            CreateAccount();
        }

        async public void CreateAccount()
        {
            Users user = new Users()
            {
                Username = entryUserNick.Text,
                Password = entryPasword.Text,
                Name = entryUser.Text,
                Email = entryemail.Text
            };

            var json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(UrlCreateUser, content);
            string message = await response.Content.ReadAsStringAsync();
            List<Users> users = JsonConvert.DeserializeObject<List<Users>>(message);

          
            await DisplayAlert("Correcto", "Se ha creado un nuevo usuario", "OK");
            entryemail.Text = "";
            entryPasword.Text = "";
            entryUser.Text = "";
            entryUserNick.Text = "";
        }

  

      
        async private void ButtonMenu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

    }
}