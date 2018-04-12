using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleFiguren
{
    // Verwaltungsklasse für ConsoleObjekte
    public class ConsoleObjects
    {
        List<IConsoleObject> listObjects = null;

        public ConsoleObjects()
        {
            listObjects = new List<IConsoleObject>();
        }
        public void AddObjekt(IConsoleObject consobjekt)
        {
            listObjects.Add(consobjekt);
        }
        public void DisplayAll()
        {
            foreach(IConsoleObject ico in listObjects)
            {
                ico.Display();
            }
        }
        public void MoveAllUp()
        {
            int i = 1;
            foreach(IConsoleObject ico in listObjects)
            {   
                Thread th = new Thread(new ThreadStart(ico.MoveUp));
                
                ico.Start(th);
                th.Start();
            }
        }
    }
}
