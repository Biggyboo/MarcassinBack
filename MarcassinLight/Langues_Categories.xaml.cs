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
    /// Interaction logic for Langues_Categories.xaml
    /// </summary>
    public partial class Langues_Categories : Page
    {
        public List<Categorie_BO> listCategories;
        public Langues_Categories()
        {
            InitializeComponent();
            listCategories = Appel_List.GetCategories();
            list.ItemsSource = listCategories;
        }
        private void Creation_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Create_Langues_Categories());
        }

        private void list_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            NavigationService.Navigate(new Categories_Trad_List(((Categorie_BO)list.SelectedItem)));
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
