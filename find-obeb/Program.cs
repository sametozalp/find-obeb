namespace find_obeb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 21, b = 35;
            Console.WriteLine(findOBEB(a, b));
        }

        private static int findOBEB(int a, int b)
        {
            if (a < b)
            {
                replace(ref a, ref b);
            }
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;  
            }
            return a;
        }

        private static void replace(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}