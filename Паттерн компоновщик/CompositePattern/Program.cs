using System;
using System.Collections.Generic;
using System.IO;
using CompositePattern.Components;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Leaf leaf = new Leaf();
            Console.WriteLine("Client: output simple component (list)");
            client.ClientCode(leaf);

            Composite tree = new Composite();
            Composite branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composite branch2 = new Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: output composite inner component (list)");
            client.ClientCode(tree);
            Console.WriteLine("Client: could we add components");
            client.ClientCode2(tree, leaf);
        }
    }
}
