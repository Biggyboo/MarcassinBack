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
    /// Interaction logic for Categories_Trad_List.xaml
    /// </summary>
    public partial class Categories_Trad_List : Page
    {
        List<LangueCategorie_BO> listLangCat = new List<LangueCategorie_BO>();

        public Categories_Trad_List(Categorie_BO categorie)
        {
            InitializeComponent(); 
            listLangCat = Appel_List.GetLanguesCategoriesByIdCat(categorie);
            list.ItemsSource = listLangCat;
            CategorieName.Content = categorie.Intitule;
        }

        private void list_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Update_Categories_Trad(((LangueCategorie_BO)list.SelectedItem)));
        }
 
    }
}
