using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CompositePattern
{
    class MenuItem : MenuComponent
    {
        private readonly string _name;
        private readonly string _description;
        private readonly bool _isVegeterian;
        private readonly double _price;

        public MenuItem(string name, string description, bool isVegeterian, double price)
        {
            _name = name;
            _description = description;
            _isVegeterian = isVegeterian;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override double GetPrice()
        {
            return _price;
        }

        public override bool IsVegeterian()
        {
            return _isVegeterian;
        }

        public override IEnumerator CreateIterator()
        {
            //Null iterator
            return Enumerable.Empty<MenuComponent>().GetEnumerator();
        }

        public override void Print()
        {
            Console.Write("\t" + GetName());
            if (IsVegeterian())
            {
                Console.Write("(v)");
            }
            Console.WriteLine(", " + GetPrice());
            Console.WriteLine("\t\t--\t" + GetDescription());
        }
    }
}
