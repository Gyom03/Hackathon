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
        public void Chiffrage()
        {
            byte[] ASCIIvalues = Encoding.ASCII.GetBytes(Code_box.Text);
            string mdpchiffre = "";

            foreach (var value in ASCIIvalues)
            {
                string blc = value.ToString();
                int enInt = Int32.Parse(blc);
                enInt = enInt + 8;
                byte[] numberBytes = BitConverter.GetBytes(enInt);
                mdpchiffre = Encoding.UTF8.GetString(numberBytes);
                MessageBox.Show(mdpchiffre);

            }

        }

        private void Bouton_création_de_compte_Click(object sender, RoutedEventArgs e)
        {
            Chiffrage();
        }
    }
}
