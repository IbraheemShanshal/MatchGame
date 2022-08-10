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

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        //our constructor methode inside the main methode
        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>() // we will learn more about the "new" keyword in chapter 3, we are initializing a new list of strings
            {
                "🦄","🦄",
                "🐉","🐉",
                "🐄","🐄",
                "🐒","🐒",
                "حسن","حسن",
                "رنيم","رنيم",
                "دعاء","دعاء",
                "🐍","🐍",
            };
            Random random = new Random(); //to generate random number for the index
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>()) //loop to get the animals inside the grid 
            {
                int index = random.Next(animalEmoji.Count);  
                string nextEmoji = animalEmoji[index];       
                textBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
                //the explenation for this code is that animalEmoji is a list, each elemnt in the list has an index that allows us to know what it is, and also each
                //place in the grid has an index of the row and column, so foreach TextBlock that we have we will a random animal signed to it, and after that animal is
                //added we will remove it from the list so it doesn't get back again
            }
        }
        
    }
}
