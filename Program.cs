using FamilyTree.Classes;

namespace FamilyTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man ggranddad = new Man("Mike", "17.11.1935");
            Man granddad = new Man("Aaron", "19.05.1960", null, ggranddad);
            Woman granny = new Woman("Kalary", "15.06.1964");
            Man m = new Man("Steve", "10.10.1990", granny, granddad);
            Woman w = new Woman("Anna", "12.09.1992", granny, granddad);
            Man son = new Man("Kelvin", "13.08.2002", w, m);
            Woman dauther = new Woman("Merry", "16.03.2003", w, m);

            Console.WriteLine(w.ToString());

            w.SetHusband(m);
            m.SetWife(w);

            w.AddChild(new List<Human>{ son, dauther });
            m.AddChild(new List<Human> { son, dauther });

            Console.WriteLine();

            m.PrintSublings();
        }
    }
}
