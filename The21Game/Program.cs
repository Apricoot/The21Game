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
            //хранит количество побед
            int playerWinCount = 0;
            int aiWinCount = 0;

            S:
            
            CardDeck myCardDeck = new CardDeck();
            
            Player Me = new Player();
            Player AI = new Player();

            
            //хранит выбор кто первый ходит
            bool iBankir;

            //создаем колоду и перемешиваем ее          
            myCardDeck.CreateCardDeck();
            myCardDeck.Shuffle();

            //выбираем кто будет сдавать(банковать)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r Choose who pulls the card first!Print - Me or AI");
            
            A:
            string otvet = Console.ReadLine();
            if (otvet == "Me" | otvet == "me" | otvet == "mE" | otvet == "ME")
            {
                iBankir = true;
                
            }
            else if (otvet == "AI" | otvet =="ai" | otvet == "aI" | otvet == "Ai")
            {
                iBankir = false;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\r You wrote an unsupported option. write \"Me\" or \"AI\" without brackets");
                Console.WriteLine();
                goto A;
            }
            
            if (iBankir)
            {
                //получаем две карты
                Me.GetCard(myCardDeck.GiveCardLast());
                Me.GetCard(myCardDeck.GiveCardLast());

                //вывод в консоль
                Console.WriteLine("\r You got this cards:");
                Console.ForegroundColor = ConsoleColor.Green;
                Me.Print();
                Console.ForegroundColor = ConsoleColor.Yellow;

                //если два туза то победа
                if (Me.Equail())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\rYou win!!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    playerWinCount++;
                    goto E;
                }
                //вопрос о доп карте
                Console.WriteLine("\r You wont one more card? Print Yes or Not");
                B:
                string otvet2 = Console.ReadLine();

                if(otvet2 == "Yes" | otvet2 == "yes" | otvet2 == "yEs" | otvet2 == "yeS")
                {
                    Me.GetCard(myCardDeck.GiveCardLast());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Me.Print();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    if (Me.PlayerCount > 21)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\r You Lose!");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        aiWinCount++;
                        goto E;
                    }
                    else
                    {
                       
                        //нужна ли еще карта?
                        Console.WriteLine("\r Do you wont one more card? Print Yes or Not");
                        goto B;
                    }
                }
                else if(otvet2 == "Not" | otvet2 == "not" | otvet2 == "nOt" | otvet2 == "noT")
                {
                    //игрок не захотел брать карту
                }
                else
                {
                    Console.WriteLine("\r You wrote unsuported word. Please write Yes or Not");
                    goto B;
                }

                //ходи ии после игрока
                AI.GetCard(myCardDeck.GiveCardLast());
                AI.GetCard(myCardDeck.GiveCardLast());
                Console.WriteLine("\r Ai got cards:");
                AI.Print();
                if (AI.Equail())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r AI win!!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    aiWinCount++;
                    goto E;
                }
                C:
                if (AI.PlayerCount < 15)
                {
                    Console.WriteLine("\r AI decided take one more card!");
                    AI.GetCard(myCardDeck.GiveCardLast());
                    AI.Print();

                }
                if (AI.PlayerCount < 15)
                {
                    goto C;
                }
                if (AI.PlayerCount > 21)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\r AI got {0} points. AI lose!", AI.PlayerCount);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    playerWinCount++;
                    goto E;
                }

                //сравнение очков игроков
                if (Me.PlayerCount > AI.PlayerCount)
                {
                    Console.WriteLine("\r You win with {0} points, AI got {1} points!", Me.PlayerCount, AI.PlayerCount);
                    playerWinCount++;
                    goto E;
                }
                else
                {
                    Console.WriteLine("\r You lose with {0} points, AI win with {1} points!", Me.PlayerCount, AI.PlayerCount);
                    aiWinCount++;
                    goto E;
                }

            }//логика за ИИ
            else 
            {
                
                AI.GetCard(myCardDeck.GiveCardLast());
                AI.GetCard(myCardDeck.GiveCardLast());
                Console.WriteLine("\r Ai got cards:");
                AI.Print();
                if (AI.Equail())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r AI win!!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    aiWinCount++;
                    goto E;
                }
                C:
                if(AI.PlayerCount < 15)
                {
                    Console.WriteLine("\r AI decided take one more card!");
                    AI.GetCard(myCardDeck.GiveCardLast());
                    AI.Print();

                }
                if(AI.PlayerCount < 15)
                {
                    goto C;
                }
                if(AI.PlayerCount > 21)
                {
                    Console.WriteLine("\r AI got {0} points. AI lose!", AI.PlayerCount);
                    playerWinCount++;
                    goto E;
                }

                // ход игрока после ИИ

                Me.GetCard(myCardDeck.GiveCardLast());
                Me.GetCard(myCardDeck.GiveCardLast());

                //вывести в консоль данные нужен один метод
                Console.WriteLine("\r You got this cards:");
                Me.Print();
                //если два туза то победа
                if (Me.Equail())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\r You win!!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    playerWinCount++;
                    goto E;
                }
                //вопрос о доп карте
                Console.WriteLine("\r You wont one more card? Print Yes or Not");
                G:
                string otvet2 = Console.ReadLine();

                if (otvet2 == "Yes" | otvet2 == "yes" | otvet2 == "yEs" | otvet2 == "yeS")
                {
                    Me.GetCard(myCardDeck.GiveCardLast());
                    Me.Print();
                    if (Me.PlayerCount > 21)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\r You Lose!");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        aiWinCount++;
                        goto E;
                    }
                    else
                    {
                        //нужна ли еще карта?
                        Console.WriteLine("\r Do you wont one more card? Print Yes or Not");
                        goto G;
                    }
                }
                else if (otvet2 == "Not" | otvet2 == "not" | otvet2 == "nOt" | otvet2 == "noT")
                {

                }
                else
                {
                    Console.WriteLine("\r You wrote unsuported word. Please write Yes or Not");
                    goto G;
                }

                //сравнение очков игроков
                if(Me.PlayerCount > AI.PlayerCount)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\r You win with {0} points, AI got {1} points!",Me.PlayerCount,AI.PlayerCount);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    playerWinCount++;
                    goto E;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\r You lose with {0} points, AI win with {1} points!",Me.PlayerCount,AI.PlayerCount);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    aiWinCount++;
                    goto E;
                }

            }

            // код завершающий игру!
            E:
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n \r You win {0} time(s), AI win {1} time(s). \n You wont play one more time? Print Yes or No.", playerWinCount, aiWinCount);
            Console.ForegroundColor = ConsoleColor.Yellow;
            string otvet3 = Console.ReadLine();

            if (otvet3 == "Yes" | otvet3 == "yes" | otvet3 == "yEs" | otvet3 == "yeS")
            {
                Console.WriteLine("\n You start a new game!");
                Console.WriteLine();
                goto S;

            }
            else if (otvet3 == "No" | otvet3 == "no" | otvet3 == "nO")
            {
                Console.WriteLine("\n You decided end the game. Good luck");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("\r You wrote unsuported word. Please write Yes or No");
                goto E;
                
            }

        }
        
    }
   
   
}
