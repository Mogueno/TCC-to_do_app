﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileTCC.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Features : ContentPage
	{
		public Features ()
		{
			InitializeComponent ();
            Browser.Source = "https://mogueno.github.io/Atena-Web/";
        }
	}
}