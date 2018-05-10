using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace The21Game
{
    

    class Program
    {
        static void Main(string[] args)
        {
            
            Card myCard = new Card();
            CardDeck myCardDeck = new CardDeck();

            //while (true)
            //{
            //    //myCard.GiveCard();
            //    //Console.WriteLine(myCard.ToString());
            //    //Thread.Sleep(1000);

            //    //while (myCardDeck.CardDeckFull())
            //    //{
            //    //    myCardDeck.GiveCardFromDeck();
            //    //    //myCardDeck.cardList.ToString();
            //    //}

                

                
                
            //    //Thread.Sleep(1000);



            //}
            myCardDeck.CreateCardDeck();

            foreach (Card c in myCardDeck.cardList)
            {
                Console.WriteLine(c.ToString());
                //Thread.Sleep(1000);
            }
        }
    }
}
