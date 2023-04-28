using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;

namespace pdc03_mod04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity02 : ContentPage
    {
        ObservableCollection<Employee> employees= new ObservableCollection<Employee>();

        public ObservableCollection<Employee> Employees { get { return employees; } }
        
        public activity02()
        {

            InitializeComponent();
            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Juan Cruz", Position = "President" });
            employees.Add(new Employee { DisplayName = "Juana Cruz", Position = "Vice President" });
            employees.Add(new Employee { DisplayName = "Juano Cruz", Position = "Secretary" });
            employees.Add(new Employee { DisplayName = "Juans Cruz", Position = "Treasurer" });
        }

        private void Add_Item(object sender, EventArgs e)
        {
            var menuitem = sender as MenuItem;
            if (menuitem != null)
            {

            }
        }

        private void Edit_Item(object sender, EventArgs e)
        {
            var menuitem = sender as MenuItem;
            if (menuitem != null)
            {

            }
        }

        private void Delete_Item(object sender, EventArgs e)
        {
            var menuitem = sender as MenuItem;
            if (menuitem != null)
            {

            }
        }
    }
}