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

namespace CrimeRecordManagement.views
{
    public class DataItem
    {
        public string CaseID { get; set; }
        public string CaseStatus { get; set; }
        public string AssignedOfficerID { get; set; }
        public string Description { get; set; }
        public string CreationDate { get; set; }
        public string ClosureDate { get; set; }
        public string CaseCategory { get; set; }
    }
    /// <summary>
    /// Interaction logic for Table.xaml
    /// </summary>
    public partial class Table : UserControl
    {
        public Table()
        {
            InitializeComponent();

            var cases_table = this.Cases;
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery"});
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery"});
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery"});
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery"});
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery"});
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery"});
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery" });
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery" });
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery" });
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery" });
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery" });
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery" });
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery" });
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery" });
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery" });
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery" });
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery" });
            cases_table.Items.Add(new DataItem { CaseID = "111", CaseStatus = "Done", AssignedOfficerID = "22", Description = "hello there", CreationDate = "11-11-11", ClosureDate = "11-11-11", CaseCategory = "robbery" });
        }
        private void go_to_case_profile(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.NavigationService.Navigate(new Uri("/Pages/CaseProfile.xaml", UriKind.Relative));
            }
        }
    }
}
