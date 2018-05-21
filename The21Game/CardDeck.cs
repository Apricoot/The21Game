using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The21Game
{
    class CardDeck
    {
        
        public List<Card> cardList = new List<Card>();
        private Random random = new Random();
        Card card = new Card();
        Random r = new Random();

        /// <summary>
        /// Создает колоду 
        /// </summary>
        /// <returns></returns>
        public List<Card> CreateCardDeck()
        {
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 0; value <= 8; value++)
                {
                    cardList.Add(new Card((CardType)value, (CardSuit)suit));
                }
            }
            
            return cardList;
        }

        /// <summary>
        /// Метод перемешивает созданную колоду. Подсмотрен у Эндрю Стилмена
        /// </summary>
        public void Shuffle()
        {
            List<Card> NewCards = new List<Card>();
            while (cardList.Count > 0)
            {
                int CardToMove = random.Next(cardList.Count);
                NewCards.Add(cardList[CardToMove]);
                cardList.RemoveAt(CardToMove);
            }
            cardList = NewCards;
        }
        /// <summary>
        /// достает рандомную карту из колоды
        /// </summary>
        /// <returns></returns>
        public Card GiveCardRandom()
        {
            int cardNumber = random.Next(cardList.Count);
            Card cardToMove = cardList[cardNumber];
            cardList.RemoveAt(cardNumber);

            return cardToMove;

        }
        /// <summary>
        /// достает последнюю карту из колоды
        /// </summary>
        /// <returns></returns>
        public Card GiveCardLast()
        {
            int cardNumber = (cardList.Count - 1);
            Card cardToMove = cardList[cardNumber];
            cardList.RemoveAt(cardNumber);

            return cardToMove;

        }
        

        /// <summary>
        /// возвращает булево значение тру если колода полна
        /// </summary>
        /// <returns></returns>
        public bool CardDeckFull()
        {
            if (cardList.Count == 32)
            {
                return false;
            }
            return true;
        }
      
    }
}
