using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions FractionConstruct1 = new Fractions();
        FractionConstruct1.GetFractionString();
        FractionConstruct1.GetDecimalValue();

        Fractions FractionConstruct2 = new Fractions(5);
        FractionConstruct2.GetFractionString();
        FractionConstruct2.GetDecimalValue();

        Fractions FractionConstruct3 = new Fractions(3, 4);
        FractionConstruct3.GetFractionString();
        FractionConstruct3.GetDecimalValue();

    }
}