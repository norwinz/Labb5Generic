//Labb 5 Generic Class. Dan Gustafsson SUT-21
using System;

namespace Labb5Generic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Child1<int> c1 = new Child1<int>(6, 5);
            Child1<string> c2 = new Child1<string>("Hej", "Hej");

            Child2<double> c3 = new Child2<double>(4.1, 4.1);
            Child2<string> c4 = new Child2<string>("Hej", "Hejdå");

            c1.toCheck();
            c2.toCheck();
            c3.toCheck();
            c4.toCheck();

        }
    }
}
