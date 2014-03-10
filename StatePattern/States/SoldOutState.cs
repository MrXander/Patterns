using System;

namespace StatePattern.States
{
    class SoldOutState : IState
    {                
        public void InsertCoin()
        {
            Console.WriteLine("Out of gumballs. You can't insert coin");            
        }

        public void EjectCoin()
        {
            Console.WriteLine("Can't return coin");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Out of gumballs!");
        }

        public void Dispense()
        {
            Console.WriteLine("Out of gumballs!");
        }
    }
}
