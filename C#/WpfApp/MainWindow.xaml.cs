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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            getCountries();
            firstname_vm.Visibility = Visibility.Collapsed;
            middlename_vm.Visibility = Visibility.Collapsed;
            lastname_vm.Visibility = Visibility.Collapsed;
            gender_vm.Visibility = Visibility.Collapsed;
            country_vm.Visibility = Visibility.Collapsed;
            dob_vm.Visibility = Visibility.Collapsed;
        }
        public void getCountries()
        {
            List<string> countries = new List<string>() { "India", "USA", "UK"};
            List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
            foreach (string country in countries)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = country;
                comboBoxItems.Add(comboBoxItem);
            }
            country_combobox.ItemsSource = comboBoxItems;
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(firstname_input.Text))
            {
                firstname_vm.Visibility = Visibility.Visible;
            }
            else
            {
                firstname_vm.Visibility = Visibility.Collapsed;
            }
            if (string.IsNullOrEmpty(middlename_input.Text))
            {
                middlename_vm.Visibility= Visibility.Visible;
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
            if (string.IsNullOrEmpty(firstname_input.Text) || string.IsNullOrEmpty(middlename_input.Text )|| string.IsNullOrEmpty(lastname_input.Text)
                || (male_radiobtn.IsChecked == false && female_radiobtn.IsChecked == false) || string.IsNullOrEmpty(country_combobox.Text) || string.IsNullOrEmpty(dob_input.Text))
            {
                return;
            }
            else
            {
                string firstname = firstname_input.Text;
                string lastname = lastname_input.Text;
                string middlename = middlename_input.Text;
                bool? male = male_radiobtn.IsChecked;
                bool? female = female_radiobtn.IsChecked;
                string gender = (male!=null && male == true) ? "Male" : "Female";
                string country = country_combobox.Text;
                string dob = dob_input.Text;
                MessageBox.Show($"First Name: {firstname} \nMiddle Name: {middlename}\nLast Name: {lastname}\nGender: {gender}\nDOB: {dob}\nCountry: {country}","Submitted Data");
            }


        }
    }
}
