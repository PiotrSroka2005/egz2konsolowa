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
        }
    }
}
