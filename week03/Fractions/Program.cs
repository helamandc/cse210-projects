using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions fractionConstruct1 = new Fractions();
        fractionConstruct1.GetFractionString();
        fractionConstruct1.GetDecimalValue();

        Fractions fractionConstruct2 = new Fractions(5);
        fractionConstruct2.GetFractionString();
        fractionConstruct2.GetDecimalValue();

        Fractions fractionConstruct3 = new Fractions(3, 4);
        fractionConstruct3.GetFractionString();
        fractionConstruct3.GetDecimalValue();

    }
}