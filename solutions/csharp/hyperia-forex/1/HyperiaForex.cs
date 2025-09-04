public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    // TODO: implement equality operators
    public static bool operator ==(CurrencyAmount A, CurrencyAmount B)
    {
        if (A.currency != B.currency) throw new ArgumentException();
        else if (A.amount == B.amount) return true;
        else
            return false;
    }

    public static bool operator !=(CurrencyAmount A, CurrencyAmount B)
    {
        if (A.currency != B.currency) throw new ArgumentException();
        else if (A.amount != B.amount) return true;
        else
            return false;
    }



    // TODO: implement comparison operators
    public static bool operator >(CurrencyAmount A, CurrencyAmount B)
    {
        if (A.currency != B.currency) throw new ArgumentException();
        else if (A.amount > B.amount) return true;
        else
            return false;

    }
    public static bool operator <(CurrencyAmount A, CurrencyAmount B)
    {
        if (A.currency != B.currency) throw new ArgumentException();
        else if (A.amount < B.amount) return true;
        else
            return false;

    }

    // TODO: implement arithmetic operators
    public static CurrencyAmount operator +(CurrencyAmount A, CurrencyAmount B)
    {
        if (A.currency != B.currency) throw new ArgumentException();
        else
        {
            CurrencyAmount c = new CurrencyAmount(A.amount + B.amount, A.currency);
            return c;
        }

    }

    public static CurrencyAmount operator -(CurrencyAmount A, CurrencyAmount B)
    {
        if (A.currency != B.currency) throw new ArgumentException();
        else
        {
            CurrencyAmount c = new CurrencyAmount(A.amount - B.amount, A.currency);
            return c;
        }
    }

    public static CurrencyAmount operator *(CurrencyAmount A, decimal factor)
    {
        A.amount *= factor;
        return A;
    }

    public static CurrencyAmount operator *(decimal factor, CurrencyAmount A)
    {
        A.amount *= factor;
        return A;
    }

    public static CurrencyAmount operator /(CurrencyAmount A, decimal factor)
    {
        A.amount /= factor;
        return A;
    }

    // TODO: implement type conversion operators
    public static explicit operator double(CurrencyAmount A)
    {

        return (double)A.amount;

    }

    public static implicit operator decimal(CurrencyAmount A)
    {
        return A.amount;
    }
    
}
