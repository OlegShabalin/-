using System;

class Program
{
    enum eVariation { рубль, рубля, рублей };

    static string CurrencyVariation(int iNumber)
    {
        eVariation evResult;

        if ((iNumber / 10) % 10 == 1)   
            evResult = eVariation.рублей;
        else
            switch (iNumber % 10)       
            {
                case 1:
                    evResult = eVariation.рубль;
                    break;
                case 2:
                case 3:
                case 4:
                    evResult = eVariation.рубля;
                    break;
                default:
                    evResult = eVariation.рублей;
                    break;
            }

        return evResult.ToString();
    }

    static void Main()
    {
        for (int i = 0; i < 24; i++)
            Console.WriteLine("{0} {1}", i, CurrencyVariation(i));
        Console.ReadLine();
    }
}