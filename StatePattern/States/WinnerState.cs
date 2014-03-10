using System;

namespace StatePattern.States
{
    class WinnerState : IState
    {
        private readonly GumballMachine _machine;

        public WinnerState(GumballMachine machine)
        {
            _machine = machine;
        }

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
            Console.WriteLine("Winner! You get 2 gumballs");
            _machine.ReleaseBall();
            if (_machine.Count == 0)
            {
                _machine.CurrentState = _machine.SoldOutState;
            }
            else
            {
                _machine.ReleaseBall();
                if (_machine.Count == 0)
                {
                    Console.WriteLine("Ooops, out of gumballs!");
                    _machine.CurrentState = _machine.SoldOutState;
                }
                else
                {
                    _machine.CurrentState = _machine.NoCoinState;
                }
            }
        }
    }
}
