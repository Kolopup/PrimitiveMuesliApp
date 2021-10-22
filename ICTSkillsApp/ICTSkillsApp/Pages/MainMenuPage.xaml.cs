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

namespace ICTSkillsApp.Pages
{
    /// <summary>
    /// Interaction logic for MainMenuPage.xaml
    /// </summary>
    public partial class MainMenuPage : Page
    {
        public MainMenuPage()
        {
            InitializeComponent();
            DGCompetition.ItemsSource = MainWindow.db.Competitions.ToList();
        }

        private void BRemoveCompetition_Click(object sender, RoutedEventArgs e)
        {
            if (DGCompetition.SelectedItem == null)
            {
                MessageBox.Show("Select Item To Delete Him");
                return;
            }
            MainWindow.db.Competitions.Remove((Model.Competitions)DGCompetition.SelectedItem);
            MainWindow.db.SaveChanges();
            DGCompetition.ItemsSource = null;
            DGCompetition.ItemsSource = MainWindow.db.Competitions.ToList();
        }

        private void BAddCompetition_Click(object sender, RoutedEventArgs e)
        {
            Windows.AddCompetitionWindow addCompetitionWindow = new Windows.AddCompetitionWindow(this);
            addCompetitionWindow.Show();
        }

        private void BEvaluationCriteria_Click(object sender, RoutedEventArgs e)
        {
            if (DGCompetition.SelectedItem == null)
            {
                MessageBox.Show("Select Item To See Evaluation Criteria Page");
                return;
            }
            NavigationService.Navigate(new EvaluationCriteriaPage((Model.Competitions)DGCompetition.SelectedItem));
        }

        private void BRanking_Click(object sender, RoutedEventArgs e)
        {
            if (DGCompetition.SelectedItem == null)
            {
                MessageBox.Show("Select Item To See Competition Ranking Table");
                return;
            }
            NavigationService.Navigate(new Pages.RankingPage((Model.Competitions)DGCompetition.SelectedItem));
        }

        private void BAddCandidate_Click(object sender, RoutedEventArgs e)
        {
            Windows.AddCandidateWindow addCandidateWindow = new Windows.AddCandidateWindow(this);
            addCandidateWindow.Show();
        }
        private void BRemoveCandidate_Click(object sender, RoutedEventArgs e)
        {
            if (DGCandidates.SelectedItem == null)
            {
                MessageBox.Show("Select Item To Delete Him");
                return;
            }
            MainWindow.db.Candidates.Remove((Model.Candidates)DGCandidates.SelectedItem);
            MainWindow.db.SaveChanges();
            DGCandidates.ItemsSource = null;
            DGCandidates.ItemsSource = MainWindow.db.Candidates.ToList();
        }

        private void BEvaluate_Click(object sender, RoutedEventArgs e)
        {
            if (DGCandidates.SelectedItem == null)
            {
                MessageBox.Show("Select Competition to Evaluate Candidate");
                return;
            }
            if (DGCandidates.SelectedItem == null)
            {
                MessageBox.Show("Select Candidate to Evaluate him");
                return;
            }
            Windows.EvaluationWindow evaluationWindow = new Windows.EvaluationWindow((Model.Candidates)DGCandidates.SelectedItem, this);
            evaluationWindow.Show();
        }

        private void DGCompetition_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DGCompetition.SelectedItem == null)
            {
                MessageBox.Show("Select Competition to See Candidate");
                return;
            }
            Model.Competitions candidates = (Model.Competitions)DGCompetition.SelectedItem;
            DGCandidates.ItemsSource = null;
            DGCandidates.ItemsSource = MainWindow.db.Candidates.Where(c => c.CompetitionId == candidates.Id).ToList();
        }
    }
}
