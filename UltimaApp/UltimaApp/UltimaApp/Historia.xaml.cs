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
	public partial class Historia : ContentPage
	{
		public Historia ()
		{
			InitializeComponent ();
		}

        async private void ButtonHome()
        {
            await Navigation.PushAsync(new home());
        }

    }
}