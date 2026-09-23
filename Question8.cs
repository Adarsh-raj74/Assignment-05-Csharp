using System;

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

class BankAccount
{
    double balance;

    public BankAccount(double balance)
    {
        this.balance = balance;
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            throw new InsufficientBalanceException(
                "Insufficient balance! Withdrawal amount exceeds available balance."
            );
        }

        balance = balance - amount;
        Console.WriteLine("Withdrawal successful.");
        Console.WriteLine("Remaining Balance: " + balance);
    }
}

class Program8
{
    static void Main()
    {
        BankAccount account = new BankAccount(5000);

        try
        {
            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            account.Withdraw(amount);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction process completed.");
        }
    }
}