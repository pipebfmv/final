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
	public partial class Patrocinadores : ContentPage
	{
		public Patrocinadores ()
		{
			InitializeComponent ();
		}

        async private void ButtonMenu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new home());
        }

    }
}