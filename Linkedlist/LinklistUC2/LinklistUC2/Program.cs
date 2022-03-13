
using System;

namespace LinklistUC2
{
    internal class Program
    {
        static void Main(string[] args)
            {
                //UseCase 1
                Operations obj = new Operations();
                //Insertion Operation
                obj.InsertFront(56);
                obj.InsertFront(30);
                obj.InsertFront(70);
                //Display Operation
                Console.WriteLine("*****Insertion at First*****");
                obj.Display();
            }
       
    }
}
