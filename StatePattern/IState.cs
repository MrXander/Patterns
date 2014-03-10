
namespace StatePattern
{
    interface IState
    {
        void InsertCoin();
        void EjectCoin();
        void TurnCrank();
        void Dispense();
    }
}
