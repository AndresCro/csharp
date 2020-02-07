namespace clase1
{
    class clase1
    {
        public static void Main()
        {
            numer(100);
            System.Console.ReadKey(true);
        }
        public static int numer(int r)
        {
            if (r == 1)
            {
                System.Console.WriteLine(r);
                return 1;
            }
            System.Console.WriteLine(r);
            return numer(r - 1);
        }
    }
}