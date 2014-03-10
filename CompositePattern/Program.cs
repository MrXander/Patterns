using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pancakeMenu = new Menu("Pancake menu", "breakfast");
            var dinnerMenu = new Menu("Dinner menu", "dinner");
            var cafeMenu = new Menu("Cafe menu", "cafe");
            var dessertMenu = new Menu("Dessert menu", "dessert");

            MenuComponent menuComponent = new Menu("All menu", "all");
            menuComponent.Add(pancakeMenu);
            menuComponent.Add(dinnerMenu);
            menuComponent.Add(cafeMenu);

            dinnerMenu.Add(new MenuItem("d1", "d1", false, 5));
            dinnerMenu.Add(new MenuItem("d2", "d2", true, 6));
            dinnerMenu.Add(new MenuItem("d3", "d3", false, 7));
            dinnerMenu.Add(new MenuItem("d4", "d4", true, 8));

            dinnerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem("dessert1", "dessert1", false, 9));
            dessertMenu.Add(new MenuItem("dessert2", "dessert2", false, 10));
            dessertMenu.Add(new MenuItem("dessert3", "dessert3", true, 11));

            var waitress = new Waitress(menuComponent);
            waitress.PrintMenu();
            waitress.PrintVegeterianMenu();
        }
    }
}
