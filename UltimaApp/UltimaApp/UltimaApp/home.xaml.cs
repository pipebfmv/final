﻿using System;
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

        public void ClickButtonSignOff(object sender, EventArgs e)
        {
            Application.Current.Properties.Clear();
            showWindowMainPage();
        }

        async public void showWindowMainPage()
        {
            await Navigation.PushAsync(new MainPage());
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

        async private void ButtonNoticias(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Noticias());
        }

     
    }
}