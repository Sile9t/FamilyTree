using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Classes
{
    public class Woman : Human
    {
        private Man? _husband;
        public bool isMarried { get; private set; }
        protected internal Woman(string name, string birthDate) : base(name, birthDate) { }
        protected internal Woman(string name, string birthDate, Woman? mother, Man? father) : base(name, birthDate, mother, father)
        {
            isMarried = false;
        }
        public void SetHusband(Man man)
        {
            _husband = man;
            isMarried = true;
        }
        public override string ToString()
        {
            return $"Woman " + base.ToString();
        }
        public void PrintSublings()
        {
            if (isMarried) { Console.WriteLine($"Wife: {_husband!.ToString()}"); }
            PrintParents();
            PrintGrands();
            PrintChildren();
        }
    }
}
