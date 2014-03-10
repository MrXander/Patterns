
namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var gumballMachine = new GumballMachine(5);
            gumballMachine.InsertCoin();
            gumballMachine.TurnCrank();

            gumballMachine.InsertCoin();
            gumballMachine.TurnCrank();

            gumballMachine.InsertCoin();
            gumballMachine.TurnCrank();
        }
    }
}
