
using System;
class InsufficientBalanceExceptions : Exception
{
    public InsufficientBalanceExceptions(string message) : base(message)
    {
    }
}

class Program5
{
    static void Main5()
    {
        try
        {
            Console.Write("Enter account balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > balance)
            {
                throw new InsufficientBalanceExceptions(
                    "Insufficient balance! Withdrawal cannot be completed."
                );
            }

            if (amount <= 0)
            {
                throw new Exception("Withdrawal amount must be greater than 0.");
            }

            balance = balance - amount;

            Console.WriteLine("Withdrawal successful!");
            Console.WriteLine("Remaining balance: " + balance);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid numbers.");
        }
        finally
        {
            Console.WriteLine("Thank you for using the ATM.");
        }
    }
}

