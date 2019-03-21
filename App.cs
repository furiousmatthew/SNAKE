using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class App
    {
        static void Main()
        {
            int sizeX, sizeY;
            sizeX = Console.WindowHeight;
            sizeY = Console.WindowWidth;

            string[,] MenuArray = new string[4, 4];
            MenuArray[0,0] = "Welcome in the game 'SNAKE' by Matt Poltorak";
            MenuArray[1,0] = "New Game";
            MenuArray[2,0] = "Options";
            MenuArray[3,0] = "Quit";

            // Options ->
            MenuArray[2, 1] = "Opcja1";
            MenuArray[2, 2] = "Opcja2";
            MenuArray[2, 3] = "Opcja3";


            Menu menu = new Menu(MenuArray); //tworzy obiekt menu
            int wyborMenu = menu.CreateMenu(); //wyswietla menu i zwraca wartość która określa który pdpkt menu wybrałem

           



            Console.ReadKey() ;


        }
    }
}
