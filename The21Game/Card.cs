using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The21Game
{

    /// <summary>
    /// types of all cards in the deck
    /// </summary>
    public enum CardType
    {
        Six,// = 6,
        Seven,// = 7,
        Eight,// = 8,
        Nine,// = 9,
        Ten,// = 10,
        Jack,// = 2,
        Lady,// = 3,
        King,// = 4,
        Ace,// = 11
    };

    /// <summary>
    /// Suit of cards
    /// </summary>
    public enum CardSuit
    {
        Diamonds, // Бубна
        Clubs,    // Трефа
        Hearts,   // Черва
        Spades    // Пика

    }

    /// <summary>
    /// В этом классе описываем обьект карта его поля
    /// </summary>
    class Card
    {
        public CardType cardType;
        public CardSuit cardSuit;
        public int cardPoint;
        

        Random random = new Random();

        public Card() { }

        public Card(int ctype, int csuit)
        {

        }

        public Card(CardType ct, CardSuit cs)
        {
            cardType = ct;
            cardSuit = cs;
            int point = 0;

            switch ((int)ct)
            {
                case 0:
                    //cardType = CardType.Six;
                    point = 6;
                    break;
                case 1:
                    //cardType = CardType.Seven;
                    point = 7;
                    break;
                case 2:
                    //cardType = CardType.Eight;
                    point = 8;
                    break;
                case 3:
                    //cardType = CardType.Nine;
                    point = 9;
                    break;
                case 4:
                    //cardType = CardType.Ten;
                    point = 10;
                    break;
                case 5:
                    //cardType = CardType.Jack;
                    point = 2;
                    break;
                case 6:
                    //cardType = CardType.Lady;
                    point = 3;
                    break;
                case 7:
                    //cardType = CardType.King;
                    point = 4;
                    break;
                case 8:
                    //cardType = CardType.Ace;
                    point = 11;
                    break;
            }
            cardPoint = point;
        }

        public Card(CardType ct, CardSuit cs, int cp)
        {
            cardType = ct;
            cardSuit = cs;
            cardPoint = cp;
        }

        public int ReturnPointsOfCard(CardType cardType)
        {
            int i;
            return i = (int)cardType;
        }

        
        public Card GiveCard(int crtType, int crtSuit)
        {
            int point = 0;

            switch (crtType)
            {
                case 0:
                    cardType = CardType.Six;
                    point = 6;
                    break;
                case 1:
                    cardType = CardType.Seven;
                    point = 7;
                    break;
                case 2:
                    cardType = CardType.Eight;
                    point = 8;
                    break;
                case 3:
                    cardType = CardType.Nine;
                    point = 9;
                    break;
                case 4:
                    cardType = CardType.Ten;
                    point = 10;
                    break;
                case 5:
                    cardType = CardType.Jack;
                    point = 2;
                    break;
                case 6:
                    cardType = CardType.Lady;
                    point = 3;
                    break;
                case 7:
                    cardType = CardType.King;
                    point = 4;
                    break;
                case 8:
                    cardType = CardType.Ace;
                    point = 11;
                    break;
            }


            switch (crtSuit)
            {
                case 0:
                    cardSuit = CardSuit.Diamonds;
                    break;
                case 1:
                    cardSuit = CardSuit.Clubs;
                    break;
                case 2:
                    cardSuit = CardSuit.Hearts;
                    break;
                case 3:
                    cardSuit = CardSuit.Spades;
                    break;
            }

            Card newCard = new Card(cardType, cardSuit, point );

            return newCard;
        }

        public override string ToString()
        {
            return cardType.ToString() + " " + cardSuit.ToString() + " " + cardPoint;
        }
    }
}
