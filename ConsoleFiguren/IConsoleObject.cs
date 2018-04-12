using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleFiguren
{
    public interface IConsoleObject
    {
        void Display();
        void MoveUp();
        void Stop();

        void Start(Thread thread);
    }
}
