using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pendu_Vincent_Malitine
{

    string mot =" "; // Le mot à deviner
    string[5] list-mots = {"tuile", "bananaleclerc", "prototype", "nurburgring", "nordschleiffe"}; // Liste de mots possibles
    int vie = 6; // Nombre d'essais restants
    string lettresDevinees = ""; // Lettres déjà devinées
    bool jeuTermine = false; // Indique si le jeu est terminé
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
    {
        char TextBox_Result = ' ';

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Letter_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Content is string content && content.Length == 1)
            {
                TextBox_Result = content[0];
                ResultTextBox.Text = TextBox_Result.ToString();
            }
        }

        private void Button_Done_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}