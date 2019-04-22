using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class NewMenu
    {
        public string mainMenuTitle;
        public Dictionary<string, Action> mainMenuPositions = new Dictionary<string, Action>();

        public NewMenu ()
        {
            
            
        }

        public void viewMenu ()
        {
            Console.WriteLine (mainMenuPositions["opcja1"]);
        }


        public void addMainMenuPosition(string name, Action method)
        {
            mainMenuPositions.Add(name, method);

        }
    }
}
