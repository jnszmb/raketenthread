using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleFiguren
{
    public class Rakete : Figur, IConsoleObject
    {
        public void Display()
        {
            Console.SetCursorPosition(this.X, this.Y);
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = MyColor;
            Console.Write("/-----\\");
            Console.SetCursorPosition(this.X + 1, this.Y - 1);
            Console.Write("/   \\");
            Console.SetCursorPosition(this.X + 2, this.Y - 2);
            Console.Write("/ \\");
            Console.SetCursorPosition(this.X + 3, this.Y - 3);
            Console.Write("|");
            Console.SetCursorPosition(this.X + 3, this.Y - 4);
            Console.Write("^");
            Console.ForegroundColor = c;
        }

        public void MoveUp()
        {
            Boolean status = true;
            while (status)
            {
                
                if((DateTime.Now - Starttime).TotalSeconds > Lifetime)
                {
                    status = false;
                    MyThread.Suspend();
                }
                lock (this.LockObject)
                {
                    this.Delete();
                    this.Y -= this.Speed;
                    
                    Thread.Sleep(50);
                    if (this.Y <= this.Speed || this.Y <= 6)
                    {
                        this.Delete();
                        this.Y = Console.WindowHeight - 2;
                    }
                    this.Display();
                }
            }         
        }

        private void Delete()
        {
            Console.SetCursorPosition(this.X, this.Y);
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = Console.BackgroundColor;
            Console.Write("/-----\\");
            Console.SetCursorPosition(this.X + 1, this.Y - 1);
            Console.Write("/   \\");
            Console.SetCursorPosition(this.X + 2, this.Y - 2);
            Console.Write("/ \\");
            Console.SetCursorPosition(this.X + 3, this.Y - 3);
            Console.Write("|");
            Console.SetCursorPosition(this.X + 3, this.Y - 4);
            Console.Write("^");
            Console.ForegroundColor = c;
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Start(Thread thread)
        {
            this.Starttime = DateTime.Now;
            this.MyThread = thread;
        }
    }
}
