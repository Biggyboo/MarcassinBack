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
    /// Interaction logic for UpdateCategorie.xaml
    /// </summary>
    public partial class UpdateCategorie : Page
    {
        public List<Categorie_BO> listCategoriesMere;
        public int id;
        public UpdateCategorie(Categorie_BO catBO)
        {
            InitializeComponent();
            C1.Text = catBO.Intitule;
            listCategoriesMere = Appel_List.GetCategories();
            listCategoriesMere.RemoveAt(listCategoriesMere.FindIndex(x => x.Intitule == catBO.Intitule));

            var catMere = new Categorie_BO
            {
                Intitule = "Aucune catégorie mère"
            };
            if(catBO == null)
            {
                catBO.Categorie_mere = "Aucune catégorie mère";
            }
            listCategoriesMere.Add(catMere);
            C2.ItemsSource = listCategoriesMere;
            C2.SelectedItem = catBO.Categorie_mere;
            id = catBO.Id_Categorie;
        }

        private void Modification_Click(object sender, RoutedEventArgs e)
        {
            Categorie_BO catBO = new Categorie_BO
            {
                Categorie_mere = C2.Text,
                Intitule = C1.Text,
                Id_Categorie = id
            };
            Update.UpdateCategorie(catBO);
            this.NavigationService.Navigate(new Uri("Categories.xaml", UriKind.Relative));

        }
    }
}
