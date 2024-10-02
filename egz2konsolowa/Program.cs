namespace egz2konsolowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100;

            bool[] A = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                A[i] = true;
            }

            /*******************************************************
             nazwa funkcji: SitoEratostenesa
             parametry wejściowe: A-tablica wartości logicznych, n-koniec przedziału
             wartość zwracana: brak
             informacje: funkcja sprawdza wielokrotności , liczb o 2 do n
             autor: Piotr Sroka
            *******************************************************/

            static void SitoEratostenesa(bool[] A, int n)
            {
                for (int i = 2; i * i <= n; i++)
                {
                    if (A[i])
                    {
                        for (int j = i * i; j <= n; j += i)
                        {
                            A[j] = false;
                        }
                    }
                }
            }

            SitoEratostenesa(A, n);

            Console.WriteLine("Liczby z pierwsze z przedziału od 2 do n: ");

            bool pierwszy = true;

            for (int i = 2; i <= n; i++)
            {
                if (A[i])
                {
                    if (!pierwszy)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(i);
                    pierwszy = false;
                }
            }

        }
    }
}
