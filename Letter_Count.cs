namespace CodeWars_Task
{

    //Основная идея состоит в том, чтобы подсчитать все встречающиеся символы в строке.Если у вас есть строка типа aba,
    //результат должен быть {'a': 2, 'b': 1}.
    //Что делать, если строка пуста? Тогда результатом должен быть пустой литерал объекта, {}.
    public class Letter_Count
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> count_dictionary = str.GroupBy(p => p).Select(g => new { a = g.Key, b = g.Count() }).ToDictionary(group => group.a, group => group.b);
            return count_dictionary;
        }

        //public static Dictionary<char, int> Count(string str)
        //{
        //    return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        //}

        [TestFixture]
        public class Tests
        {
            [Test]
            public static void FixedTest_aaaa()
            {
                Dictionary<char, int> d = new Dictionary<char, int>();
                d.Add('a', 4);
                Assert.AreEqual(d, Letter_Count.Count("aaaa"));
            }

            [Test]
            public static void FixedTest_aabb()
            {
                Dictionary<char, int> d = new Dictionary<char, int>();
                d.Add('a', 2);
                d.Add('b', 2);
                Assert.AreEqual(d, Letter_Count.Count("aabb"));
            }
        }
    }
}
