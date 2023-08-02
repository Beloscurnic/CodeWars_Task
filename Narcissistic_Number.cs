using Newtonsoft.Json.Linq;

//Нарциссическое число(или число Армстронга) — это положительное число, представляющее собой сумму собственных цифр, каждая из которых возведена в степень количества цифр в данном основании. В этом Ката мы ограничимся десятичными числами (с основанием 10).

//Например, возьмем 153(3 цифры), что является самовлюбленным:

//    1 ^ 3 + 5 ^ 3 + 3 ^ 3 = 1 + 125 + 27 = 153
//и 1652(4 цифры), что не является:

//    1 ^ 4 + 6 ^ 4 + 5 ^ 4 + 2 ^ 4 = 1 + 1296 + 625 + 16 = 1938

namespace CodeWars_Task
{
    public class Narcissistic_Number
    {
        public static bool Narcissistic(int value)
        {
            var value_string = Convert.ToString(value);
            // if (value_string.Aggregate(0, (y, x) => y+(int) Math.Pow(int.Parse(x.ToString()), value_string.Length)) == value)
            if (value_string.Sum(x => Math.Pow(int.Parse(x.ToString()), value_string.Length)) == value)
                return true;
            else return false;
        }
    }

    [TestFixture]
    public class Sample_Test
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(1)
                                .Returns(true)
                                .SetDescription("1 is narcissitic");
                yield return new TestCaseData(371)
                                .Returns(true)
                                .SetDescription("371 is narcissitic");

            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(int n) => Narcissistic_Number.Narcissistic(n);
    }
}
