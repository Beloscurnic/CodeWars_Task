namespace CodeWars_Task
{
    public class DoubleLinear
    {

        public static int DblLinear(int n)
        {
            var list = new HashSet<int>() { 1 };
            var result_list = new List<int>() { 1 };
            var i = 1;
            int a, b;
            while (result_list.Count == n)
            {

                a = 2 * i + 1;
                b = 3 * i + 1;
                if (a > b)
                {
                    result_list.Add(b);
                }
                else
                {
                    result_list.Add(a);
                    list.Contains(i);
                }
                if (list.Contains(i))
                {

                }
                else if (list.Contains(3 * i + 1))
                {

                }
                
            }
        }

        [TestFixture]
        public static class DoubleLinearTests
        {

            private static void testing(int actual, int expected)
            {
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public static void test1()
            {
                Console.WriteLine("Fixed Tests DblLinear");
                testing(DoubleLinear.DblLinear(10), 22);
                testing(DoubleLinear.DblLinear(20), 57);
                testing(DoubleLinear.DblLinear(30), 91);
                testing(DoubleLinear.DblLinear(50), 175);
            }

        }
    }
}
