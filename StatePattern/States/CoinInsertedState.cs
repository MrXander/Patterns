using System;

namespace StatePattern.States
{
    class CoinInsertedState : IState
    {
        private readonly GumballMachine _machine;
        Random _randomWinner;

        public CoinInsertedState(GumballMachine machine)
        {
            _machine = machine;
            _randomWinner = new Random();
        }

        public void InsertCoin()
        {
            Console.WriteLine("Coin already inserted");
        }

        public void EjectCoin()
        {
            Console.WriteLine("Coin returned");
            _machine.CurrentState = _machine.NoCoinState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned crank...");
            var winner = _randomWinner.Next(11);
            if (winner == 0 && _machine.Count > 0)
            {
                _machine.CurrentState = _machine.WinnderState;
            }
            else
            {
                _machine.CurrentState = _machine.SoldState;
            }            
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
