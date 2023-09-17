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

namespace CrimeRecordManagement.Pages
{
    /// <summary>
    /// Interaction logic for CaseProfile.xaml
    /// </summary>
    public partial class CaseProfile : Page
    {
        public CaseProfile()
        {
            InitializeComponent();
        }

        public void switch_tabs(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var background = button.Background;

            intels_tab.Background = background;
            suspects_tab.Background = background;
            evidences_tab.Background = background;

            button.Background = Brushes.DarkGray;

            IntelsTab.Visibility = Visibility.Collapsed;

            if (button == intels_tab)
            {
                IntelsTab.Visibility = Visibility.Visible;
            }
            else
            {
                IntelsTab.Visibility = Visibility.Collapsed;
            }
        }
    }
}
