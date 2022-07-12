using Sort;

namespace SortTesting
{
    public class SortTests
    {
        public List<int> GenerateRandomList(int size, int maxValue)
        {
            var list = new List<int>();
            var rand = new Random();
            for (int i = 0; i < size; i++)
                list.Add(rand.Next(0, maxValue));
            return list;
        }

        [Fact]
        public void PregeneratedListTest()
        {
            int maxValue = 20;
            var list = new List<int>()
            {
                20, 17, 10, 9, 5, 2, 3, 5, 0, 5, 2, 6, 4, 8, 0, 17
            };
            var expectedList = list.OrderBy(n => n).ToList();
            CountingSort cs = new CountingSort();

            Assert.Equal(cs.Sort(list, 20, maxValue), expectedList);    
        }

        [Fact]
        public void RandomListTest()
        {
            int size = 100000;
            int maxValue = 2000;
            var list = GenerateRandomList(size, maxValue);
            var expectedList = list.OrderBy(n => n).ToList();
            CountingSort cs = new CountingSort();

            Assert.Equal(cs.Sort(list, 2000, maxValue), expectedList);
        }
    }
}