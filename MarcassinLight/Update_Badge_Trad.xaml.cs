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
    /// Logique d'interaction pour Update_Badge_Trad.xaml
    /// </summary>
    public partial class Update_Badge_Trad : Page
    {
        Langue_Badge_BO lanbadBO = new Langue_Badge_BO();
        public Update_Badge_Trad(Langue_Badge_BO badBO)
        {
            InitializeComponent();
            C1.Text = badBO.Traduction;
            lanbadBO = badBO;
        }

        private void Modification_Click(object sender, RoutedEventArgs e)
        {
            lanbadBO.Traduction = C1.Text;           
            Update.UpdateBadgeTrad(lanbadBO);
            List<Badge_BO> listBadges = Appel_List.GetBadges();
            Badge_BO bag = listBadges.Find(x => x.Id_Badge == lanbadBO.Badge);
            this.NavigationService.Navigate(new Bagde_trad_list(bag));  
        }
    }
}
