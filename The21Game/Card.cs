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
        six = 6,
        seven = 7,
        eight = 8,
        nine = 9,
        ten = 10,
        Jack = 2,
        Lady = 3,
        King = 4,
        Ace = 11
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

        //public int CardPoints { get; set; }

        

        Random random = new Random();

        public Card() { }

        public Card(int ctype, int csuit)
        {

        }

        public Card(CardType ct, CardSuit cs)
        {
            cardType = ct;
            cardSuit = cs;
        }

        public int ReturnPointsOfCard(CardType cardType)
        {
            int i;
            return i = (int)cardType;
        }

        public Card GiveCard()
        {
            Random random = new Random();
            int randomCardType = random.Next(0, 8);
           int randomCardSuit = random.Next(0, 3);

            switch (randomCardType)
            {
                case 0:
                    cardType = CardType.six;
                    break;
                case 1:
                    cardType = CardType.seven;
                    break;
                case 2:
                    cardType = CardType.eight;
                    break;
                case 3:
                    cardType = CardType.nine;
                    break;
                case 4:
                    cardType = CardType.ten;
                    break;
                case 5:
                    cardType = CardType.Jack;
                    break;
                case 6:
                    cardType = CardType.Lady;
                    break;
                case 7:
                    cardType = CardType.King;
                    break;
                case 8:
                    cardType = CardType.Ace;
                    break;
            }


            switch (randomCardSuit)
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

            Card newCard = new Card(cardType, cardSuit);

            return newCard;
        }

        public Card GiveCard(int crtType, int crtSuit)
        {
            //Random random = new Random();
            //int randomCardType = random.Next(0, 8);
            //int randomCardSuit = random.Next(0, 3);

            switch (crtType)
            {
                case 0:
                    cardType = CardType.six;
                    break;
                case 1:
                    cardType = CardType.seven;
                    break;
                case 2:
                    cardType = CardType.eight;
                    break;
                case 3:
                    cardType = CardType.nine;
                    break;
                case 4:
                    cardType = CardType.ten;
                    break;
                case 5:
                    cardType = CardType.Jack;
                    break;
                case 6:
                    cardType = CardType.Lady;
                    break;
                case 7:
                    cardType = CardType.King;
                    break;
                case 8:
                    cardType = CardType.Ace;
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

            Card newCard = new Card(cardType, cardSuit);

            return newCard;
        }

        public override string ToString()
        {
            return cardType.ToString() + " " + cardSuit.ToString();
        }
    }
}
