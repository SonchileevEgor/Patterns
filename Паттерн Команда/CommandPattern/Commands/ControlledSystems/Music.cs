using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class Music
    {
        public void TurnOn()
        {
            Console.WriteLine("Туц туц туц туц туц туц туц...");
            State = State.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("ГГ... *звук сверчка*");
            State = State.Off;
        }

        public State State { get; set; }
    }
}