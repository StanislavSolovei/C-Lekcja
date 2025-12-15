namespace FirstProgram
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

            ---------------------------------------------------------------

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

            ---------------------------------------------------------------

            string[] name =  { "Karol", "Daria", "Ksawery", "Anna", "Ewa" };
            
            Console.WriteLine("Imiona w odwrotnej kolejności: ");
            
            for (int i = name.Length - 1; i >=0; i--)
            {
                Console.WriteLine(name[i]);
            }

            ---------------------------------------------------------------

            int[] numbers  = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            int numberOfTwo = 0;

            foreach (int number in numbers)
            {
                if (number %  2 == 0)
                {
                    numberOfTwo++;
                }
            }

            Console.WriteLine("Liczba parzystych: " + numberOfTwo);

            ---------------------------------------------------------------
        }
    }
}