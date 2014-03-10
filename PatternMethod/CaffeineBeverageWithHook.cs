using System;

namespace PatternMethod
{
    internal abstract class CaffeineBeverageWithHook
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        protected abstract void AddCondiments();

        protected abstract void Brew();

        protected bool GetUserInput(string text)
        {
            Console.WriteLine(text);
            var input = Console.ReadLine();
            if (input != null && input.ToLower().Contains("y"))
            {
                return true;
            }
            return false;
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring in cup...");
        }        

        private void BoilWater()
        {
            Console.WriteLine("Boiling water...");
        }        
    }
}