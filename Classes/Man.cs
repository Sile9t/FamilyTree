using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Classes
{
    public class Man : Human
    {
        private Woman? _wife;
        public bool isMarried { get; private set; }
        public Man(string name, string birthDate) : base(name, birthDate) { }
        public Man(string name, string birthDate, Woman? mother, Man? father) : base(name, birthDate, mother, father)
        {
            isMarried = false;
        }
        public void SetWife(Woman woman)
        {
            _wife = woman;
            isMarried = true;
        }
        public override string ToString()
        {
            return "Man " + base.ToString();
        }
        public void PrintSublings()
        {
            if (isMarried) { Console.WriteLine($"Wife: {_wife!.ToString()}"); }
            PrintParents();
            PrintGrands();
            PrintChildren();
        }
    }
}
