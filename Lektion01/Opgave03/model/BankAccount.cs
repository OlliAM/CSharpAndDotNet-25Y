using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Opgave03.model;

public class BankAccount
{
    private string _owner;
    public required string AccountNumber { get; init; }
    public string Owner
    {
        get
        {
            return _owner;
        }

        set
        {
            if (value == null || value == "")
            {
                throw new ArgumentException(nameof(value), "Owner field can't be empty");
            }
            _owner = value;
        }
    }
    public decimal Balance { get; private set; } = 0;
    public bool isOverdrawn => Balance < 0;
    public string FormattedBalance => Balance.ToString("C", new CultureInfo("da-DK"));

    public void Deposit(decimal amount) { 
        if(amount > 0)
        {
            Balance += amount;
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0)
        {
            Balance -= amount;
        }
    }
}

