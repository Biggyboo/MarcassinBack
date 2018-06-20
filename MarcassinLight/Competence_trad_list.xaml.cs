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
    /// Logique d'interaction pour Competence_trad_list.xaml
    /// </summary>
    public partial class Competence_trad_list : Page
    {
        public Dictionary<string,string> listtrad;

        public Competence_trad_list(Competence_BO compBO)
        {
            InitializeComponent();
            listtrad = Appel_List.GetTradCompetence(compBO);

            list1.ItemsSource = listtrad.Keys;
            Intitule.Content = compBO.Competence;
            
        }

        private void list1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            trad.Text = listtrad[list1.SelectedValue.ToString()];
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            string[] traduc = new string[] {Intitule.Content.ToString(), list1.SelectedValue.ToString(), trad.Text.ToString() };
            MarcassinLightBLL.Update.UpdateTrad(traduc);

            NavigationService.Navigate(new Competence_trad());
        }
    }
}
