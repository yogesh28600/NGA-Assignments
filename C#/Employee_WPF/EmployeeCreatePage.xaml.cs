using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp.Models;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for EmployeeCreatePage.xaml
    /// </summary>
    public partial class EmployeeCreatePage : Page
    {
        private EmployeeCRUD crud;
        public EmployeeCreatePage()
        {
            InitializeComponent();
            getContries();
            crud = new EmployeeCRUD();
            firstname_vm.Visibility = Visibility.Collapsed;
            lastname_vm.Visibility = Visibility.Collapsed;
            middlename_vm.Visibility = Visibility.Collapsed;
            country_vm.Visibility = Visibility.Collapsed;
            gender_vm.Visibility = Visibility.Collapsed;
            dob_vm.Visibility = Visibility.Collapsed;
        }
        public void getContries()
        {
            List<string> countries = new List<string>() { "India", "USA", "Canada" };
            List<ComboBoxItem> comboboxlist = new List<ComboBoxItem>();
            foreach (string country in countries)
            {
                var combobox = new ComboBoxItem();
                combobox.Content = country;
                comboboxlist.Add(combobox);
            }
            country_combobox.ItemsSource = comboboxlist;
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(firstname_input.Text))
            {
                firstname_vm.Visibility = Visibility.Visible;
            }
            else
            {
                firstname_vm.Visibility = Visibility.Collapsed;
            }
            if (string.IsNullOrEmpty(middlename_input.Text))
            {
                middlename_vm.Visibility = Visibility.Visible;
            }
            else
            {
                middlename_vm.Visibility = Visibility.Collapsed;
            }
            if (string.IsNullOrEmpty(lastname_input.Text))
            {
                lastname_vm.Visibility = Visibility.Visible;
            }
            else
            {
                lastname_vm.Visibility = Visibility.Collapsed;
            }
            if (male_radiobtn.IsChecked == false && female_radiobtn.IsChecked == false)
            {
                gender_vm.Visibility = Visibility.Visible;
            }
            else
            {
                gender_vm.Visibility = Visibility.Collapsed;
            }
            if (string.IsNullOrEmpty(country_combobox.Text))
            {
                country_vm.Visibility = Visibility.Visible;
            }
            else
            {
                country_vm.Visibility = Visibility.Collapsed;
            }
            if (string.IsNullOrEmpty(dob_input.Text))
            {
                dob_vm.Visibility = Visibility.Visible;
            }
            else
            {
                dob_vm.Visibility = Visibility.Collapsed;
            }
            if (string.IsNullOrEmpty(firstname_input.Text) || string.IsNullOrEmpty(middlename_input.Text) || string.IsNullOrEmpty(lastname_input.Text)
                || (male_radiobtn.IsChecked == false && female_radiobtn.IsChecked == false) || string.IsNullOrEmpty(country_combobox.Text) || string.IsNullOrEmpty(dob_input.Text))
            {
                return;
            }
            else
            {
                bool? male = male_radiobtn.IsChecked;
                bool? female = female_radiobtn.IsChecked;
                string gender = (male != null && male == true) ? "Male" : "Female";
                var emp = new Employee()
                {
                    first_name = firstname_input.Text,
                    last_name = lastname_input.Text,
                    middle_name = middlename_input.Text,
                    gender = gender,
                    country = country_combobox.Text,
                    dob = dob_input.Text
                };
                bool added =crud.AddEmployee(emp);
                if (added )
                {
                    MessageBox.Show("Employee added successfully");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }
    }
}
