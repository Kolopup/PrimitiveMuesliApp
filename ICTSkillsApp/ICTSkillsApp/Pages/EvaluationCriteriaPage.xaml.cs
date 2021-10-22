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
    /// Interaction logic for EvaluationCriteriaPage.xaml
    /// </summary>
    public partial class EvaluationCriteriaPage : Page
    {
        public Model.Competitions competition;
        public EvaluationCriteriaPage(Model.Competitions c)
        {
            InitializeComponent();
            competition = c;
            DGCriterion.ItemsSource = MainWindow.db.Criteria.Where(b => b.CompetitionId == competition.Id).OrderBy(b => b.Nr).ToList();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            Windows.AddCreationWindow addCreationWindow = new Windows.AddCreationWindow(this);
            addCreationWindow.Show();
        }

        private void BRemove_Click(object sender, RoutedEventArgs e)
        {
            if (DGCriterion.SelectedItem == null)
            {
                MessageBox.Show("Select Criterion");
                return;
            }
            Model.Criteria selectedItem = (Model.Criteria)DGCriterion.SelectedItem;
            DGCriterion.ItemsSource = MainWindow.db.Criteria.Where(b => b.CompetitionId == competition.Id).OrderBy(c => c.Nr).ToList();

        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
