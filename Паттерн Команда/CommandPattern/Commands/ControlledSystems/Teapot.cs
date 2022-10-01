using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class Teapot
    {
        public void TurnOn()
        {
            Console.WriteLine("Кипим");
            State = State.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("Чай готов!");
            State = State.Off;
        }

        public State State { get; set; }
    }
}