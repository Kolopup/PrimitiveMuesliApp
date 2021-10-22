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
    /// Interaction logic for EvaluationWindow.xaml
    /// </summary>
    public partial class EvaluationWindow : Window
    {
        Model.Candidates candidate;
        List<Model.Criteria> criterias;
        int criteriaCounter = 0;
        public EvaluationWindow(Model.Candidates c, Pages.MainMenuPage mainMenuPage)
        {
            InitializeComponent();
            TBChampionShipName.Text = $"{((Model.Competitions)mainMenuPage.DGCompetition.SelectedItem).Name} ({((Model.Competitions)mainMenuPage.DGCompetition.SelectedItem).Year})";
            candidate = c;
            if(MainWindow.db.Evaluation.FirstOrDefault(b=>b.CandidateId == candidate.Id) != null)
            {
                List<Model.Evaluation> evaluations = MainWindow.db.Evaluation.Where(n => n.CandidateId == candidate.Id).ToList();
                foreach(var v in evaluations)
                {
                    MainWindow.db.Evaluation.Remove(v);
                }
                MainWindow.db.SaveChanges();
            }
            TBCandidateName.Text = candidate.Name;
            criterias = MainWindow.db.Criteria.Where(b => b.CompetitionId == candidate.CompetitionId).OrderBy(b => b.Nr).ToList();
            RBNo.IsChecked = true;
            SetCreteria();
        }
        private void SetCreteria()
        {
            if (criteriaCounter <= 0)
            {
                criteriaCounter = 0;
                BBackCriterion.IsEnabled = false;
            }
            else
            {
                BBackCriterion.IsEnabled = true;
            }
            if (criteriaCounter >= criterias.Count - 1)
            {
                criteriaCounter = criterias.Count - 1;
                BNextCriterion.IsEnabled = false;
            }
            else
            {
                BNextCriterion.IsEnabled = true;
            }
            var selectedCriteria = criterias[criteriaCounter];
            if (selectedCriteria.IsCompleted == true)
            {
                RBYes.IsChecked = true;
                RBNo.IsChecked = false;
            }
            if (selectedCriteria.IsCompleted == false)
            {
                RBYes.IsChecked = false;
                RBNo.IsChecked = true;
            }
            TBCreterionId.Text = $"Criterion #{selectedCriteria.Nr.ToString()}";
            TBCriterionText.Text = selectedCriteria.Criterion;

        }
        private void BSubmit_Click(object sender, RoutedEventArgs e)
        {
            foreach(var c in criterias)
            {
                Model.Evaluation evaluation = new Model.Evaluation() { CandidateId = candidate.Id, CriterionId = c.Id, IsCompleted = c.IsCompleted };
                MainWindow.db.Evaluation.Add(evaluation);
            }
            MainWindow.db.SaveChanges();
            MessageBox.Show("Evaulation Compeleted");
            this.Close();
        }
        private void BBackCriterion_Click(object sender, RoutedEventArgs e)
        {
            criteriaCounter--;
            SetCreteria();
        }

        private void BNextCriterion_Click(object sender, RoutedEventArgs e)
        {
            criteriaCounter++;
            SetCreteria();
        }

        private void RBNo_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton)
            {
                criterias[criteriaCounter].IsCompleted = false;
            }
        }

        private void RBYes_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton)
            {
                criterias[criteriaCounter].IsCompleted = true;
            }
        }

    }
}
