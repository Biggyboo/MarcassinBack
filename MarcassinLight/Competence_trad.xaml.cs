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
    /// Logique d'interaction pour Competence_trad.xaml
    /// </summary>
    public partial class Competence_trad : Page
    {
        public List<Competence_BO> listCompetences;
        public Competence_trad()
        {
            InitializeComponent();
            listCompetences = Appel_List.GetCompetences();
            list.ItemsSource = listCompetences;
        }
        private void list_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate((new Competence_trad_list(((Competence_BO)list.SelectedItem))));

        }
    }
}
