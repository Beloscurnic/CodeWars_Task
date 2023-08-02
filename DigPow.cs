namespace CodeWars_Task
{
    public class DigPow
    {
        public static long digPow(int n, int p)
        {
            string numStr = n.ToString();
            int totalSum = 0;

            for (int i = 0; i < numStr.Length; i++)
            {
                int digit = int.Parse(numStr[i].ToString());
                totalSum += (int)Math.Pow(digit, p + i);
            }

            int k = totalSum / n;

            if (totalSum == n * k)
            {
                return k;
            }

            return -1;
        }
    }


    [TestFixture]
    public class DigPowTests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, DigPow.digPow(89, 1));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(-1, DigPow.digPow(92, 1));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(51, DigPow.digPow(46288, 3));
        }
    }
}
