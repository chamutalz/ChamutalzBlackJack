using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Chamutalz_BlackJack
{
    class Card
    {
            private static string[] poolOfValidSuits = { "Clubs", "Diamonds", "Hearts", "Spades" };

        public static string[] ValidSuits()
        { return poolOfValidSuits; }

        private static string[] poolOfValidRanks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        public static string[] ValidRanks()
        { return poolOfValidRanks; }


        public string Suit { get; }
        public string Rank { get; }
        

        public Card(string suit, string rank)
        {
            this.Suit = suit;
            this.Rank = rank;
          
      /*      if (this.Suit != poolOfValidSuits[0] && this.Suit != poolOfValidSuits[1] && this.Suit != poolOfValidSuits[2] && this.Suit != poolOfValidSuits[3])
           { MessageBox.Show("The suit does not match any correct card values."); }
            bool check = false;
            int i = 0;
            while (check != true && i < poolOfValidRanks.Length)
            {
                if (this.Rank == poolOfValidRanks[i])
                { check = true; }
                i++;
            }
            if (check == false)
           { MessageBox.Show("The rank does not match any correct card value."); } */
        }

        public int GetValue()
        {
            if (this.Rank != poolOfValidRanks[0] && this.Rank != poolOfValidRanks[10] && this.Rank != poolOfValidRanks[11] && this.Rank != poolOfValidRanks[12])
            {
                int value = int.Parse(this.Rank);
                return value;
            }
            if (this.Rank == poolOfValidRanks[0])
            {
                int value = 1;
                return value;
            }
            if (this.Rank == poolOfValidRanks[10])
            {
                int value = 11;
                return value;
            }
            if (this.Rank == poolOfValidRanks[11])
            {
                int value = 12;
                return value;
            }
            if (this.Rank == poolOfValidRanks[12])
            {
                int value = 13;
                return value;
            }
            else return -1;
        }

        public string GetFace()
        {
            string displayFace = this.Rank + " of " + this.Suit + ".png";
            return displayFace;
    
        }

        public BitmapImage CardFaceImage()
        {
            BitmapImage bi3 = new BitmapImage();
            string fromGetFace = @"C:\Users\Zered\Documents\Visual Studio 2015\Projects\Chamutalz_BlackJack\Chamutalz_BlackJack\" + GetFace();
            bi3.BeginInit();
            bi3.UriSource = new Uri(string.Format("{0}", fromGetFace),UriKind.RelativeOrAbsolute);
            bi3.EndInit();
            return bi3;
        }
      
    }
}

