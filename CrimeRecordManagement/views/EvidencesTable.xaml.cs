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
    /// Interaction logic for EvidencesTable.xaml
    /// </summary>
    public class EvidencesDataItem
    {
        public string EvidenceID { get; set; }
        public string EvidenceStatus { get; set; }
    }

    public partial class EvidencesTable : UserControl
    {
        public EvidencesTable()
        {
            InitializeComponent();

            var criminals_table = this.Evidences;
            criminals_table.Items.Add(new EvidencesDataItem { EvidenceID = "111", EvidenceStatus = "Done" });
        }
    }
}
