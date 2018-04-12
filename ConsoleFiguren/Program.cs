using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFiguren
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleObjects consObjects = new ConsoleObjects();
            Object lockObject = new Object();
            Console.WindowHeight = 50;
            Rakete rakete1 = new Rakete { Speed = 5,MyColor=ConsoleColor.Green,X=10,Y=Console.WindowHeight - 6 , LockObject = lockObject};
            Rakete rakete2 = new Rakete { Speed = 4, MyColor = ConsoleColor.Blue, X = 30, Y = Console.WindowHeight - 6, LockObject = lockObject};
            Rakete rakete3 = new Rakete { Speed = 2, MyColor = ConsoleColor.Red, X = 50, Y = Console.WindowHeight - 6 , LockObject = lockObject};
            Monster monster1 = new Monster { Speed = 2, MyColor = ConsoleColor.Yellow, X = 100, Y = Console.WindowHeight - 6, LockObject = lockObject };

            rakete1.Lifetime = 3; // individuell die Lebenszeit anpassen
            consObjects.AddObjekt(rakete1);
            consObjects.AddObjekt(rakete2);
            consObjects.AddObjekt(rakete3);
            consObjects.AddObjekt(monster1);
            consObjects.DisplayAll();

            Console.ReadLine();
            consObjects.MoveAllUp();












            Console.Read();

        }
    }
}
