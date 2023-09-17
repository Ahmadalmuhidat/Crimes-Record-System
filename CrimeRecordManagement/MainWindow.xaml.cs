using CrimeRecordManagement.Pages;
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

namespace CrimeRecordManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public NavigationService NavigationService { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            NavigationService = ContentFrame.NavigationService;
            ContentFrame.Content = new CasesDatabase();
        }

        private void navigate_to_page(object sender, RoutedEventArgs e)
        {    
            var menuItem = (MenuItem)sender;

            cases_database_button.IsChecked = false;
            criminals_database_button.IsChecked = false;
            active_officers_button.IsChecked = false;
            evidences_database_button.IsChecked = false;

            menuItem.IsChecked = true;

            if (menuItem == cases_database_button)
            {
                ContentFrame.Content = new CasesDatabase();
            }
            else if (menuItem == criminals_database_button)
            {
                ContentFrame.Content = new CriminalsDatabase();
            }
            else if (menuItem == active_officers_button)
            {
                ContentFrame.Content = new ActiveOfficers();
            }
            else if (menuItem == evidences_database_button)
            {
                ContentFrame.Content = new EvidencesDatabase();
            }
        }
    }
}
