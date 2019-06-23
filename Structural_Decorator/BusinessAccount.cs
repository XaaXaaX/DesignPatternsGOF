using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Decorator
{
    public class BusinessAccount : IAccount
    {
        private readonly IAccount account;
        private decimal extraCoverage = 1000;

        public decimal AuthorizedWithdraw { get; set; } = 3000;

        public BusinessAccount(IAccount account)
        {
            this.account = account;
        }

        public decimal Balance()
        {
            return account.Balance() + extraCoverage;
        }

        public decimal Withdraw(decimal amount)
        {
            try
            {
                account.AuthorizedWithdraw = this.AuthorizedWithdraw + Overdraft();
                return this.account.Withdraw(amount);
            }
            catch
            {
                throw new UnAuthorizedAmountException("Your buisiness acount has no extra benefits");
            }
        }

        public decimal Overdraft()
        {
            return extraCoverage;
        }
    }
}
