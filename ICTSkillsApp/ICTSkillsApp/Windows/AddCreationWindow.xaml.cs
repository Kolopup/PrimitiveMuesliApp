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
    /// Interaction logic for AddCreationWindow.xaml
    /// </summary>
    public partial class AddCreationWindow : Window
    {
        Pages.EvaluationCriteriaPage evaluationCriteriaPage;
        public AddCreationWindow(Pages.EvaluationCriteriaPage c)
        {
            InitializeComponent();
            evaluationCriteriaPage = c;
            CBCompetitions.ItemsSource = MainWindow.db.Competitions.ToList();
            CBCompetitions.SelectedItem = c.competition;
        }

        private void BSubmit_Click(object sender, RoutedEventArgs e)
        {
            if(Validate())
            {
                int Nr = MainWindow.db.Criteria.Where(c => c.CompetitionId == evaluationCriteriaPage.competition.Id).ToList().Count + 1;
                Model.Criteria criteria = new Model.Criteria() { CompetitionId = evaluationCriteriaPage.competition.Id, Criterion = TBCreaterian.Text, Points = Convert.ToInt32(TBPoints.Text), Nr =  Nr};
                MainWindow.db.Criteria.Add(criteria);
                MainWindow.db.SaveChanges();
                evaluationCriteriaPage.DGCriterion.ItemsSource = MainWindow.db.Criteria.Where(c => c.CompetitionId == evaluationCriteriaPage.competition.Id).OrderBy(c=>c.Nr).ToList();
                this.Close();
            }
        }
        private bool Validate()
        {
            string result = "";
            if (string.IsNullOrWhiteSpace(TBCreaterian.Text)) result += "Set Criterion Name\n";
            if (string.IsNullOrWhiteSpace(TBPoints.Text)) result += "Set Points";
            if(result != "")
            {
                MessageBox.Show(result);
                return false;
            }
            return true;
        }
    }
}
