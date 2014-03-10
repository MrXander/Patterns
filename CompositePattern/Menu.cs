using System;
using System.Collections;
using System.Collections.Generic;

namespace CompositePattern
{
    class Menu : MenuComponent
    {
        private readonly string _name;
        private readonly string _description;
        readonly List<MenuComponent> _menuComponents = new List<MenuComponent>();
        private CompositeIterator _iterator;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return _menuComponents[i];
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override IEnumerator CreateIterator()
        {
            if (_iterator == null)
            {
                _iterator = new CompositeIterator(_menuComponents.GetEnumerator());
            }
            return _iterator;
        }

        public override void Print()
        {
            Console.Write("\n" + GetName());
            Console.WriteLine(", " + GetDescription());
            Console.WriteLine("---------------------");

            var iterator = _menuComponents.GetEnumerator();
            while (iterator.MoveNext())
            {
                var menuComponent = (MenuComponent)iterator.Current;
                menuComponent.Print();                
            }
        }
    }
}
