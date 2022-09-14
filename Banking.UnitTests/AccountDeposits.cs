

using Banking.Domain;

namespace Banking.UnitTests;

public class AccountDeposits
{
    [Fact]

    public void MakingADepositIncreasesTheBalance()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 10.15M;

        account.Deposit(amountToDeposit);

        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }
}
