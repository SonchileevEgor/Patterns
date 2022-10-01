using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommandPattern.Commands;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl();
            string userInput;
            remote.SetCommandForButton(1, new LightCommand(new Light()));
            remote.SetCommandForButton(2, new MusicCommand(new Music()));
            remote.SetCommandForButton(3, new TeapotCommand(new Teapot()));

            do
            {
                Console.WriteLine("Чуз эн опшн:");
                Console.WriteLine(remote.ToString());

                Console.Write("\nЁ чойс:");
                var input = Console.ReadLine();
                int buttonId;
                int.TryParse(input, out buttonId);
                
                remote.ExecuteButton(buttonId);

                Console.WriteLine("\nПродолжаем?!?!?!? y/n:");
                userInput = Console.ReadLine();

            } while (userInput == "y");
        }
    }
}