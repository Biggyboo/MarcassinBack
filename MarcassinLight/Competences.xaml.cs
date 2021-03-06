﻿using System;
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
using MarcassinLightBLL;
using MarcassinLightBO;

namespace MarcassinLight
{
    /// <summary>
    /// Logique d'interaction pour Competences.xaml
    /// </summary>
    public partial class Competences : Page
    {
        public List<Competence_BO> listCompetences;
        public Competences()
        {
            InitializeComponent();
            listCompetences = Appel_List.GetCompetencesArchives();
            list.ItemsSource = listCompetences;
        }

        private void list_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
                NavigationService.Navigate((new UpdateCompetence(((Competence_BO)list.SelectedItem))));

        }
    }
}
