using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Chamutalz_BlackJack
{
    class Game
    {
        public bool UserWon { get; set; }
        public bool ComputerWon { get; set; }
        public int UserScore { get; set; }
        public int ComputerScore { get; set; }
        public Deck Deck { get; set; }
        public BitmapImage cardImageC { get; set; }
        public BitmapImage cardImage { get; set; }

        public Game()
        {
            UserWon = false;
            ComputerWon = false;
            UserScore = 0;
            ComputerScore = 0;
            Deck = new Deck();
            
            
        }

        public void ComputerMove()
        {
            Card computerPlay = Deck.DrawCard();
            int rank = computerPlay.GetValue();
            this.cardImageC = computerPlay.CardFaceImage();
            this.ComputerScore = this.ComputerScore + rank;
            if (this.ComputerScore == 21)
            { this.ComputerWon = true; }
            if (this.ComputerScore > 21)
            { this.UserWon = true; }
        }


        public void UserMove()
        {
            Card playerPlay = Deck.DrawCard();
            int rank1 = playerPlay.GetValue();
            this.cardImage = playerPlay.CardFaceImage();
            this.UserScore = this.UserScore + rank1;
            if (this.UserScore == 21)
            { this.UserWon = true; }
            if (this.UserScore > 21)
            { this.ComputerWon = true; }

        }
       

    }
}

