

using Banking.Domain;

namespace Banking.UnitTests;

internal class AccountWithdrawals
{
    [Fact]

    public void WithdrawingMondeyDecreasesBalance()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var accountToWithdraw = 10M;

        account.Withdraw(accountToWithdraw);

        Assert.Equal(openingBalance - accountToWithdraw, account.GetBalance());
    }

    [Fact]

    public void UserCanWithdrawFullBalance()
    {
        var account = new BankAccount();

        account.Withdraw(account)
    }

    [Fact]

    public void OverdraftIsCurrentlyAllowed()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var accountToWithdraw = openingBalance +.01M;

        account.Withdraw(accountToWithdraw);

        Assert.Equal(openingBalance , account.GetBalance());
    }
}
