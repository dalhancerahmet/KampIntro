using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Generics");
            Console.WriteLine(myList);

            Console.WriteLine("Hello World!");
        }
    }
}
