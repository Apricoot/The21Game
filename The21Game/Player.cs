using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The21Game
{
    class Player
    {
        List<Card> cardInHand = new List<Card>();
        public int PlayerCount { get; set; }

        bool YouWin = false;

        public void GetCard(Card card)
        {
            cardInHand.Add(card);
            PlayerCount += card.cardPoint;

            if (cardInHand[cardInHand.Count] == card)
            {
                Console.WriteLine("Win!");
                
            }
        }

        public bool Equail()
        {
            if (cardInHand[0].cardType == CardType.Ace & cardInHand[1].cardType == CardType.Ace)
            {
                PlayerCount = 21;
                YouWin = true;
                return true;
               
            }
            return false;
        }

        public void Print()
        {
            foreach(Card c in cardInHand)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("Your points: {0}",PlayerCount);
        }
    }
}
