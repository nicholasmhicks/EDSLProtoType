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

namespace EDSLProtoTypeNew
{
    /// <summary>
    /// Interaction logic for SelectDates.xaml
    /// </summary>
    public partial class SelectDates : Page
    {
        public SelectDates()
        {
            InitializeComponent();
        }

        private void SeasonButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("SetupSeason.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ResultsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("ResultsPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void SelectDatesClick(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("SetupSeason.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
