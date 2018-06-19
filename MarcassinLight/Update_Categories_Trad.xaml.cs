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
    /// Interaction logic for Update_Categories_Trad.xaml
    /// </summary>
    public partial class Update_Categories_Trad : Page
    {
        List<LangueCategorie_BO> listLangueCategorie = new List<LangueCategorie_BO>();
        public int catId;
        public string Langue;
        public Update_Categories_Trad(LangueCategorie_BO lanCat)
        {
            InitializeComponent();
            listLangueCategorie.Add(lanCat);
            CategorieName.Content = lanCat.Categorie;

            list.ItemsSource = listLangueCategorie;
            catId = lanCat.Id_Categorie;
            Langue = lanCat.Langue;

        }

        private void Modification_Click(object sender, RoutedEventArgs e)
        {

            LangueCategorie_BO lanCatBO = new LangueCategorie_BO
            {
                
                Categorie = CategorieName.Content.ToString(),
                Langue = Langue ,
                Traduction = C1.Text,
                Id_Categorie = catId

            };
            Update.UpdateLangueCategorie(lanCatBO);
            List<Categorie_BO> listCat = Appel_List.GetCategories();
            Categorie_BO Cat = listCat.Find(x => x.Id_Categorie == catId);
            this.NavigationService.Navigate(new Categories_Trad_List(Cat));
            
        }
    }
}
