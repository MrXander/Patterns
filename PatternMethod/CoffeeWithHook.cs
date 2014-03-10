using System;

namespace PatternMethod
{
    class CoffeeWithHook : CaffeineBeverageWithHook
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding milk...");            
        }

        protected override void Brew()
        {
            Console.WriteLine("Brewing coffee...");
        }

        public override bool CustomerWantsCondiments()
        {
            return GetUserInput("Would you like milk ? (y/n)");
        }        
    }
}
