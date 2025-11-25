namespace Pierwsza_likcja_C_
{
    internal class Program
    {
        static void Main()
        {
            int[] table = { 5, 10, 15, 20, 25 };

            int suma = 0;

            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine(table[i]);
            }

            for (int i = 0; i < table.Length; i++)
            {
                suma = table[i] + suma;

                Console.WriteLine("Mnożenie liczb:" + table[i] * 2);
            }

            Console.WriteLine("Suma liczb:" + suma);


            int max = table[0];
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] > max)
                {
                    max = table[i];
                }
            }
            Console.WriteLine("Największa liczba w tablice to: " + max);

            int min = table[0];
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] < min)
                {
                    min = table[i];
                }
            }
            Console.WriteLine("Najmniejsza liczba w tablica to: " + min);
        }
    }
}
