using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class Board
    {
       protected int sizeX;
       protected int sizeY;

        public Board ( int x, int y)
        {
            x = 250;
            y = 250;
        }

        /// <summary>
        /// Set the size of game board. Max 300x300
        /// </summary>
        /// <param name="x"> Lenght </param>
        /// <param name="y"> Width </param>
        public void SetBoardSize (int x, int y)
 
        {
            if (sizeX < 300)
            {
                sizeX = x;
            }
            
            if (sizeY < 300)
            {
                sizeY = y;
            }

        }

    }
}
