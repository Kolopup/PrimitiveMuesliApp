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
    /// Interaction logic for AddCandidateWindow.xaml
    /// </summary>
    public partial class AddCandidateWindow : Window
    {
        Pages.MainMenuPage mainMenuPage;
        public AddCandidateWindow(Pages.MainMenuPage c)
        {
            InitializeComponent();
            mainMenuPage = c;
            if (mainMenuPage.DGCompetition.SelectedItem == null)
            {
                mainMenuPage.DGCompetition.SelectedIndex = 0;
            }
            CBCompetition.ItemsSource = MainWindow.db.Competitions.ToList();
            CBCompetition.SelectedItem = (Model.Competitions)c.DGCompetition.SelectedItem;
        }
        private bool Validate()
        {
            string errorResult = "";
            if (string.IsNullOrWhiteSpace(TBName.Text))
            {
                errorResult += "Enter Name\n";
            }
            if(string.IsNullOrWhiteSpace(TBCompany.Text))
            {
                errorResult += "Enter Company\n";
            }
            if(string.IsNullOrWhiteSpace(TBSchool.Text))
            {
                errorResult += "Enter School";
            }
            if(errorResult != "")
            {
                MessageBox.Show(errorResult);
                return false;
            }
            return true;
        }
        private void BAddCandidate_Click(object sender, RoutedEventArgs e)
        {
            if(Validate())
            {
                if(mainMenuPage.DGCompetition.SelectedItem == null)
                {
                    mainMenuPage.DGCompetition.SelectedIndex = 0;
                }
                Model.Candidates candidates = new Model.Candidates() { Name = TBName.Text, Company = TBCompany.Text, School = TBSchool.Text, CompetitionId = ((Model.Competitions)CBCompetition.SelectedItem).Id};
                MainWindow.db.Candidates.Add(candidates);
                MainWindow.db.SaveChanges();
                mainMenuPage.DGCandidates.ItemsSource = null;
                mainMenuPage.DGCandidates.ItemsSource = MainWindow.db.Candidates.Where(c=>c.CompetitionId == ((Model.Competitions)mainMenuPage.DGCompetition.SelectedItem).Id).ToList();
                this.Close();
            }
        }
    }
}
