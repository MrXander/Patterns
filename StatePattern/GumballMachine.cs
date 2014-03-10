using System;
using StatePattern.States;

namespace StatePattern
{
    class GumballMachine
    {
        public IState NoCoinState { get; set; }
        public IState CoinInsertedState { get; set; }
        public IState SoldState { get; set; }
        public IState SoldOutState { get; set; }
        public IState WinnderState { get; set; }

        public IState CurrentState { get; set; }

        public int Count { get; set; }

        public GumballMachine(int numberGumballs)
        {
            Count = numberGumballs;
            NoCoinState = new NoCoinState(this);
            CoinInsertedState = new CoinInsertedState(this);
            SoldState = new SoldState(this);
            SoldOutState = new SoldOutState();
            WinnderState = new WinnerState(this);
            if (numberGumballs > 0)
            {
                CurrentState = NoCoinState;
            }
        }

        public void InsertCoin()
        {
            CurrentState.InsertCoin();            
        }

        public void EjectCoin()
        {
            CurrentState.EjectCoin();
        }

        public void TurnCrank()
        {
            CurrentState.TurnCrank();
            CurrentState.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count > 0)
            {
                Count--;
            }
        }
    }
}
