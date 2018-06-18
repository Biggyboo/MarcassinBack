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
    /// Logique d'interaction pour UpdateCompetence.xaml
    /// </summary>
    public partial class UpdateCompetence : Page
    {
        public List<Categorie_BO> listCategories;
        public List<Competence_BO> listCompetences;
        public int id;
        public UpdateCompetence(Competence_BO compBO)
        {
            InitializeComponent();
            C1.Text = compBO.Competence;
            listCategories = Appel_List.GetCategories();
            C2.ItemsSource = listCategories;
            C2.SelectedItem = compBO.Categorie;
            listCompetences = Appel_List.GetCompetences();
            C3.ItemsSource = listCompetences;
            id = compBO.Id_Competence;

        }

        private void Modification_Click(object sender, RoutedEventArgs e)
        {
            Competence_BO compBO = new Competence_BO
            {
                Competence = C1.Text,
                Categorie = C2.Text,
                Competence_mere = C3.Text,
                Id_Competence = id
                               
            };
            Update.UpdateCompetence(compBO);
            this.NavigationService.Navigate(new Uri("Competences.xaml", UriKind.Relative));
        }
    }
}
