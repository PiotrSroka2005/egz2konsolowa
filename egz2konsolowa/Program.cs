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

            static void SitoErastotelesa(bool[] tab, int n)
            {
                for (int i = 2; i * i <= n; i++)
                {
                    if (tab[i])
                    {
                        for (int j = i * i; j <= n; j += i)
                        {
                            tab[j] = false;
                        }
                    }
                }
            }

        }
    }
}
