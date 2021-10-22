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
    /// Interaction logic for RankingPage.xaml
    /// </summary>
    public partial class RankingPage : Page
    {
        public RankingPage(Model.Competitions competition)
        {
            InitializeComponent();
            TBChampionship.Text = $"{competition.Name} ({competition.Year})";
            var candidates = MainWindow.db.Candidates.Where(c => c.CompetitionId == competition.Id).ToList();
            foreach(var c in candidates)
            {
                foreach(var b in c.Evaluation)
                {
                    if(b.IsCompleted == true)
                    {
                        c.Points += b.Criteria.Points;
                    }
                }
            }
            List<Model.Candidates> sortCandidate = candidates.OrderBy(c=>c.Points).ToList();
            sortCandidate.Reverse();
            int rank = 1;
            foreach(var c in sortCandidate)
            {
                c.Rank = rank;
                rank++;
            }
            DGRank.ItemsSource = sortCandidate;
        }
    }
}
