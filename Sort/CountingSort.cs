namespace Sort
{
    public class CountingSort
    {
        /// <summary>
        /// Returned sorted list.Memory - O(1), time O(n)
        /// Benchmark
        /// 
        /// |    Method |          Mean |        Error |       StdDev |        Median |
        /// |---------- |--------------:|-------------:|-------------:|--------------:|
        /// |   OurSort |      15.24 ns |     0.536 ns |     1.477 ns |      14.64 ns |
        /// | QuickSort | 155,395.45 ns | 2,955.419 ns | 6,670.873 ns | 152,338.21 ns | Deefault sort for Windows
        /// </summary>
        /// <param name="inputStream">Поток чисел от 0 до maxValue. Длина потока не превышает 
        /// миллиарда чисел</param>
        /// <param name="sortFactory">Фактор упорядоченности потока. Неотрицательное число. 
        /// Если в потоке встретилось число x, то в нём больше не встретятся числа меньше,
        /// чем (x - sortFactory)</param>
        /// <param name="maxValue">Максимально возможное значение чисел в потоке.
        /// Неотрицательное число, не превышающее 2000</param>
        /// <returns>Отсортированныйпо возратсанию поток чисел</returns>
        public IEnumerable<int> Sort(IEnumerable<int> inputStream, int sortFactory, int maxValue)
        {
            int[] supportArr = new int[maxValue + 1];
            var enumerator = inputStream.GetEnumerator();
            while (enumerator.MoveNext())
            {
                ++supportArr[enumerator.Current];
            }

            for (int i = 0; i < supportArr.Length; ++i)
            {
                for (int j = 0; j < supportArr[i]; ++j)
                {
                    yield return i;
                }
            }
        }
    }
}