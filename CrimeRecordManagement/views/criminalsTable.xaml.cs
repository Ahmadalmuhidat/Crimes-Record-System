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
    public class CriminalsDataItem
    {
        public string CriminalID { get; set; }
        public string CriminalStatus { get; set; }
        public string AssignedOfficerID { get; set; }
        /*
        public string Description { get; set; }
        public string CreationDate { get; set; }
        public string ClosureDate { get; set; }
        public string CaseCategory { get; set; }
        */
    }
    /// <summary>
    /// Interaction logic for criminalsTable.xaml
    /// </summary>
    public partial class criminalsTable : UserControl
    {
        public criminalsTable()
        {
            InitializeComponent();

            var criminals_table = this.Criminals;
            criminals_table.Items.Add(new CriminalsDataItem { CriminalID = "111", CriminalStatus = "Done", AssignedOfficerID = "22" });
            criminals_table.Items.Add(new CriminalsDataItem { CriminalID = "111", CriminalStatus = "Done", AssignedOfficerID = "22" });
        }
    }
}
