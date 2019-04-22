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

     
     
        public Menu(string[,] possitionsListArray)
        {
            menuOptions = possitionsListArray;
            howMuchFieldsInArray = menuOptions.GetLength(0); 
           

            ConsoleKeyInfo cki;
            do
            {
                
               
                    for (int i = 0; i < howMuchFieldsInArray; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;

                        if (i == position)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                        }

                        Console.WriteLine(menuOptions[i, 0]);

                    }
                

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
                            if ((position != (menuOptions.GetLength(0) - 1)) && (String.IsNullOrEmpty(menuOptions[position, 0]) != true))
                                position++;
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            break;
                        }

                };

                //Console.WriteLine(position);
                Console.Clear();

            } while (cki.Key != ConsoleKey.Enter);

            returnValue = position; 





            if (returnValue != null)
            {
                if (!string.IsNullOrEmpty(menuOptions[returnValue, 1]))
                {
                    position = 0;
                    do
                    {


                        
                        int j = 1;
                        while ((j < menuOptions.GetLength(1)) && (String.IsNullOrEmpty(menuOptions[returnValue, j]) == false))
                        {
                            Console.BackgroundColor = ConsoleColor.Black;

                            if (j == position)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                            }

                            Console.WriteLine(menuOptions[returnValue, j]);
                            j++;

                        }

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
                                    if (position != (menuOptions.GetLength(1) - 1) && (String.IsNullOrEmpty(menuOptions[returnValue, position]) != true))
                                        position++;
                                    break;
                                }
                            case ConsoleKey.Enter:
                                {
                                    break;
                                }

                        };

                        
                        Console.Clear();

                    } while (cki.Key != ConsoleKey.Enter);

                }

            }
             
        }
    }
       
    }

