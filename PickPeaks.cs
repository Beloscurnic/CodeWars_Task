namespace CodeWars_Task
{

    //    В этом ката вы напишете функцию, которая возвращает позиции и значения «пиков» (или локальных максимумов) числового массива.

    //Например, массив arr = [0, 1, 2, 5, 1, 0]имеет пик в позиции 3со значением 5(поскольку arr[3] равно 5).

    //Вывод будет возвращен как Dictionary<string, List<int>> с двумя парами ключ-значение: "pos"и "peaks". Если в данном массиве нет пика, просто верните {"pos" => new List<int>(), "peaks" => new List<int>()
    //}.

    //Пример: pickPeaks([3, 2, 3, 6, 4, 1, 2, 3, 2, 1, 2, 3])должно возвращаться { pos: [3, 7], peaks: [6, 3]} (или эквивалент на других языках)

    //Все входные массивы будут действительными целочисленными массивами (хотя они могут быть пустыми), поэтому вам не нужно будет проверять ввод.

    //Первый и последний элементы массива не будут считаться пиками (в контексте математической функции мы не знаем, что находится после, а что до, и, следовательно, мы не знаем, пик это или нет).

    //Также остерегайтесь плато!!! [1, 2, 2, 2, 1] имеет пик в то время как [1, 2, 2, 2, 3] и[1, 2, 2, 2, 2]нет.В случае плато-пика, пожалуйста, верните только положение и значение начала плато. Например: pickPeaks([1, 2, 2, 2, 1])возвращает
    //{ pos: [1], peaks: [2]} (или эквивалент на других языках)
    public class PickPeaks
    {
        public static Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
            var result = new Dictionary<string, List<int>>()
            {
                {"pos", new List<int>() },
                {"peaks", new List<int>() }
            };
            if (arr == null || arr.Length == 0)
            {
                return result;
            }
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i - 1] < arr[i] && arr[i] > arr[i + 1])
                {
                    result["pos"].Add(i);
                    result["peaks"].Add(arr[i]);
                }
                else if (arr[i - 1] < arr[i] && arr[i] == arr[i + 1])
                {
                    int plateauStart = i;
                    while (i < arr.Length - 1 && arr[i] == arr[i + 1])
                        i++;

                    if (i < arr.Length - 1 && arr[i] > arr[i + 1])
                    {
                        result["pos"].Add(plateauStart);
                        result["peaks"].Add(arr[plateauStart]);
                    }
                }

            }
            return result;
        }
    }


    //public class PickPeaks
    //{
    //    public static Dictionary<string, List<int>> GetPeaks(int[] arr)
    //    {
    //        int pos = 0, peaks = 0;

    //        Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
    //        dictionary.Add("pos", new List<int>());
    //        dictionary.Add("peaks", new List<int>());
    //        for (int i = 1; i < arr.Length - 1; i++)
    //        {
    //            if (arr[i] > arr[i - 1])
    //            {
    //                pos = i;
    //                peaks = arr[i];
    //            }
    //            if (arr[i] > arr[i + 1] && pos != 0)
    //            {
    //                dictionary["pos"].Add(pos);
    //                dictionary["peaks"].Add(peaks);
    //                pos = 0;
    //                peaks = 0;
    //            }
    //        }

    //        return dictionary;
    //    }
    //}
    public class SolutionTest_PickPeaks
    {

        private static string[] msg =
        {
        "should support finding peaks",
        "should support finding peaks, but should ignore peaks on the edge of the array",
        "should support finding peaks; if the peak is a plateau, it should only return the position of the first element of the plateau",
        "should support finding peaks; if the peak is a plateau, it should only return the position of the first element of the plateau",
        "should support finding peaks, but should ignore peaks on the edge of the array"
    };

        private static int[][] array =
        {
        new int[]{1,2,3,6,4,1,2,3,2,1},
        new int[]{3,2,3,6,4,1,2,3,2,1,2,3},
        new int[]{3,2,3,6,4,1,2,3,2,1,2,2,2,1},
        new int[]{2,1,3,1,2,2,2,2,1},
        new int[]{2,1,3,1,2,2,2,2}
    };

        private static int[][] posS =
        {
        new int[]{3,7},
        new int[]{3,7},
        new int[]{3,7,10},
        new int[]{2,4},
        new int[]{2}
    };

        private static int[][] peaksS =
        {
        new int[]{6,3},
        new int[]{6,3},
        new int[]{6,3,2},
        new int[]{3,2},
        new int[]{3}
    };

        [Test]
        public void SampleTests()
        {
            for (int n = 0; n < msg.Length; n++)
            {
                int[] p1 = posS[n], p2 = peaksS[n];
                var expected = new Dictionary<string, List<int>>()
                {
                    ["pos"] = p1.ToList(),
                    ["peaks"] = p2.ToList()
                };
                var actual = PickPeaks.GetPeaks(array[n]);
                Assert.AreEqual(expected, actual, msg[n]);
            }
        }
    }
}