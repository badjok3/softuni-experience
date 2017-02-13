namespace _05.Folder_Size
{
    using System.IO;
    using System.Linq;

    public class FolderSize
    {
       public static void Main()
        {
            var totalLength = Directory.GetFiles("TestFolder")
                .Select(f => new FileInfo(f))
                .Sum(f => f.Length);
            var result = totalLength / 1024.0 / 1024.0;

            File.WriteAllText("output.txt", result.ToString());
        }
    }
}
