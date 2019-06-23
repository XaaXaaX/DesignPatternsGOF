using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Decorator
{
    public interface IAccount
    {
        decimal AuthorizedWithdraw { get; set; }
        decimal Balance();
        decimal Withdraw(decimal amount);
    }

}
