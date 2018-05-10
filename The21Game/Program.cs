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
            List<Card> PlayerCard = new List<Card>();
            List<Card> CompCard = new List<Card>();

                      
            myCardDeck.CreateCardDeck();
            myCardDeck.Shuffle();
            Console.WriteLine("choose who pulls the card first!Print - Me or AI");
            A:
            string otvet = Console.ReadLine();
            if(otvet == "Me")
            {

            }
            else if(otvet == "AI")
            {

            }
            else
            {
                Console.WriteLine("you wrote an unsupported option. write \"Me\" or \"AI\" without brackets");
                goto A;
            }

            foreach (Card c in myCardDeck.cardList)
            {
                Console.WriteLine(c.ToString());
                
            }
        }
    }
}
