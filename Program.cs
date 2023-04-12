using System.Security.Cryptography.X509Certificates;

namespace Labb1_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LådaCollection lådor = new LådaCollection();
            lådor.Add(new Låda(10, 10, 10));
            lådor.Add(new Låda(3, 5, 4));
            lådor.Add(new Låda(8, 3, 5));
            lådor.Add(new Låda(10, 10, 10));
            lådor.Add(new Låda(4, 2, 8));


            DisplayData(lådor);

            Console.WriteLine("------------------");

            lådor.Remove(new Låda(3, 5, 4));

            DisplayData(lådor);
            Console.WriteLine();

            Låda checkLåda = new Låda(10, 10, 10);
            Console.WriteLine($"Box with dimensions height: {checkLåda.höjd}, " +
                $"width: {checkLåda.bredd}, length: {checkLåda.längd} exist: {lådor.Contains(checkLåda, new LådaSameDimensions())}");

            Console.WriteLine();

            Låda checkLåda2 = new Låda(5, 10, 3);
            Console.WriteLine($"Box with dimensions height: {checkLåda2.höjd}, " +
                $"width: {checkLåda2.bredd}, length: {checkLåda.längd} exist: {lådor.Contains(checkLåda2, new LådaSameDimensions())}");

            Console.ReadKey();

        }


        public static void DisplayData(LådaCollection lådlist)
        {
            Console.WriteLine("Height\tLength\tWidth");
            foreach (Låda l in lådlist)
            {
                Console.WriteLine($"{l.höjd}\t{l.längd}\t{l.bredd}");
            }
        }



    }
}