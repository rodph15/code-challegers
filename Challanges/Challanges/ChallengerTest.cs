namespace Challanges
{
    public class ChallengerTest
    {
        [Theory]
        [InlineData("MMMMMMMMMMMMMMMMMMMMMMMMMCDXLV", 25445)]
        [InlineData("XIV", 14)]
        [InlineData("IX", 9)]
        [InlineData("CMXCIX", 999)]
        public void RomanGenerator_IntToString(string roman, int number)
        {

            var romanGenerator = new RomanGenerator();

            Assert.Equal(roman, romanGenerator.IntToRoman(number));
        }

        [Theory]
        [InlineData("MMMMMMMMMMMMMMMMMMMMMMMMMCDXLV", 25445)]
        [InlineData("XIV", 14)]
        [InlineData("IX", 9)]
        [InlineData("CMXCIX", 999)]
        public void RomanGenerator_StringToInt(string roman, int number)
        {
            var romanGenerator = new RomanGenerator();

            Assert.Equal(number, romanGenerator.RomanToInt(roman));
        }
    }
}