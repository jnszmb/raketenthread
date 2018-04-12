using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleFiguren
{
    public class Monster : Figur, IConsoleObject
    {
        public void Display()
        {
            Console.SetCursorPosition(this.X, this.Y);
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = MyColor;
            Console.Write("|_______/");
            Console.SetCursorPosition(this.X, this.Y - 1);
            Console.Write("|       |");
            Console.SetCursorPosition(this.X, this.Y - 2);
            Console.Write("|  o.o  |");
            Console.SetCursorPosition(this.X, this.Y - 3);
            Console.Write("|       |");
            Console.SetCursorPosition(this.X, this.Y - 4);
            Console.Write("---------");
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
                    //this.X -= this.Speed;
                    //if(this.X <= Console.WindowLeft + 80)
                    //{
                    //    this.X += this.Speed;
                        
                    //}

                    Thread.Sleep(10);
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
            Console.ForegroundColor = MyColor;
            Console.ForegroundColor = Console.BackgroundColor;
            Console.Write("|_______/");
            Console.SetCursorPosition(this.X, this.Y - 1);
            Console.Write("|       |");
            Console.SetCursorPosition(this.X, this.Y - 2);
            Console.Write("|  o.o  |");
            Console.SetCursorPosition(this.X, this.Y - 3);
            Console.Write("|       |");
            Console.SetCursorPosition(this.X, this.Y - 4);
            Console.Write("---------");
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
