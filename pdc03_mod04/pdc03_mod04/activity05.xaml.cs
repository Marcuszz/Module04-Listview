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
    public partial class activity05 : ContentPage
    {
        List<Contacts> contacts;

        public activity05()
        {
            InitializeComponent();
            SetupData();
            listview.ItemsSource = contacts;
        }


         void SetupData()
         {
            contacts = new List<Contacts>();
            contacts.Add(new Contacts
            {
                Name ="Juan",
                Age = 30,
                Occupation = "Analyst",
                Country = "Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Juana",
                Age = 40,
                Occupation = "Driver",
                Country = "Canada"
            });

            contacts.Add(new Contacts
            {
                Name = "Juano",
                Age = 50,
                Occupation = "Cook",
                Country = "Brazil"
            });

            contacts.Add(new Contacts
            {
                Name = "Juanda",
                Age = 20,
                Occupation = "Tester",
                Country = "Guam"
            });

            contacts.Add(new Contacts
            {
                Name = "Juanoo",
                Age = 55,
                Occupation = "Developer",
                Country = "Russia"
            });

            async void onItemSelected(object sender, SelectedItemChangedEventArgs e)
            {
                if(listview.SelectedItem != null)
                {
                    var detailPage = new DetailedPage();
                    detailPage.BindingContext = e.SelectedItem as Contacts;
                    listview.SelectedItem = null;
                    await Navigation.PushModalAsync(detailPage);
                }
            }
        }
    }
}