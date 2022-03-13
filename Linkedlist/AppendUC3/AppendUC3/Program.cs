using System;

namespace AppendUC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations obj = new Operations();
            //Insertion Operation
            obj.Append(56);
            obj.Append(30);
            obj.Append(70);
            //Display Operation
            Console.WriteLine("*****Appending*****");
            obj.Display();
        }
    }
}
