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
    /// Interaction logic for EmployeeViewPage.xaml
    /// </summary>
    public partial class EmployeeViewPage : Page
    {
        private EmployeeCRUD crud = new EmployeeCRUD();
        public EmployeeViewPage()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var emp = crud.GetEmployee(int.Parse(id_input.Text));
            this.DataContext = emp;
        }
    }
}
