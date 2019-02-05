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

            Console.WriteLine(sizeX + "  " + sizeY);

            //Console.SetWindowSize(230, 63);

            Board board = new Board();
            board.ViewBoard();
            Console.ReadKey() ;


        }
    }
}
