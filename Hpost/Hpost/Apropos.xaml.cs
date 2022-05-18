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
    /// Logique d'interaction pour Apropos.xaml
    /// </summary>
    public partial class Apropos : Window
    {
        List<string> List = new List<string> {"Colis","Chimique","Animal","Frigo"};
        public Apropos()
        {
            InitializeComponent();
            foreach (var item in List)
            {
                ComboBox.Items.Add(item);
                ComboBox.SelectedIndex = 0;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(ComboBox.SelectedItem)
            {
                case "Colis":
                    Specification1.Text = "Ceci est un colis standart";
                break;
                case "Chimique":
                    Specification1.Text = "Ceci est un colis chimique";
                break;
                case "Animal":
                    Specification1.Text = "Ceci est un colis contenant un animal";
                break;
                case "Frigo":
                    Specification1.Text = "Ceci est un colis qui doit etre au frigo";
                break;
            }
        }
    }
}
