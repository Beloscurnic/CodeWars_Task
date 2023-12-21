namespace CodeWars_Task
{
    public class DoubleLinear
    {

        public static int DblLinear(int n)
        {
            var list = new HashSet<int> { 1 };
            var result_list = new List<int> { 1 };
            var i = 1;

            while (result_list.Count < n)
            {
                int a = 2 * result_list[i] + 1;
                int b = 3 * result_list[i] + 1;

                if (!list.Contains(a))
                {
                    list.Add(a);
                    result_list.Add(a);
                }

                if (!list.Contains(b))
                {
                    list.Add(b);
                    result_list.Add(b);
                }

                i++;
            }

            return result_list[n - 1];
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
    

