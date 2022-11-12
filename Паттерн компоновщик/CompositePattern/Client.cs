using System;
using CompositePattern.Components;

namespace CompositePattern
{
    class Client
    {
        public void ClientCode(Component component)
        {
            Console.WriteLine($"RESULT: {component.Operation()}\n");
        }

        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }
            else
            {
                Console.WriteLine("This component LEAF!");
            }
            Console.WriteLine($"RESULT: {component1.Operation()}\n");
        }
    }
}
