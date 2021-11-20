using System;
using System.Collections.Generic;
using System.Text;

namespace Labb5Generic
{
    public class Check<T>
    {
        T A;
        T B;
        public Check(T a, T b)
        {
            this.A = a;
            this.B = b;
        }
        public void toCheck()
        {
            
            if (A.Equals(B))
            {
                Console.WriteLine("'{0}' and '{1}' is equal.", A,B);
            }
            else
            {
                Console.WriteLine("'{0}' and '{1}' is NOT equal.", A, B);
            }

            
        }
    }
}
