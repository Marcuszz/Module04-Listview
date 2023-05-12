using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pdc03_mod04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailedPage : ContentPage
    {
        public DetailedPage()
        {
            InitializeComponent();
        }

        async void OnCloseButton(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}