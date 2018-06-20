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
    /// Logique d'interaction pour Update_Badge.xaml
    /// </summary>
    public partial class Update_Badge : Page
    {
        public int id;
        public Update_Badge(Badge_BO badBO)
        {
            InitializeComponent();
            C1.Text = badBO.Intitule;
            id = badBO.Id_Badge;
            
        }

        private void Modification_Click(object sender, RoutedEventArgs e)
        {
            Badge_BO badBO = new Badge_BO
            {
                Intitule = C1.Text,
                Id_Badge = id

            };
            Update.UpdateBadge(badBO);
            this.NavigationService.Navigate(new Uri("Badges.xaml", UriKind.Relative));
        }
    }


}
