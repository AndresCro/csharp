using System;

namespace clases_genes
{
    class Program
    {
        static void Main(string[] args)
        {
            stacks<double> stackon = new stacks<double>(10);

            stackon.Push(1.21);
            stackon.Push(1.12233);

            double x = stackon.Pop();

            Console.WriteLine("X: {0}", x);

            stacks<pilas> pilon = new stacks<pilas>(10);
            pilon.Push(new pilas());
            pilon.Push(new pilas());

            pilas p = pilon.Pop();

            Console.WriteLine("P: {0}", p);
        }
    }
}
