namespace Queue
{
    internal class Queue
    {
        static void Main(string[] args)
        {
            Queue<PrintingJob> printingJobs = new Queue<PrintingJob>();
            printingJobs.Enqueue(new PrintingJob("queue.cs", 2));
            printingJobs.Enqueue(new PrintingJob("stackoverflow.cs", 5));
            printingJobs.Enqueue(new PrintingJob("index.html", 3));
            printingJobs.Enqueue(new PrintingJob("users.pdf", 2));
            printingJobs.Enqueue(new PrintingJob("documets.xlsx", 3));
            printingJobs.Enqueue(new PrintingJob("index.css", 5));
            Console.WriteLine($"Current Queue Count: {printingJobs.Count}");
            Random rnd = new Random();
            while (printingJobs.Count > 0)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                var job = printingJobs.Dequeue();
                Console.WriteLine($"Printing...[{job}]");
                System.Threading.Thread.Sleep(rnd.Next(1,5)*1000);
                Console.WriteLine($"Current Queue Count: {printingJobs.Count}");
            }
        }
        
    }
    class PrintingJob
    {
        private readonly string _file;
        private readonly int _copies;

        public PrintingJob(string file, int copies)
        {
            _file = file;
            _copies = copies;
        }
        public override string ToString()
        {
            return $"{_file} x #{_copies} copies";
        }
    }
}