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
            //List<Card> PlayerCard = new List<Card>();
            //List<Card> CompCard = new List<Card>();

            Player Me = new Player();
            Player AI = new Player();

            bool iBankir;

            //создаем колоду и перемешиваем ее          
            myCardDeck.CreateCardDeck();
            myCardDeck.Shuffle();

            //выбираем кто будет сдавать(банковать)
            Console.WriteLine("choose who pulls the card first!Print - Me or AI");
            Console.WriteLine();
            A:
            string otvet = Console.ReadLine();
            if (otvet == "Me")
            {
                iBankir = true;
                Console.WriteLine();
            }
            else if (otvet == "AI")
            {
                iBankir = false;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("you wrote an unsupported option. write \"Me\" or \"AI\" without brackets");
                Console.WriteLine();
                goto A;
            }
            Console.WriteLine("");
            if (iBankir)
            {
                Me.GetCard(myCardDeck.GiveCardLast());
                Me.GetCard(myCardDeck.GiveCardLast());
                //вывести в консоль данные нужен один метод
                Me.Print();
                if (Me.Equail())
                {
                    Console.WriteLine("You win!!");
                    goto E;
                }
            }
            else
            {

            }


            //получаем 2 карты выбираем брать ли карту еще 

            //тоже делает ИИ

            //повторяем или открываем карты





            //foreach (Card c in myCardDeck.cardList)
            //{
            //    Console.WriteLine(c.ToString());

            //}

            // код завершающий игру!
            E:;

        }
        
    }
   
   
}
