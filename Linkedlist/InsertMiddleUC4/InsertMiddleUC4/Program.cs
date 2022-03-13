using System;

namespace InsertMiddleUC4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //UseCase 1
                Operations obj = new Operations();
                //Insertion Operation
                obj.Append(56);
                obj.Append(30);
                obj.Append(70);
                //Display Operation
                Console.WriteLine("Inserting");
                obj.Display();
            }
        }
    }
}
