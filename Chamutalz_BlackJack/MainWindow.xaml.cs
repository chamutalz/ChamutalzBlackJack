using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chamutalz_BlackJack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            pass.Visibility = Visibility.Hidden;
            drawOneMore.Visibility = Visibility.Hidden;
        }
        
        bool passCard = false;
        bool drawAnother = false;
        bool aNewGameHasStarted = false;
        int games = 0;
        Game game1;
        

        private void startGame(object sender, RoutedEventArgs e)
        {
            
            aNewGameHasStarted = true;
            drawAnother = false;
            passCard = false;
            games ++;
            dealerScoreInt.Clear();
            playerScore.Clear();
            game1 = new Game();
            card1.Source = null;
            card1d.Source = null;
            card2.Source = null;
            card2d.Source = null;
            card3.Source = null;
            card3d.Source = null;
            label1.Visibility = Visibility.Hidden;
            label2.Visibility = Visibility.Hidden;
            

            if (aNewGameHasStarted == true)
            {
                game1.ComputerMove();
                card1d.Source = game1.cardImageC;
                game1.ComputerMove();
                dealerScoreInt.Text = game1.ComputerScore.ToString();
                card2d.Source = game1.cardImageC;
                game1.UserMove();
                card1.Source = game1.cardImage;
                game1.UserMove();
                playerScore.Text = game1.UserScore.ToString();
                card2.Source = game1.cardImage;
                Thread.Sleep(1030);
                if (game1.UserWon == true)
                {
                    label2.Content = "Congragulations! You won\n Click New Game to start again";
                    label2.Visibility = Visibility.Visible;
                    pass.IsEnabled = false;
                    drawOneMore.IsEnabled = false;
                }
                else if (game1.ComputerWon == true)
                {
                    label2.Content = "Your blood has been completely drained.\n The dealer won the game\n Click New Game to start again";
                    label2.Visibility = Visibility.Visible;
                    pass.IsEnabled = false;
                    drawOneMore.IsEnabled = false;
                }
                else
                {
                    label1.Content = "Click More blood to draw another card, or take your chances and pass";
                    label1.Visibility = Visibility.Visible;
                    drawOneMore.IsEnabled = true;
                    pass.IsEnabled = true;
                    pass.Visibility = Visibility.Visible;
                    drawOneMore.Visibility = Visibility.Visible;
                  
                }
                aNewGameHasStarted = false;
            }
        }

        private void Pass(object sender, RoutedEventArgs e)
        {
            passCard = true;
            label1.Visibility = Visibility.Hidden;
            label2.Visibility = Visibility.Hidden;
            if (passCard == true)
            {
                game1.ComputerMove();
                dealerScoreInt.Text = game1.ComputerScore.ToString();
                card3d.Source = game1.cardImageC;
                
                if (game1.UserWon == true)
                    {
                        label2.Content = "That was lucky! You won\n Click New Game to start again";
                        label2.Visibility = Visibility.Visible;
                        pass.IsEnabled = false;
                        drawOneMore.IsEnabled = false;
                    }
                 else if (game1.ComputerWon == true)
                    {
                        label2.Content = "Your blood has been completely drained.\n You should have taken more.\n The dealer won\n Click New Game to start again";
                        label2.Visibility = Visibility.Visible;  
                        pass.IsEnabled = false;
                        drawOneMore.IsEnabled = false;
                    }
                   else
                        {
                            label1.Content = "Click More blood to draw another card, or take your chances and pass";
                            label1.Visibility = Visibility.Visible;
                            drawOneMore.IsEnabled = true;
                            pass.IsEnabled = true;
                        }          
              }
            passCard = false;
        }

        private void DrawAnotherCard(object sender, RoutedEventArgs e)
        {
            drawAnother = true;
            label1.Visibility = Visibility.Hidden;
            label2.Visibility = Visibility.Hidden;
            if (drawAnother == true)
            {
                game1.ComputerMove();
                dealerScoreInt.Text = game1.ComputerScore.ToString();
                card3d.Source = game1.cardImageC;
                game1.UserMove();
                playerScore.Text = game1.UserScore.ToString();
                card3.Source = game1.cardImage;
               

                if (game1.UserWon == true)
                {
                        label2.Content = "Good thing you took another one! You won\n Click New Game to start again";
                        label2.Visibility = Visibility.Visible;
                        drawOneMore.IsEnabled = false;
                        pass.IsEnabled = false;
                      }
                else if (game1.ComputerWon == true)
                       {
                          label2.Content = "Your blood has been completely drained. The dealer won the game\n Click New Game to start again";
                          label2.Visibility = Visibility.Visible;
                          drawOneMore.IsEnabled = false;
                          pass.IsEnabled = false;
                       }
                else 
                   {
                        label1.Content = "Click More blood to draw another card, or take your chances and pass";
                        label1.Visibility = Visibility.Visible;
                        drawOneMore.IsEnabled = true;
                        pass.IsEnabled = true;
                   
                    }
             }
            drawAnother = false;
          }

       

        private void ShowAbout(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Programming & Graphic Design: Chamutal Zered\n Made by Visual Studio 2015");
        }
        
    }
}
