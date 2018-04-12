using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleFiguren
{
    public abstract class Figur
    {
        private ConsoleColor color;
        private int speed;
        private int x;
        private int y;
        Object o;
        int lifetime = 10;
        DateTime starttime;
        Thread myThread;
        public ConsoleColor MyColor
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public Object LockObject
        {
            get
            {
                return o;
            }

            set
            {
                o = value;
            }
        }

        public int Lifetime
        {
            get
            {
                return lifetime;
            }

            set
            {
                lifetime = value;
            }
        }

        public DateTime Starttime
        {
            get
            {
                return starttime;
            }

            set
            {
                starttime = value;
            }
        }

        public Thread MyThread
        {
            get
            {
                return myThread;
            }

            set
            {
                myThread = value;
            }
        }
    }
}
