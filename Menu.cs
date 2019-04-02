using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class Menu
    {

        public int returnValue; // Zwraca wybraną opcje menu.
        private int position = 1; // Ponieważ zaczynamy od pozycji 1. 0 to WIADOMOSC POWITALNA
        private double howMuchFieldsInArray;
        private string[,] menuOptions;

        private Dictionary<int, Action<int>> opcjeMenu = new Dictionary<int, Action<int>>();
        private Dictionary<int, Action<int>> opcjeMenuDodatkowe = new Dictionary<int, Action<int>>();
     
        public Menu(string[,] possitionsListArray)
        {
            menuOptions = possitionsListArray;
            howMuchFieldsInArray = menuOptions.GetLength(0); 
           




            for (int i = 0; i < howMuchFieldsInArray; i++)
            {
                
               opcjeMenu.Add(i, z =>
               {
                    for (int j=0; j<howMuchFieldsInArray; j++)
                    {
                                             
                        if (j == z)
                        {                           
                            Console.BackgroundColor = ConsoleColor.White;
                        }
                        else if (j-1 == z)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.WriteLine(menuOptions[j, 0]);
                  
                    }
         
                });
            }

            // Checking the addon menu (after main) is it exist
            for (int i = 0; i < howMuchFieldsInArray; i++)
            {
                
                   opcjeMenuDodatkowe.Add(i, z =>
                       {
                           int j = 1;
                           while (String.IsNullOrEmpty(menuOptions[i, j]) == false)
                           {
                               if (j == z)
                               {
                                   Console.BackgroundColor = ConsoleColor.White;
                               }
                               else if (j - 1 == z)
                               {
                                   Console.BackgroundColor = ConsoleColor.Black;
                               }
                               Console.WriteLine(menuOptions[i, j]);
                               j++;
                           }
                       }
                        );
                    
                
            }


            ConsoleKeyInfo cki;
            do
            {
                opcjeMenu[position](position);

                cki = Console.ReadKey();

                switch (cki.Key)
                {

                    case ConsoleKey.UpArrow:
                        {
                            if (position != 1)
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
                            break;
                        }

                };

                Console.WriteLine(position);
                Console.Clear();

            } while (cki.Key != ConsoleKey.Enter);

            returnValue = position; 
             
        }
    }
       
    }

