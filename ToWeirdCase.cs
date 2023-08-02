//Напишите функцию toWeirdCase( weirdcaseв Ruby), которая принимает строку и возвращает ту же строку со всеми символами с четным индексом в каждом слове в верхнем регистре и всеми символами с нечетным индексом в каждом слове в нижнем регистре. Только что объясненная индексация основана на нуле, поэтому нулевой индекс четный, поэтому этот символ должен быть в верхнем регистре, и вам нужно начинать заново для каждого слова.

//Передаваемая строка будет состоять только из букв алфавита и пробелов ( ' '). Пробелы будут присутствовать только в том случае, если слов несколько. Слова будут разделены одним пробелом ( ' ').

//Примеры:
//toWeirdCase("String");//=> returns "StRiNg"
//toWeirdCase("Weird string case");//=> returns "WeIrD StRiNg CaSe"

namespace CodeWars_Task
{
    public class To_Weird_Case
    {
        public static string ToWeirdCase(string s)
        {
            string[] s_words = s.Split(" ");
            for (int i=0; i<s_words.Length; i++)
            {
                s_words[i] =new string( s_words[i].Select((x, index) => (index % 2 == 0 ? x = char.ToUpper(x) : char.ToLower(x))).ToArray());                
            }
            return String.Join(" ", s_words);
        }

        //public static string ToWeirdCase(string s)
        //{
        //    return string.Join(" ",
        //      s.Split(' ')
        //      .Select(w => string.Concat(
        //        w.Select((ch, i) => i % 2 == 0 ? char.ToUpper(ch) : char.ToLower(ch)
        //      ))));
        //}

        [TestFixture]
        public class Tests
        {
            [Test]
            public static void ShouldWorkForSomeExamples()
            {
                Assert.AreEqual("ThIs", ToWeirdCase("This"));
                Assert.AreEqual("Is", ToWeirdCase("Is"));
                Assert.AreEqual("ThIs Is A TeSt", ToWeirdCase("This is a test"));
            }
        }
    }
}
