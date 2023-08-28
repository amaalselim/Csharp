using System.Runtime.InteropServices;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Any<int>();
            numbers.add(1);
            numbers.add(2);
            numbers.add(3);
            Console.Write("Array after adding : ");
            numbers.DisplayList();
            Console.WriteLine("=================================================");
            Console.WriteLine($"Length : {numbers.count} items");
            Console.WriteLine($"Empty : {numbers.IsEmpty}");
            numbers.removeat(1);
            Console.Write("Array after Remove index 1 : ");
            numbers.DisplayList();
            Console.WriteLine($"Length : {numbers.count} items");
            Console.WriteLine($"Empty : {numbers.IsEmpty}");
            Console.WriteLine("=================================================");
            /*
             output : 
            Array after adding : [1, 2, 3]
            =================================================
            Length : 3 items
            Empty : False
            Array after Remove index 1 : [1, 3]
            Length : 2 items
            Empty : False
            =================================================
             */
        }
    }
    class Any<T>
    {
        private T[] items;
        public bool IsEmpty => items is null || items.Length == 0;
        public int count => items is null ? 0 : items.Length;
        public void add (T item)
        {
            if(items is null)
            {
                items = new T[] { item };
            }
            else
            {
                var length = items.Length;
                var dest = new T[length+1];
                for (int i = 0; i < length; i++)
                {
                    dest[i] = items[i];
                }
                dest[dest.Length - 1] = item;
                items= dest;
            }
        }
        public void removeat (int position) 
        {
            if (position < 0 || position > items.Length - 1)
                return;
            var index = 0;
            var dest = new T[items.Length - 1];
            for(int i=0;i< items.Length; i++)
            {
                if (position == i)
                    continue;
                dest[index++] = items[i];
            }
            items = dest;
        }
        public void DisplayList()
        {
            Console.Write('[');
            for (int i = 0;i < items.Length;i++) 
            {
                Console.Write(items[i]);
                if(i<items.Length-1) Console.Write(", ");
            }
            Console.WriteLine(']');
        }
       
    }
}