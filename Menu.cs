using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class Menu
    {
        public Menu()
        {

        }

        public void viewMenu ()
        {
        
                Console.WriteLine("Welcome in the game 'SNAKE' by Matt Poltorak");
                Console.WriteLine("New Game");
                Console.WriteLine("Options");
                Console.WriteLine("Quit");

                ConsoleKeyInfo cki;
                cki = Console.ReadKey();

                switch (cki.Key)
                {

                case ConsoleKey.UpArrow:
                    {

                    }



               }
            
            





        }

    }
}
