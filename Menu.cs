using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    /// <summary>
    /// To create menu you need to create string [,] array to fill menu.
    /// </summary>
    /// <param name = "PossitionsListArray"> String Array with menu list</param>
    class Menu
    {
        private double HowMuchFieldsInArray;
        private string[,] MenuOptions;
        private Dictionary<int, Action<int>> OpcjeMenu = new Dictionary<int, Action<int>>();

        public Menu(string[,] PossitionsListArray)
        {
            MenuOptions = PossitionsListArray;
            HowMuchFieldsInArray = MenuOptions.Length;
            HowMuchFieldsInArray = Math.Sqrt(HowMuchFieldsInArray);


            for (int i = 0; i < HowMuchFieldsInArray; i++)
            {
                
               OpcjeMenu.Add(i, z =>
               {
                    for (int a=0; a<HowMuchFieldsInArray; a++)
                    {
                       
                      
                        if (a == z)
                        {
                            
                            Console.BackgroundColor = ConsoleColor.White;

                        }
                        else if (a-1 == z)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        Console.WriteLine(MenuOptions[a, 0]);
                  
                    }
         
                });
            }
        }
       


        public int CreateMenu ()
        {

            int position = 1;
            int status = 0;
            
            ConsoleKeyInfo cki;
            do
            {
                  OpcjeMenu[position](position);

                  cki = Console.ReadKey();

                switch (cki.Key)
                {


                    case ConsoleKey.UpArrow:
                        {
                            if (position == 1)
                                position--;
                            break;

                        }

                    case ConsoleKey.DownArrow:
                        {
                            if (position != 3)
                              position++;
                             break;

                        }
                    case ConsoleKey.Enter:
                        {
                            status = position;
                            break;
                        }

                };


                Console.Clear();

            } while (cki.Key != ConsoleKey.Enter);

            return status; //zwracam status 1- new game / 2- opcje / 3- wyjście z gry               
            }
        }


    }

