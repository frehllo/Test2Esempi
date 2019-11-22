using System;

namespace Metodi
{
    public class ClasseMetodi
    {
        public static bool Esempio1()
        {
            double a = 1.0 / 10.0;
            double prodotto = a * 10;
            if (prodotto == 1.0)
                return true;
            else
                return false;
        }
        public static bool Esempio2()
        {
            double a = 1.0 / 10.0;
            double somma = a + a + a + a + a + a + a + a + a + a;
            if (somma == 1)
                return true;
            else
                return false;
        }
    }
}
