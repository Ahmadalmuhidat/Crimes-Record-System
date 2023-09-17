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
    /// <summary>
    /// Interaction logic for ActiveOfficersTable.xaml
    /// </summary>
    public class OfficersDataItem
    {
        public string OfficerID { get; set; }
        public string OfficerStatus { get; set; }
    }

    public partial class ActiveOfficersTable : UserControl
    {
        public ActiveOfficersTable()
        {
            InitializeComponent();

            var criminals_table = this.Officers;
            criminals_table.Items.Add(new OfficersDataItem { OfficerID = "111", OfficerStatus = "Done"});
        }
    }
}
