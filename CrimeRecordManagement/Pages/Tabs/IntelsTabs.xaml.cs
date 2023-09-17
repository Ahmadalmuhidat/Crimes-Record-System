using CrimeRecordManagement.views;
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

namespace CrimeRecordManagement.Pages.Tabs
{
    /// <summary>
    /// Interaction logic for IntelsTabs.xaml
    /// </summary>
    public partial class IntelsTabs : UserControl
    {
        public class IntelDataItem
        {
            public string IntelID { get; set; }
            public string IntelContent { get; set; }
            public string IntelCreationDate { get; set; }
        }
        public IntelsTabs()
        {
            InitializeComponent();
            var intels_table = this.Intels;
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            /*
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            intels_table.Items.Add(new IntelDataItem { IntelID = "111", IntelContent = "Done", IntelCreationDate = "22" });
            */
        }
    }
}
