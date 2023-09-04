namespace linkedlist
{
    internal class LinkedList
    {
        static void Main(string[] args)
        {
            var lesson1 = new YTVideo { Id = "yv1", Title = "Variables", Duration = new TimeSpan(12, 30, 11) };
            var lesson2 = new YTVideo { Id = "yv2", Title = "List", Duration = new TimeSpan(11, 30, 33) };
            var lesson3 = new YTVideo { Id = "yv3", Title = "Dictionary", Duration = new TimeSpan(05, 30, 50) };
            var lesson4 = new YTVideo { Id = "yv4", Title = "Stack", Duration = new TimeSpan(02, 30, 43) };
            var lesson5 = new YTVideo { Id = "yv5", Title = "Queue", Duration = new TimeSpan(10, 30, 22) };
            /* LinkedList<YTVideo> Playlist = new LinkedList<YTVideo>(new YTVideo[]
             {
                 lesson1,
                 lesson2,
                 lesson3,
                 lesson4,
                 lesson5
             });*/
            LinkedList<YTVideo> Playlist = new LinkedList<YTVideo>();
            Playlist.AddFirst(lesson1);
            Playlist.AddAfter(Playlist.First, lesson2);
            var node = new LinkedListNode<YTVideo>(lesson3);
            Playlist.AddAfter(Playlist.First.Next, node);
            Playlist.AddLast(lesson5);
            Playlist.AddBefore(Playlist.Last, lesson4);
            Print("C# from Zero to Hero", Playlist);
        }
        static void Print(string title , LinkedList<YTVideo> playlist)
        {
            Console.WriteLine($"{title}");
            foreach(var video in playlist)
            {
                Console.WriteLine(video);
            }
            Console.WriteLine($"total :{playlist.Count} item(s)");
        }
    }
    class YTVideo
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public override string ToString()
        {
            return $"{Title} ({Duration})\n\thttps;://WWW.Youtube.Com/Watch?V={Id}";
        }
    }
}