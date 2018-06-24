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
    /// Interaction logic for SetupSeason.xaml
    /// </summary>
    public partial class SetupSeason : Page
    {
        public SetupSeason()
        {
            InitializeComponent();
            DivisionComboBox1.Items.Add("Division 1");
        }

        private void SeasonButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ResultsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("ResultsPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void SelectDates_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("SelectDates.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ViewDates_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("SelectDates.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Createseason_Click(object sender, RoutedEventArgs e)
        {
            CreateButton.Visibility = Visibility.Visible;
            DivisionButtonLabel.Visibility = Visibility.Visible;
            DivisionComboBox1.Visibility = Visibility.Visible;
            ViewDrawButton.Visibility = Visibility.Visible;
        }

        private void CreateDraw_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Draw created, select view draw to view");
        }

        private void ViewDraw_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\cbfbro\Source\Repos\EDSLProtoTypeNew\EDSLProtoTypeNew\Draw.pdf");
        }

    }
}
