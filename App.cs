using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class App
    {
      
        public void dupa (int i)
        {
            Console.WriteLine("dupa");
        }
        static void Main()
        {
            int sizeX, sizeY;
            sizeX = Console.WindowHeight;
            sizeY = Console.WindowWidth;


            NewMenu menu = new NewMenu();
            menu.addMainMenuPosition("opcja1", dupa(1);

            menu.viewMenu();
            

            //string[,] MenuArray = new string[10, 4];
            //MenuArray[0, 0] = "Welcome in the game 'SNAKE' by Matt Poltorak";
            //MenuArray[1, 0] = "New Game";
            //MenuArray[2, 0] = "Options";
            //MenuArray[3, 0] = "Quit";
            //MenuArray[4, 0] = "Quit";
            //MenuArray[5, 0] = "Quit";
            //MenuArray[6, 0] = "Quit";



            //// Options ->
            //MenuArray[2, 1] = "Opcja1";
            //MenuArray[2, 2] = "Opcja2";
            //MenuArray[2, 3] = "Opcja3";







            //Menu menu = new Menu(MenuArray); //tworzy obiekt menu i go wyświetla
            //int retMenuOption = menu.returnValue;
            //switch (retMenuOption)
            //{
            //    case 1:
            //        //tutaj będzie klasa odpowiedzialna za gre
            //        //
            //        break;

            //    case 2:
            //        // tutaj będzie wywoływało menu.options;
            //        break;
            //}







            Console.ReadKey() ;


        }
    }
}
