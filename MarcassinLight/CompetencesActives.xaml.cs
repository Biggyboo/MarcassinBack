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
using MarcassinLightBO;
using MarcassinLightBLL;

namespace MarcassinLight
{
    /// <summary>
    /// Logique d'interaction pour CompetencesActives.xaml
    /// </summary>
    public partial class CompetencesActives : Page
    {
        public List<Competence_BO> listCompetences;
        public CompetencesActives()
        {
            InitializeComponent();
            listCompetences = Appel_List.GetCompetencesActives();
            list.ItemsSource = listCompetences;
        }

        private void Ajout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateCompetence());
        }

        private void Archive_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Competences());
        }
        private void list_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate((new UpdateCompetence(((Competence_BO)list.SelectedItem))));

        }
    }
}
