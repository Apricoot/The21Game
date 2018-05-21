using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The21Game
{
    /// <summary>
    /// хранит инфу о игроках и картах что у них в руках
    /// </summary>
    class Player
    {
        List<Card> cardInHand = new List<Card>();
        public int PlayerCount { get; set; }

        /// <summary>
        /// добавляет карту в руку игроку
        /// </summary>
        /// <param name="card"></param>
        public void GetCard(Card card)
        {
            cardInHand.Add(card);
            PlayerCount += card.cardPoint;

            
        }
        /// <summary>
        /// проверяет условие если 21 то победа
        /// </summary>
        /// <returns></returns>
        public bool Equail()
        {
            if (cardInHand[0].cardType == CardType.Ace & cardInHand[1].cardType == CardType.Ace)
            {
                PlayerCount = 21;
                return true;
               
            }
            return false;
        }
        /// <summary>
        /// выводит инфу о картах и очках игрока
        /// </summary>
        public void Print()
        {
            foreach(Card c in cardInHand)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("\n \r _____ points: {0}",PlayerCount);
            Console.WriteLine();
        }
    }
}
