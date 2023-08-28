namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            print("Amaal");  // Output : Value is : Amaal , And a type of value is : System.String
            print('A');// Output : Value is : A , And a type of value is : System.Char
            print(27102003);// Output : Value is : 27102003 , And a type of value is : System.Int32

        }
        static void print <T> (T value)
        {
            Console.WriteLine($"Value is : {value} , And a type of value is : {typeof(T)}");

        }
    }
}