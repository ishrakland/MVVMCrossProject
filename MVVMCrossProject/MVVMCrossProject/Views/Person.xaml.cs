using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMCrossProject.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Person : ContentPage
	{
		public Person ()
		{
			InitializeComponent ();
		}
	}
}