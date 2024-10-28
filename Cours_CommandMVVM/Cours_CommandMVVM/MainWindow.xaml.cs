using Cours_CommandMVVM.ViewModels;
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

namespace Cours_CommandMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Les commands limites l'utilisation des events
        //ICommand c'est l'interfaces qui implemente les deux methodes
        //
/*        public ICommand myCommand {  get; set; }
        public ICommand myExit { get; set; }*/
        public MainWindow()
        {
            InitializeComponent();
            /*            myCommand = new CommandeExample(ShowMessage , CanShowMessage);
                        myExit = new CommandeExample(Exit, CanShowMessage);*/

            MainWindowViewModel _vn = new MainWindowViewModel();
            DataContext = _vn;
        }

/*        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Code Behind");
        }*/

/*        bool CanShowMessage(object _parameter)
        {
            return true; 
        }
        void ShowMessage(object _parameter)
        {
            MessageBox.Show("Code Behind");
        }
        void Exit(object _parameter)
        {
            Close();
        }*/
    }
}


//Cela simplifit egaleement le debug , la maintenance et l'explosing du programme , de meme ça limite la quantiter de code behind (.xaml = view)
//Attention vs verrz souvent sur internet que parce que vs utilize rl'architerctur mvvl que le code behind tout erte absolument vide , c'est faux !
//Le code behind et generalement eviter sout simplement car il est inutile , code behind generalement inutile , il n'y a pas de bisnesse logique
//(cela definit les regles d'un programme ) qui regisse comment les deta devrait etre creer transforme communique controller et manager  , il n'y a pas d'appelle
//LE mvvl depend majoritairement du binding , le code behind permet d'etre utiliser spécifiquement pour la view , car dans de rare scenarios on a pas le choix ou trop compliquer


//QUAND FAUT-IL UTILISER MVVL ?
//Quel est la taille ou l'empleur du projet ? Si le projet dure longtemps et/ou plsuieur devellopeur sont presents sur le projet il est preferable d'utiliser l'architecture du projet
//deuxieme raison ,est-ce que le projet va evoluer dans le futur ? Si oui mvvl va stabilser l'archiecture du projet 