namespace Structural_Decorator
{
    public class Account : IAccount
    {
        private decimal _balance;
        public decimal AuthorizedWithdraw { get; set; } = 1000;

        public decimal Balance()
        {
            return _balance;
        }

        public decimal Withdraw(decimal amount)

        {
            if (amount <= AuthorizedWithdraw && amount <= (_balance - amount))
            {
                _balance -= amount;
                return amount;
            }
            throw new UnAuthorizedWithdrawAmount();
        }
    }
}