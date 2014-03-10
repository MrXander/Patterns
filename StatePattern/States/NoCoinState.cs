using System;

namespace StatePattern.States
{
    class NoCoinState : IState
    {
        private readonly GumballMachine _machine;

        public NoCoinState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("Coin inserted");
            _machine.CurrentState = _machine.CoinInsertedState;
        }

        public void EjectCoin()
        {
            Console.WriteLine("You didn't insert a coin");
        }

        public void TurnCrank()
        {
            Console.WriteLine("No coin");
        }

        public void Dispense()
        {
            Console.WriteLine("Insert a coin first");
        }
    }
}
