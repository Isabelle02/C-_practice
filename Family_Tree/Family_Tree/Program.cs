using System;
using System.Collections.Generic;

namespace Family_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node parent = new Node("Paul");

            List<Node> par1 = parent.Add("Gwenny", "Gideon"); // Paul's children

            List<Node> par2 = new List<Node>();
            par2.AddRange(par1[0].Add("Sam", "Tess")); // Gwenny's children
            par2.AddRange(par1[1].Add("Din", "William")); // Gideon's children

            List<Node> par3 = new List<Node>();
            par3.AddRange(par2[0].Add("Dan", "Will")); // Sam's children
            par3.AddRange(par2[1].Add("Noora", "Chris")); // Tess's children
            par3.AddRange(par2[2].Add("Mike", "Sharlotta", "Vicky")); // Din's children
            par3.AddRange(par2[3].Add("Archie")); // William's children

            List<Node> par4 = new List<Node>();
            par4.AddRange(par3[0].Add("Franko")); // Dan's children
            par4.AddRange(par3[1].Add("Bella", "Hardin")); // Will's children
            par4.AddRange(par3[2].Add("Finn", "Ferb")); // Noora's children
            par4.AddRange(par3[3].Add("Pheanes")); // Chris's children
            par4.AddRange(par3[4].Add("Star", "Marco")); // Mike's children
            par4.AddRange(par3[5].Add("Nick")); // Sharlotta's children
            par4.AddRange(par3[6].Add("Sandy", "Sarah")); // Vicky's children
            par4.AddRange(par3[7].Add("Caleb")); // Archie's children



            parent.PrintAll(parent);
        }
    }
    
    class Node
    {
        public string Name { get; set; }
        public List<Node> Children = new List<Node>();

        public Node(string name) => Name = name;

        public List<Node> Add(params string[] names)
        {
            foreach (string n in names)
                Children.Add(new Node(n));
            return Children;
        }

        public void Print(List<Node> children)
        {
            Console.Write($"{Name}: ");
            foreach (Node child in children)
                Console.Write($"{child.Name} ");
            Console.WriteLine();
        }

        public void PrintAll(Node parent)
        {
            if (parent.Children.Count != 0) parent.Print(parent.Children);
            foreach (Node child in parent.Children)
                parent.PrintAll(child);
        }
    }
}
