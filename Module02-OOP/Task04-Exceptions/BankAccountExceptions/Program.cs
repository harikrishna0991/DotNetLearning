// ============================================
// Module 2 - Task 2.4
// Exception Handling
// ============================================

Console.WriteLine("======================================");
Console.WriteLine("      BANK ACCOUNT - EXCEPTIONS");
Console.WriteLine("======================================");

BankAccount account = new BankAccount(
    "ACC1001",
    "Hari",
    10000m
);

account.DisplayAccountDetails();


// ============================================
// 1. Successful Withdrawal
// ============================================

Console.WriteLine();
Console.WriteLine("Withdrawing ₹3000...");

try
{
    account.Withdraw(3000m);

    Console.WriteLine(
        $"Withdrawal successful. Balance: ₹{account.Balance}"
    );
}
catch (InsufficientFundsException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    Console.WriteLine("Withdrawal operation completed.");
}


// ============================================
// 2. Insufficient Funds
// ============================================

Console.WriteLine();
Console.WriteLine("Trying to withdraw ₹15000...");

try
{
    account.Withdraw(15000m);

    Console.WriteLine(
        $"Withdrawal successful. Balance: ₹{account.Balance}"
    );
}
catch (InsufficientFundsException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    Console.WriteLine("Withdrawal operation completed.");
}


// ============================================
// 3. Invalid Deposit
// ============================================

Console.WriteLine();
Console.WriteLine("Trying to deposit ₹0...");

try
{
    account.Deposit(0);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    Console.WriteLine("Deposit operation completed.");
}


// ============================================
// 4. using / IDisposable Example
// ============================================

Console.WriteLine();
Console.WriteLine("Using a disposable resource...");

using (AccountStatement statement = new AccountStatement())
{
    statement.PrintStatement();
}


// ============================================
// Completed
// ============================================

Console.WriteLine();
Console.WriteLine("======================================");
Console.WriteLine("      EXCEPTION HANDLING COMPLETED");
Console.WriteLine("======================================");


// ============================================
// BankAccount Class
// ============================================

class BankAccount
{
    public string AccountNumber { get; }

    public string AccountHolder { get; }

    public decimal Balance { get; private set; }


    // Constructor
    public BankAccount(
        string accountNumber,
        string accountHolder,
        decimal initialBalance)
    {
        if (initialBalance < 0)
        {
            throw new ArgumentException(
                "Initial balance cannot be negative."
            );
        }

        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }


    // Deposit
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException(
                "Deposit amount must be greater than zero."
            );
        }

        Balance += amount;

        Console.WriteLine(
            $"Deposited: ₹{amount}"
        );
    }


    // Withdraw
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException(
                "Withdrawal amount must be greater than zero."
            );
        }

        if (amount > Balance)
        {
            throw new InsufficientFundsException(
                $"Insufficient funds. " +
                $"Available balance: ₹{Balance}, " +
                $"Requested: ₹{amount}"
            );
        }

        Balance -= amount;

        Console.WriteLine(
            $"Withdrawn: ₹{amount}"
        );
    }


    // Display account details
    public void DisplayAccountDetails()
    {
        Console.WriteLine();
        Console.WriteLine($"Account Number : {AccountNumber}");
        Console.WriteLine($"Account Holder : {AccountHolder}");
        Console.WriteLine($"Balance        : ₹{Balance}");
    }
}


// ============================================
// Custom Exception
// ============================================

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message)
        : base(message)
    {
    }
}


// ============================================
// IDisposable Example
// ============================================

class AccountStatement : IDisposable
{
    public void PrintStatement()
    {
        Console.WriteLine(
            "Account statement resource is being used."
        );
    }


    public void Dispose()
    {
        Console.WriteLine(
            "Account statement resource disposed."
        );
    }
}
