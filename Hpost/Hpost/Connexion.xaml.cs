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
using System.Windows.Shapes;

namespace Hpost
{
    /// <summary>
    /// Logique d'interaction pour Connexion.xaml
    /// </summary>
    public partial class Connexion : Window
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Bouton_connexion_Click(object sender, RoutedEventArgs e)
        {

        }
        public string Chiffrage(string mdpchiffre)
        {
            byte[] ASCIIvalues = Encoding.ASCII.GetBytes(Code_box.Text);
            mdpchiffre = "";
            foreach (var value in ASCIIvalues)
            {
                mdpchiffre += value.ToString(); 
            }
                return mdpchiffre ;
        }
    }
}
