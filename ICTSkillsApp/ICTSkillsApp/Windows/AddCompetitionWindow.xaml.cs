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
using System.Windows.Shapes;

namespace ICTSkillsApp.Windows
{
    /// <summary>
    /// Interaction logic for AddCompetitionWindow.xaml
    /// </summary>
    public partial class AddCompetitionWindow : Window
    {
        Pages.MainMenuPage mainMenuPage;
        public AddCompetitionWindow(Pages.MainMenuPage c)
        {
            InitializeComponent();
            mainMenuPage = c;
        }

        private void BAddCompetition_Click(object sender, RoutedEventArgs e)
        {
            if (Validate())
            {
                Model.Competitions competitions = new Model.Competitions() { Year = Convert.ToInt32(TBYear.Text), Name = TBName.Text };
                MainWindow.db.Competitions.Add(competitions);
                MainWindow.db.SaveChanges();
                mainMenuPage.DataContext = null;
                mainMenuPage.DGCompetition.ItemsSource = MainWindow.db.Competitions.ToList(); 
                this.Close();
            }
        }
        private bool Validate()
        {
            string errorResult = "";
            int result;
            if (!int.TryParse(TBYear.Text, out result))
            {
                errorResult += "Enter Year in Correct Format";
            }
            if (string.IsNullOrWhiteSpace(TBName.Text) || string.IsNullOrWhiteSpace(TBYear.Text))
            {
                errorResult += "Enter Data";
            }
            if (errorResult != "")
            {
                MessageBox.Show(errorResult);
                return false;
            }
            return true;
        }
    }
}
