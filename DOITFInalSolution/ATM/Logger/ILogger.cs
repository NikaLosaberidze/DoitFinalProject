

namespace ATM.Logger
{
    internal interface ILogger
    {

        void CustomerLog(Customer customer);
        void WithdrawLog(ATMForm aTMForm,Customer customer);
        void DepositLog(ATMForm aTMFrom,Customer customer);
        

    }
}
