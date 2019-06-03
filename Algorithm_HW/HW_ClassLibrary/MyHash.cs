

using System;

namespace HW_ClassLibrary
{
    public static class MyHash
    {
        public static int Hash(string x)
        {
            int p = 42; //Просто число
            int rez = 0; //Результат вычисления 
            for (int i = 0; i < x.Length; i++)
            {
                rez += (int)Math.Pow(p, x.Length - 1 - i) * (int)(x[i]);//Подсчет хеш-функции
            }
            return rez;
        }
    }
}
