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

            string [] MenuOptions = new string[4];
            MenuOptions[0] = "Welcome in the game 'SNAKE' by Matt Poltorak";
            MenuOptions[1] = "New Game";
            MenuOptions[2] = "Options";
            MenuOptions[3] = "Quit";

            int position = 1;
            int status;
            ConsoleKeyInfo cki;

            do
            {

                switch (position)
                    {
                        case 1:
                            {                       
                                Console.WriteLine(MenuOptions[0]);
                                Console.BackgroundColor = ConsoleColor.White;              
                                Console.WriteLine(MenuOptions[1]);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.WriteLine(MenuOptions[2]);
                                Console.WriteLine(MenuOptions[3]);

                       
                                break;
                            }

                        case 2:
                            {
                                Console.WriteLine(MenuOptions[0]);                           
                                Console.WriteLine(MenuOptions[1]);
                                Console.BackgroundColor = ConsoleColor.White;                            
                                Console.WriteLine(MenuOptions[2]);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.WriteLine(MenuOptions[3]);

                     

                            break;
                            }

                        case 3:
                            {
                                Console.WriteLine(MenuOptions[0]);
                                Console.WriteLine(MenuOptions[1]);
                                Console.WriteLine(MenuOptions[2]);
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.WriteLine(MenuOptions[3]);
                                Console.BackgroundColor = ConsoleColor.Black;

                        

                            break;
                            }
                }

              


                cki = Console.ReadKey();
                

                switch (cki.Key)
                {
                   

                    case ConsoleKey.UpArrow:
                        {
                            if (position == 1)
                            {
                                break;
                            }
                            else
                            {
                                position--;
                                break;
                            }
                            
                        }

                    case ConsoleKey.DownArrow:
                        {
                            if(position == 3)
                            {
                                break;
                            }
                            else
                            {
                                position++;
                                break;
                            }
                            
                        }

                };

                Console.Clear();


            } while (cki.Key != ConsoleKey.Enter );










        }

    }
}
