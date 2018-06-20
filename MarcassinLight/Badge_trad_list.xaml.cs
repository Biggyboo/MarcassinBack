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
    /// Logique d'interaction pour Bagde_trad_list.xaml
    /// </summary>
    public partial class Bagde_trad_list : Page
    {
        public List<Langue_Badge_BO> ListLanguesBadges;
        public Bagde_trad_list(Badge_BO badBO)
        {
            InitializeComponent();
            ListLanguesBadges = Appel_List.GetTraductionBadge(badBO);
            list.ItemsSource = ListLanguesBadges;
            BadgeName.Content = badBO.Intitule;
           
        }
        private void list_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate((new Update_Badge_Trad(((Langue_Badge_BO)list.SelectedItem))));
        }
    }
}
