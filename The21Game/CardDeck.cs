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

        public List<Card> ReturnCardDeck()
        {
            for(int i = 0; i < 31; i++)
            {
                cardList.Add(new Card());
            }
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
