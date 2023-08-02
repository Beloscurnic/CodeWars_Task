namespace CodeWars_Task
{

    //    Задача о максимальной сумме подмассива состоит в нахождении максимальной суммы непрерывной подпоследовательности в массиве или списке целых чисел:
    //maxSequence[-2, 1, -3, 4, -1, 2, 1, -5, 4]
    //-- should be 6: [4, -1, 2, 1]
    //    Простой случай — это когда список состоит только из положительных чисел, а максимальная сумма — это сумма всего массива.Если список состоит только из отрицательных чисел, вместо этого верните 0.
    //    Пустой список считается имеющим нулевую наибольшую сумму.Обратите внимание, что пустой список или массив также является допустимым подсписком/подмассивом.
    public static class Kata
    {
        public static int MaxSequence(int[] arr)
        {
            if (arr.Length == 0 || arr.Max() < 0)
                return 0;
            var list_max = new List<int>();
            for (int i = 1; i <= arr.Length; i++)
            {
                var sub_array = new int[i];
                for (int j = 0; j < arr.Length - i + 1; j++)
                {
                    for (int k = 0; k < i; k++)
                    {
                        if (j + k < arr.Length)
                            sub_array[k] = arr[j + k];
                    }
                    list_max.Add(sub_array.Sum());
                }
            }
            return list_max.Max();
        }
    }

    //public static int MaxSequence(int[] arr)
    //{
    //    int max = 0;
    //    int sum = 0;
    //    foreach (int i in arr)
    //    {
    //        sum += i;
    //        if (sum > max)
    //            max = sum;
    //        else if (sum < 0)
    //            sum = 0;
    //    }
    //    return max;

    //}

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Test0()
        {
            Assert.AreEqual(0, Kata.MaxSequence(new int[0]));
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual(6, Kata.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }
    }
}
