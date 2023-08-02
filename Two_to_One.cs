//Take 2 strings s1 and s2 including only letters from a to z. Return a new sorted string, the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.

//Examples:
//a = "xyaabbbccccdefww"
//b = "xxxxyyyyabklmopq"
//longest(a, b)-> "abcdefklmopqwxy"

//a = "abcdefghijklmnopqrstuvwxyz"
//longest(a, a)-> "abcdefghijklmnopqrstuvwxyz"

using System.Data.SqlTypes;

namespace CodeWars_Task
{
    public class TwoToOne
    {
        public static string Longest(string s1, string s2) => new string (s1.ToCharArray().Union(s2.ToCharArray()).Distinct().OrderBy(x => x).ToArray());
        
    }

    //public class TwoToOne
    //{
    //    public static string Longest(string s1, string s2) => string.Concat(s2.Union(s1).OrderBy(x => x));
    //}

    [TestFixture]
    public static class TwoToOneTests
    {

        [Test]
        public static void test1()
        {
            Assert.AreEqual("aehrsty", TwoToOne.Longest("aretheyhere", "yestheyarehere"));
            Assert.AreEqual("abcdefghilnoprstu", TwoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
            Assert.AreEqual("acefghilmnoprstuy", TwoToOne.Longest("inmanylanguages", "theresapairoffunctions"));
        }
    }
}
