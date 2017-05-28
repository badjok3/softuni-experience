using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var filesByRoot = new Dictionary<string, Dictionary<string, long>>();
            var directories = int.Parse(Console.ReadLine());

            for (int i = 0; i < directories; i++)
            {
                var parameters = Console.ReadLine().Split('\\').ToArray();
                var root = parameters[0];
                var file = parameters[parameters.Length - 1].Split(';');
                var fileName = file[0];
                var fileSize = long.Parse(file[1]);

                if (!filesByRoot.ContainsKey(root))
                {
                    filesByRoot.Add(root, new Dictionary<string, long>());
                }

                if (filesByRoot[root].ContainsKey(fileName))
                {
                    filesByRoot[root][fileName] = fileSize;
                }

                else
                {
                    filesByRoot[root].Add(fileName, fileSize);
                }
            }

            var querry = Console.ReadLine().Split(' ');
            var querryExtension = querry[0];
            var querryRoot = querry[2];

            var result = new Dictionary<string, long>();
            foreach (var dir in filesByRoot)
            {
                if (dir.Key == querryRoot)
                {
                    foreach (var file in dir.Value)
                    {
                        if (file.Key.EndsWith(querryExtension))
                        {
                            result.Add(file.Key, file.Value);
                        }
                    }
                }
            }

            if (result.Count > 0)
            {
                foreach (var item in result.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key} - {item.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
