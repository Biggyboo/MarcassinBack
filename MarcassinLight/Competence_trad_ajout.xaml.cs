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
    /// Logique d'interaction pour Competence_trad_ajout.xaml
    /// </summary>
    public partial class Competence_trad_ajout : Page
    {
        public List<Langue_BO> listLangues;
        public Competence_BO compeBO;
        public Competence_trad_ajout(Competence_BO compBO)
        {
            InitializeComponent();
            listLangues = Appel_List.GetLangues();
            langue.ItemsSource = listLangues;
            comp.Content = compBO.Competence;
            compeBO = compBO;
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            Create.CreateLangueCompetence(compeBO.Id_Competence, langue.Text, trad.Text);

            NavigationService.Navigate(new Competence_trad_list(compeBO));
        }
    }
}
