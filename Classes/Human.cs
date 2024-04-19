using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Classes
{
    public class Human
    {
        protected internal string _name;
        protected internal DateTime _birthDate;
        protected internal Woman? _mother;
        protected internal Man? _father;
        protected internal List<Human>? _children;
        protected internal Human(string name, string birthDate) : this(name, birthDate, null, null) { }
        protected internal Human(string name, string birthDate, Woman? mother, Man? father)
        {
            _name = name;
            _birthDate = DateTime.Parse(birthDate);
            _mother = mother;
            _father = father;
        }
        public override string ToString()
        {
            return $"{_name} ";
        }
        public void Print()
        {
            Console.WriteLine($"{_name} | Birth date: {_birthDate}");
            PrintParents();
            PrintChildren();
        }
        public void PrintChildren()
        {
            if (_children == null) return;
            Console.Write("Children: ");
            foreach (var c in _children) Console.Write($"{c._name}, ");
            Console.WriteLine();
        }
        public void AddChild(List<Human> children)
        {
            if (_children == null) _children = children;
            else foreach (var child in children)
                {
                    if (!_children.Contains(child))
                    {
                        _children.Add(child);
                        //if (this is Woman) child._mother = this as Woman;
                        //if (this is Man) child._father = this as Man;
                    }
                }
            PrintChildren();
        }
        public void PrintGrands()
        {
            Console.WriteLine("Mother's parents:");
            _mother?.PrintParents();
            Console.WriteLine("Father's parents:");
            _father?.PrintParents();
        }
        public void PrintParents()
        {
            Console.WriteLine($"Mother: {_mother?._name} | Father: {_father?._name}");
        }
    }
}
