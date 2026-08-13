// ============================================
// Module 2 - Task 2.1
// Classes & Objects
// ============================================

Console.WriteLine("======================================");
Console.WriteLine("          BANK ACCOUNT");
Console.WriteLine("======================================");

// Create a BankAccount object
BankAccount account = new BankAccount(
    "ACC1001",
    "Hari",
    10000m
);

// Display initial account details
Console.WriteLine();
account.DisplayAccountDetails();

// Deposit money
Console.WriteLine();
Console.WriteLine("Depositing ₹5000...");

account.Deposit(5000m);

Console.WriteLine($"Current Balance: ₹{account.Balance}");

// Withdraw money
Console.WriteLine();
Console.WriteLine("Withdrawing ₹3000...");

account.Withdraw(3000m);

Console.WriteLine($"Current Balance: ₹{account.Balance}");

// Try to withdraw more than the balance
Console.WriteLine();
Console.WriteLine("Trying to withdraw ₹20000...");

account.Withdraw(20000m);

// Display final account details
Console.WriteLine();
Console.WriteLine("======================================");
Console.WriteLine("          FINAL ACCOUNT");
Console.WriteLine("======================================");

account.DisplayAccountDetails();


// ============================================
// BankAccount Class
// ============================================

class BankAccount
{
    // Auto-properties
    public string AccountNumber { get; set; }

    public string AccountHolder { get; set; }

    // Balance can be read publicly,
    // but can only be changed inside this class.
    public decimal Balance { get; private set; }


    // Constructor
    public BankAccount(
        string accountNumber,
        string accountHolder,
        decimal initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;

        if (initialBalance < 0)
        {
            throw new ArgumentException(
                "Initial balance cannot be negative."
            );
        }

        Balance = initialBalance;
    }


    // Deposit method
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine(
                "Deposit amount must be greater than zero."
            );

            return;
        }

        Balance += amount;

        Console.WriteLine(
            $"Deposited: ₹{amount}"
        );
    }


    // Withdraw method
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine(
                "Withdrawal amount must be greater than zero."
            );

            return;
        }

        if (amount > Balance)
        {
            Console.WriteLine(
                "Withdrawal failed: Insufficient balance."
            );

            return;
        }

        Balance -= amount;

        Console.WriteLine(
            $"Withdrawn: ₹{amount}"
        );
    }


    // Display account information
    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Number : {AccountNumber}");
        Console.WriteLine($"Account Holder : {AccountHolder}");
        Console.WriteLine($"Balance        : ₹{Balance}");
    }
}
