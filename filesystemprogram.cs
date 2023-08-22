using System.Runtime;

namespace filesysytemprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Write(">> ");
                var input = Console.ReadLine().Trim();
                var whitespaceindex = input.IndexOf(' ');
                var command = input.Substring(0, whitespaceindex);
                Console.WriteLine($"command: {command}");
                var path = input.Substring(whitespaceindex + 1);
                Console.WriteLine($"path: {path}");
                Console.WriteLine("=================================================");
                // list files & directories : list [path]
                if (command == "list")
                {
                    foreach (var entry in Directory.GetDirectories(path, "*algorithms*"))
                    {
                        Console.WriteLine($"\t[Dir]{entry}");
                    }
                    foreach (var entry in Directory.GetFiles(path))
                    {
                        Console.WriteLine($"\t[file]{entry}");
                    }
                }
                // print files & directories info : info [path]
                else if (command == "info")
                { 
                    if (Directory.Exists(path))
                    {
                        var dirinfo = new DirectoryInfo(path);
                        Console.WriteLine("type : Directory");
                        Console.WriteLine($"create at : {dirinfo.CreationTime}");
                        Console.WriteLine($"last modified at : {dirinfo.LastWriteTime}");
                    }
                    else if (File.Exists(path))
                    {
                        var fileinfo = new FileInfo(path);
                        Console.WriteLine("type : File");
                        Console.WriteLine($"create at : {fileinfo.CreationTime}");
                        Console.WriteLine($"last modified at : {fileinfo.LastWriteTime}");
                        Console.WriteLine($"size in byte :{fileinfo.Length}");
                    }

                }
                // create directory : mkdir [path]
                else if (command == "mkdir")
                {
                    Directory.CreateDirectory(path);
                }
                // read file content : read [path]
                else if (command == "read")
                {
                    if (File.Exists(path))
                    {
                        var content = File.ReadAllText(path);
                        Console.WriteLine(content);
                    }
                    
                }
                // remove directory : remove [path]
                else if (command == "remove")
                {
                    if (Directory.Exists(path))
                    {
                        Directory.Delete(path);
                    }
                    else if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                }
                else if (command == "exit")
                {
                    break;
                }
            }
        }
    }
}