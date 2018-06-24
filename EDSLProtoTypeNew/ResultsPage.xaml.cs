using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for ResultsPage.xaml
    /// </summary>
    public partial class ResultsPage : Page
    {
        public ResultsPage()
        {
            InitializeComponent();
            DivisionComboBox.Items.Add("Division 1");
            RoundComboBox.Items.Add("Round 1");
            RoundDateComboBox.Items.Add("1/1/18");

        }

        private void SeasonButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("SetupSeason.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ResultsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateResults_Click(object sender, RoutedEventArgs e)
        {
            if (DivisionComboBox.SelectedItem == null || RoundDateComboBox.SelectedItem == null || RoundComboBox.SelectedItem == null)
            {
                MessageBox.Show("Must select Division, Date and Round");
            }
            else
            {
                FillResultsTable();
            }
        }

        void FillResultsTable()
        {
            DataTable dt = new DataTable();

            string[] teams = new string[] { "FakeTeam1", "FakeTeam2", "FakeTeam3", "FakeTeam4", "FakeTeam5", "FakeTeam6" };


            DataColumn AuthorId = new DataColumn("Home Team", typeof(string));
            DataColumn FirstName = new DataColumn("Score", typeof(string));
            DataColumn Surname = new DataColumn("Away Team", typeof(string));
            DataColumn TaxFileNumber = new DataColumn("TScore", typeof(string));

            dt.Columns.Add(AuthorId);
            dt.Columns.Add(FirstName);
            dt.Columns.Add(Surname);
            dt.Columns.Add(TaxFileNumber);

            for (var i = 0;i < 6;i += 2)
            {
                Random r = new Random();
                DataRow _row = dt.NewRow();
                _row[0] = $"{teams[i]}";
                _row[1] = r.Next(1, 100).ToString();
                _row[2] = $"{teams[i + 1]}";
                _row[3] = r.Next(1, 100).ToString();
                dt.Rows.Add(_row);
            }
            ResultsGrid.ItemsSource = dt.DefaultView;
        }

        private void UpdateLadder_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ladder updated!");
        }

        private void ViewLadder_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\cbfbro\Source\Repos\EDSLProtoTypeNew\EDSLProtoTypeNew\Ladder.pdf");
        }
    }
}
