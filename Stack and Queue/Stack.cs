using System.Data;

namespace Stack
{
    internal class Stack
    {
        static void Main(string[] args)
        {
            Stack <Command> Undo = new Stack <Command> ();
            Stack <Command> Redo = new Stack <Command> ();
            string line;
            while (true)
            {
                Console.Write("url('exit' to Quit): ");
                line = Console.ReadLine().ToLower();
                if (line == "exit") break;
                else if (line == "back")
                {
                    if (Undo.Count > 0)
                    {
                        var item=Undo.Pop ();
                        Redo.Push (item);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (line == "forward")
                {
                    if (Redo.Count > 0)
                    {
                        var item = Redo.Pop();
                        Undo.Push(item);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    // add url to undo list
                    Undo.Push(new Command(line));
                }
                Console.Clear();
                Print("back", Undo);
                Print("Forward", Redo);
            }
        }
        static void Print(string name , Stack<Command> commands)
        {
            Console.WriteLine($"{name} history");
            Console.BackgroundColor = name.ToLower() == "back" ? ConsoleColor.DarkGreen : ConsoleColor.DarkBlue;
            foreach(var u in commands)
            {
                Console.WriteLine($"\t{u}");
            }
            Console.BackgroundColor= ConsoleColor.Black;
                
        }
    }
    class Command
    {
        private readonly DateTime _CreatedAt;
        private readonly string _url;

        public Command(string url)
        {
            _CreatedAt = DateTime.Now;
            _url = url;
        }
        public override string ToString()
        {
            return $"[{this._CreatedAt.ToString("yyyy-MM-dd")} {this._url}" ;
        }
    }
}