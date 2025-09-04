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
    public static bool operator ==(CurrencyAmount A, CurrencyAmount B) =>
    A.currency == B.currency ? A.amount == B.amount : throw new ArgumentException();

    public static bool operator !=(CurrencyAmount A, CurrencyAmount B)=>
    A.currency == B.currency ? A.amount != B.amount : throw new ArgumentException();

    // TODO: implement comparison operators
    public static bool operator >(CurrencyAmount A, CurrencyAmount B)=>
    A.currency == B.currency ? A.amount > B.amount : throw new ArgumentException();
    
    public static bool operator <(CurrencyAmount A, CurrencyAmount B)=>
     A.currency == B.currency ? A.amount < B.amount : throw new ArgumentException();

    // TODO: implement arithmetic operators
    public static CurrencyAmount operator +(CurrencyAmount A, CurrencyAmount B)=>
    A.currency == B.currency ? new CurrencyAmount(A.amount+B.amount,A.currency) : throw new ArgumentException();


    public static CurrencyAmount operator -(CurrencyAmount A, CurrencyAmount B)=>
    A.currency == B.currency ? new CurrencyAmount(A.amount-B.amount,A.currency) : throw new ArgumentException();

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
    public static explicit operator double(CurrencyAmount A) => (double)A.amount;

    public static implicit operator decimal(CurrencyAmount A) => A.amount;
    
}
