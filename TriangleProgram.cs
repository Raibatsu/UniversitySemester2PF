using System;

namespace Example_Proj
{

    class Program
    {
     
        static void Main(string[] args)
        {
            Program read = new Program(); // Apparently C# can't call functions until there is a class to call the function to. We called a new class 'read' inside Main function

            read.DrawUpwardTriangle();
            read.DrawRectangle();
            Console.WriteLine("\n");
            read.DrawRectangle();
            read.DrawDownwardTriangle();
            Console.ReadKey();
        }
        void DrawDownwardTriangle()
        {
            Console.WriteLine("*******");
            Console.WriteLine(" ***** ");
            Console.WriteLine("  *** ");
            Console.WriteLine("   *  ");
        }
        void DrawRectangle()
        {
            Console.WriteLine("_______");
            Console.WriteLine("_______");
            Console.WriteLine("_______");
            Console.WriteLine("_______");
            Console.WriteLine("_______");
        }
        void DrawUpwardTriangle()
        {
            Console.WriteLine("   * ");
            Console.WriteLine("  *** ");
            Console.WriteLine(" ***** ");
            Console.WriteLine("*******");

        }
    }
}
