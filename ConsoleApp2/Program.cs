using System;

class Currency
{
    public double value;

    public Currency(double value)
    {
        this.value = value;
    }
}

class CurrencyUSD : Currency
{
    public CurrencyUSD(double value) : base(value) { }

    public static implicit operator CurrencyEUR(CurrencyUSD param) 
    {
        return new CurrencyEUR(param.value * 92.86 / 103.41);
    }

    public static implicit operator CurrencyRUB(CurrencyUSD param)
    {
        return new CurrencyRUB(param.value * 92.86);
    }
}

class CurrencyEUR : Currency
{
    public CurrencyEUR(double value) : base(value) { }

    public static implicit operator CurrencyUSD(CurrencyEUR param)
    {
        return new CurrencyUSD(param.value * 103.41 / 92.86);
    }

    public static implicit operator CurrencyRUB(CurrencyEUR param)
    {
        return new CurrencyRUB(param.value * 103.41);
    }
}

class CurrencyRUB : Currency
{
    public CurrencyRUB(double value) : base(value) { }

    public static implicit operator CurrencyUSD(CurrencyRUB param)
    {
        return new CurrencyUSD(param.value / 92.86);
    }

    public static implicit operator CurrencyEUR(CurrencyRUB param)
    {
        return new CurrencyEUR(param.value / 103.41);
    }
}

class Program
{
    static void Main()
    {
        CurrencyRUB rubles = new CurrencyRUB(1000.0);
        CurrencyEUR euros = rubles;
        CurrencyUSD dollars = euros;

        Console.WriteLine($"{rubles.value}₽ is {euros.value}€ and {dollars.value}$");

    }
}