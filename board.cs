using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class Board
    {
       protected int _sizeX;
       protected int _sizeY;

        public Board (bool size = )
        {   

          
        }

        /// <summary>
        /// Set the size of game board. You can choose size 1/2 and full
        /// </summary>
        /// <param name="size"> 1 - 1/2 or 0 - 1</param>
        ///
        private void SetBoardSize (bool size)
 
        {
             
                if (size == 0)
                {
                    _sizeX = Console.WindowWidth;
                    _sizeY = Console.WindowHeight;

                }
                else
                {
                    _sizeX = Console.WindowWidth/2;
                    _sizeY = Console.WindowHeight/2;
                }


        }

       public void ViewBoard ()
            {
                for (int i=1; i<_sizeX; i++)
                {
                Console.Write("*");
                }
            }

    }
}
