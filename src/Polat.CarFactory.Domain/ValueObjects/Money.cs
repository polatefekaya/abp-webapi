using System;

namespace Polat.CarFactory.ValueObjects;

public class Money
{
    public decimal Amount {get; private set;}
    public string Currency {get; private set;}
    public Money(decimal amount, string currency){
        Amount = amount;
        Currency = currency;
    }
    public static Money operator +(Money m1, Money m2){
        CheckCurrency(m1, m2, "add");

        return new Money(m1.Amount + m2.Amount, m1.Currency);
    }

    public static Money operator -(Money m1, Money m2){
        CheckCurrency(m1, m2, "substract");
        
        return new Money(m1.Amount - m2.Amount, m1.Currency);
    }

    public static Money operator *(Money m1, int multp){
        return new Money(m1.Amount * multp, m1.Currency);
    }

    private static void CheckCurrency(Money m1, Money m2, string op){
        if(m1.Currency != m2.Currency){
            throw new InvalidOperationException($"Can not {op} different currencies!");
        }
    }
}
