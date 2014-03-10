using System;

namespace StatePattern.States
{
    class SoldState : IState
    {
        private readonly GumballMachine _machine;

        public SoldState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("Please wait, we've already giving you a gumball");
        }

        public void EjectCoin()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball");
        }

        public void Dispense()
        {
            _machine.ReleaseBall();
            if (_machine.Count > 0)
            {
                _machine.CurrentState = _machine.NoCoinState;
            }
            else
            {
                Console.WriteLine("ooops, out of gumballs!");
                _machine.CurrentState = _machine.SoldOutState;
            }
        }
    }
}
