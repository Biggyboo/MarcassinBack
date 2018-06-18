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
    /// Interaction logic for Create_Langues_Categories.xaml
    /// </summary>
    public partial class Create_Langues_Categories : Page
    {
        public List<Categorie_BO> listCategories;
        public List<Langue_BO> listLangues;
        public Create_Langues_Categories()
        {
            InitializeComponent();
            listCategories = Appel_List.GetCategories();
            C2.ItemsSource = listCategories;
            listLangues = Appel_List.GetLangues();
            C3.ItemsSource = listLangues;
        }

        private void Validation_Click(object sender, RoutedEventArgs e)
        {
            var lang_cat = new LangueCategorie_BO
            {
                Langue = C3.Text,
                Categorie = C2.Text,
                Traduction = C1.Text
                 
            };
            Create.CreateLangueCategorie(lang_cat);

            this.NavigationService.Navigate(new Uri("Langues_Categories.xaml", UriKind.Relative));
        }
    }
}
