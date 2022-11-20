using System;

namespace _9._65
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string txt = Console.ReadLine();
            float counter = 0;
            foreach (char symb in txt)
                if (char.ToLower(symb) == 'а')
            counter++;
            Console.WriteLine($"Доля букв \"а\" в предложении: { counter / txt.Length : 0.00 %}");
        }
    }
}
