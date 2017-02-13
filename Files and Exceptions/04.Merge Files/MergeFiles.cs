namespace _04.Merge_Files
{
    using System.Linq;
    using System.IO;

    public class MergeFiles
    {
        public static void Main()
        {
            var firsFile = File.ReadAllLines("FileOne.txt");
            var secondFile = File.ReadAllLines("FileTwo.txt");
            var result = firsFile.Concat(secondFile).OrderBy(x => x);
            File.AppendAllLines("output.txt", result);
        }
    }
}
