using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ints = new FiveIntergers(1, 2, 3, 4, 5);
            foreach(var i in ints)
            {
                Console.WriteLine(i);
            }
        }

    }
    class FiveIntergers : IEnumerable
    {
        int[] _values;
        public FiveIntergers(int n1, int n2, int n3, int n4, int n5)
        {
             _values = new[] { n1, n2, n3, n4, n5 }; 
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var item in _values)
            {
                yield return item;
            }
        }
        /*class Enumerator : IEnumerator 
        {
            int currentindex = -1;
            FiveIntergers _integers;
            public Enumerator(FiveIntergers integers)
            {
                 _integers = integers;
            }

            public object Current
            {
                get
                {
                    if(currentindex == -1)
                    {
                        throw new InvalidOperationException("Enumerations Not started");
                    }
                    if(currentindex == _integers._values.Length)
                    {
                        throw new InvalidOperationException("Enumerations has Ended");
                    }
                    return _integers._values[currentindex];
                }
            }

            public bool MoveNext()
            {
               if(currentindex >= _integers._values.Length - 1)
                {
                    return false;
                }
               return ++currentindex < _integers._values.Length;
            }

            public void Reset()
            {
                currentindex = -1;
            }
        }*/
    }
}