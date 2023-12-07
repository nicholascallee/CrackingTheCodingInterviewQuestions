using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace CrackingTheCodingInterviewQuestions.Test
{
    [TestFixture]
    public class ArraysAndStringsTest
    {

        [Test]
        public void test1()
        {
            ClassicAssert.AreEqual(ArraysAndStrings.AreAllCharactersUnique("asdfgh"), true);
            ClassicAssert.AreEqual(ArraysAndStrings.AreAllCharactersUnique("asdfgfffh"), false);
        }

        [Test]
        public void test2()
        {

            ClassicAssert.AreEqual(ArraysAndStrings.AreAllCharactersUniqueWithOnlyString("asdfgh"),true);
            ClassicAssert.AreEqual(ArraysAndStrings.AreAllCharactersUniqueWithOnlyString("asdfgfffh"),false);

        }

        [Test]
        public void test3()
        {
            ClassicAssert.AreEqual(ArraysAndStrings.IsPermutation("desserts", "stressed"),true);
            ClassicAssert.AreEqual(ArraysAndStrings.IsPermutation("desdserts", "stressesdfdd"), false);
            ClassicAssert.AreEqual(ArraysAndStrings.IsPermutation("desserts", "stressffed"), false);
        }

        [Test]
        public void test4()
        {
            ClassicAssert.AreEqual(true, ArraysAndStrings.PalindromePermutation("racecar"));
            ClassicAssert.AreEqual(true, ArraysAndStrings.PalindromePermutation("cearcra"));
            ClassicAssert.AreEqual(false, ArraysAndStrings.PalindromePermutation("dessertsssss"));
        }
        [Test]
        public void test5()
        {
            ClassicAssert.AreEqual(true, ArraysAndStrings.OneAway("racecar","racecarr"));
            ClassicAssert.AreEqual(true, ArraysAndStrings.OneAway("racecar", "raacecar"));
            ClassicAssert.AreEqual(false, ArraysAndStrings.OneAway("racecar", "raffffacecar"));
            ClassicAssert.AreEqual(true, ArraysAndStrings.OneAway("racecar", "rcecar"));
            ClassicAssert.AreEqual(true, ArraysAndStrings.OneAway("racecar", "raacecar"));
            ClassicAssert.AreEqual(false, ArraysAndStrings.OneAway("racecar", "raffcecarr"));
        }
    }
}
