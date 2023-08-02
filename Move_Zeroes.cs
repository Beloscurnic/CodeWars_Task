namespace CodeWars_Task
{
    //    Напишите алгоритм, который берет массив и перемещает все нули в конец, сохраняя порядок остальных элементов.

    //Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }

    internal class Move_Zeroes
    {
        public static int[] MoveZeroes(int[] arr)
        {
            var result = new int[arr.Length];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                    result[i - j] = arr[i];
                else if (arr[i] == 0)
                {
                    result[arr.Length - 1 - j] = 0;
                    j++;
                }
            }
            return result;
        }

        //public static int[] MoveZeroes(int[] arr)
        //{
        //    return arr.OrderBy(x => x == 0).ToArray();
        //}

        [TestFixture]
        public class Sample_Test
        {
            [Test]
            public void Test()
            {
                Assert.AreEqual(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, Move_Zeroes.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
            }
        }
    }
}