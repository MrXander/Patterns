using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Waitress
    {
        private readonly MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }

        public void PrintVegeterianMenu()
        {
            var iterator = _allMenus.CreateIterator();
            Console.WriteLine("Vegeterial menu\n-----");
            while (iterator.MoveNext())
            {
                var menuComponent = (MenuComponent)iterator.Current;
                try
                {
                    if (menuComponent.IsVegeterian())
                    {
                        menuComponent.Print();
                    }
                }
                catch (NotImplementedException)
                {
                    
                }
            }
        }
    }
}
