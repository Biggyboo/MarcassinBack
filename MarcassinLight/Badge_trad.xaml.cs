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
    /// Logique d'interaction pour Badge_trad.xaml
    /// </summary>
    public partial class Badge_trad : Page
    {
        public List<Badge_BO> listBadges;
        public Badge_trad()
        {
            InitializeComponent();
            listBadges = Appel_List.GetBadges();
            list.ItemsSource = listBadges;
        }


        private void list_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate((new Bagde_trad_list(((Badge_BO)list.SelectedItem))));
        }
    }
}
