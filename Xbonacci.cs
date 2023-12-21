namespace CodeWars_Task
{
    //    Как уже видно из названия, он работает в основном как Фибоначчи,
    //    но суммирует последние 3 (вместо 2) чисел последовательности для генерации следующего.
    //    И, что еще хуже, к сожалению, я не услышу, как его произносят не носители итальянского языка :(

    //Итак, если мы хотим начать нашу последовательность Трибоначчи в[1, 1, 1] качестве начального ввода(подпись AKA),
    //у нас есть эта последовательность:

    //[1, 1 ,1, 3, 5, 9, 17, 31, ...]
    //    Но что, если мы начали с[0, 0, 1] подписи? Поскольку, начиная с[0, 1] вместо[1, 1]основного сдвига
    //    обычной последовательности Фибоначчи на одну позицию, у вас может возникнуть соблазн подумать,
    //    что мы получим ту же самую последовательность, сдвинутую на 2 позиции, но это не так, и мы получим:

    //[0, 0, 1, 1, 2, 4, 7, 13, 24, ...]
    //    Что ж, вы, возможно, уже догадались об этом, но для ясности: вам нужно создать функцию Фибоначчи,
    //    которая по заданному массиву / списку сигнатур возвращает первые n элементов — сигнатуру,
    //    включенную в последовательность, заполненную таким образом.

    //    Подпись всегда будет содержать 3 цифры; n всегда будет неотрицательным числом;
    //    если n == 0, то верните пустой массив(за исключением C, возвращающего NULL) и будьте готовы ко всему,
    //    что не указано явно;)
    public class Xbonacci
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0)
                return Array.Empty<double>();
            var result = new List<double>();
            if (n <= 3)
            {
                result.AddRange(signature.Take(n));
                return result.ToArray();
            }
            result.AddRange(signature);
            int i = 3;
            while (i < n)
            {
                result.Add(result.TakeLast(3).Sum());
                i++;
            }
            return result.ToArray();
        }
    }

    //public double[] Tribonacci(double[] signature, int n)
    //{
    //    Array.Resize(ref signature, n);
    //    for (int i = 3; i < n; i++) signature[i] = signature[i - 1] + signature[i - 2] + signature[i - 3];
    //    return signature;
    //}

    [TestFixture]
    public class XbonacciTest
    {
        private Xbonacci variabonacci;

        [SetUp]
        public void SetUp()
        {
            variabonacci = new Xbonacci();
        }

        [TearDown]
        public void TearDown()
        {
            variabonacci = null;
        }

        [Test]
        public void Tests()
        {
            Assert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 10));
            Assert.AreEqual(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, variabonacci.Tribonacci(new double[] { 0, 0, 1 }, 10));
            Assert.AreEqual(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, variabonacci.Tribonacci(new double[] { 0, 1, 1 }, 10));
        }
    }
}
