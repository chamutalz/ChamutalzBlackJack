using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chamutalz_BlackJack
{
    class Deck
    {
            public Card[] Cards { get; set; }
            public Random RandomGenerator { get; set; }
            public Deck()
              {
                  Cards = new Card[52];
                  int i = 0;
                  foreach (string rank in Card.ValidRanks())
                  {
                    foreach (string suit in Card.ValidSuits())
                     {
                     Card newCard = new Card(suit, rank);
                     Cards[i] = newCard;
                     i++;
                     }
                   }
                }

        public Card DrawCard()
        {
            Random RandomGenerator = new Random();
            int randomNumber = RandomGenerator.Next(0, 52);

            while (Cards[randomNumber] == null)
             {
                randomNumber = RandomGenerator.Next(0, 52);
             }
            Card drawnCard = Cards[randomNumber];
            Cards[randomNumber] = null;
            return drawnCard;
        }
    }
}

