using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Sort;
using System.Diagnostics;

namespace SandBox
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BencmarkForSorting>();
           
        }

        

    }

    
    public class BencmarkForSorting
    {
        public static List<int> List = RandomGeneratedList();
        public static List<int> RandomGeneratedList()
        {
            var list = new List<int>();
            var rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                list.Add(rnd.Next(0, 2000));
            }

            return list;
        }
        [Benchmark(Description = "OurSort")]
        public void MeasureCoutingSort()
        {
            var cr = new CountingSort();
            cr.Sort(List, 2000, 2000);
        }

        [Benchmark(Description = "QuickSort")]
        public void MeasureSort()
        {
            List.Sort();
        }

    }
}