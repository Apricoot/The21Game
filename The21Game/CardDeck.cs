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
        Card card = new Card();
        Random r = new Random();

        public List<Card> CreateCardDeck()
        {
            for(int suit = 0; suit <= 3; suit++)
            {
                for(int value = 0; value <= 8; value++)
                {
                    cardList.Add(new Card((CardType)value,(CardSuit)suit));
                }
            }

            //for (int i = 0; i < 31; i++)
            //{
            //    cardList.Add(new Card());
            //}

            //foreach(Card c in cardList)
            //{

            //    if (cardList.Contains<Card>(c))
            //    {
            //        c.GiveCard();

            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //while (cardList.Count != 31)
            //{
            //    Card c = card.GiveCard(r.Next(0, 8), r.Next(0, 3));
            //}
            
            //попытка реализовать колоду. думаю не очень удачная нужно передумать алгоритм
           //foreach(Card c in cardList)
           // {
           //     c.GiveCard();
           //     if (cardList.Contains(c))
           //     {
           //         c.GiveCard();
           //     }
           // }
            return cardList;
        }



        public Card GiveCardFromDeck()
        {
            card = new Card();
            card.GiveCard();

            while (!cardList.Contains(card))
            {
                

                if (cardList.Contains(card))
                {
                    break;
                }
                else
                {
                    //Card newCard = card;
                    cardList.Add(card);
                    return card;
                }
            }
            return card;
            
            
        }
        public bool CardDeckFull()
        {
            if (cardList.Count == 32)
            {
                return false;
            }
            return true;
        }
        //public List<Card> cardDeck = new List<Card>();
    }
}
