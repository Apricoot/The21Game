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

            while (true)
            {
                myCard.GiveCard();
                Console.WriteLine(myCard.ToString());
                Thread.Sleep(1000);
            }
        }
    }
}
