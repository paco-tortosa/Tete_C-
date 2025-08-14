using FirstLib;

namespace FirstTest;

public class cUnitTest01_t
{
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-2, 3, 1)]
    public void Test_001_Add(double op1, double op2, double result)
    {
        Assert.Equal(result, cMain_t.s_Add(op1, op2));
    }

    [Theory]
    [InlineData(0, "12345")]
    [InlineData(8, "90123")]
    [InlineData(5, "67890")]
    public void Test_002_Get5NextNumbersInaString(int startingInt, string result)
    {
        Assert.Equal(result, cMain_t.s_Get5NextNumbersInaString(startingInt));
    }

    [Theory]
    [InlineData('0', "12345")]
    [InlineData('8', "9:;<=")]
    [InlineData('5', "6789:")]
    [InlineData('D', "EFGHI")]
    [InlineData('d', "efghi")]
    public void Test_003_Get5NextCharsInaString(char startingChar, string result)
    {
        Assert.Equal(result, cMain_t.s_Get5NextCharsInaString(startingChar));
    }

    [Theory]
    [InlineData(54, "Paco", "My name is Paco and my age is 54.")]
    [InlineData(23, "Teté", "My name is Teté and my age is 23.")]
    [InlineData(24, "Javi", "My name is Javi and my age is 24.")]
    [InlineData(57, "Mª José", "My name is Mª José and my age is 57.")]
    public void Test_004_GetStringAgeAndName(int age, string name, string result)
    {
        Assert.Equal(result, cMain_t.s_GetStringAgeAndName(age, name));
    }

    [Theory]
    [InlineData(100, "I have {100}")]
    [InlineData(-50, "I have {-50}")]
    public void Test_005_GetInterpolatedStringWithBracesSigns(int amount, string result)
    {
        Assert.Equal(result, cMain_t.s_GetInterpolatedStringWithBracesSigns(amount));
    }

    [Theory]
    [InlineData(64, "The number 64 in hex is 0x40")]
    [InlineData(127, "The number 127 in hex is 0x7F")]
    public void Test_006_GetHex(int amount, string result)
    {
        Assert.Equal(result, cMain_t.s_GetHex(amount));
    }

    [Theory]
    [InlineData(64, "The number 64 in binary is 1000000")]
    [InlineData(127, "The number 127 in binary is 1111111")]
    public void Test_007_GetBin(int amount, string result)
    {
        Assert.Equal(result, cMain_t.s_GetBin(amount));
    }

    [Theory]
    [InlineData(25.183, "    0025.2")]
    [InlineData(-25.123, "   -0025.1")]
    [InlineData(-2, "   -0002.0")]
    public void Test_008_GetFormattedNumberAlignedToTheRight(decimal num, string result)
    {
        Assert.Equal(result, cMain_t.s_GetFormattedNumberAlignedToTheRight(num));
    }

    [Theory]
    [InlineData(25.183, "0025.2    ")]
    [InlineData(-25.123, "-0025.1   ")]
    [InlineData(-2, "-0002.0   ")]
    public void Test_009_GetFormattedNumberAlignedToTheLeft(decimal num, string result)
    {
        Assert.Equal(result, cMain_t.s_GetFormattedNumberAlignedToTheLeft(num));
    }

    [Theory]
    [InlineData(25.183, "    0025.2")]
    [InlineData(-25.123, "     -25.1")]
    [InlineData(0, "         0")]
    public void Test_010_GetFormattedNumberAlignedToTheRightConditional(decimal num, string result)
    {
        Assert.Equal(result, cMain_t.s_GetFormattedNumberAlignedToTheRightConditional(num));
    }

    [Theory]
    [InlineData(2002, 6, 27, 20, 23, 55, "2002-06-27 20:23:55")]
    [InlineData(2002, 6, 2, 2, 3, 5, "2002-06-02 02:03:05")]
    public void Test_011_GetFormattedDateTime(int year, int month, int day, int hours, int minutes, int seconds, string result)
    {
        DateTime dt = new(year, month, day, hours, minutes, seconds);
        Assert.Equal(result, cMain_t.s_GetFormattedDateTime(dt));
    }

    [Theory]
    [InlineData(10, 11)]
    [InlineData(-100, -99)]
    [InlineData(100, 101)]
    public void Test_012_ApplyPrefixIncrementAndReturn(int value, int result)
    {
        Assert.Equal(result, cMain_t.s_ApplyPrefixIncrementAndReturn1(value));
        Assert.Equal(result, cMain_t.s_ApplyPrefixIncrementAndReturn2(value));
    }

    [Theory]
    [InlineData(10, 10)]
    [InlineData(-100, -100)]
    [InlineData(100, 100)]
    public void Test_013_ApplyPostfixIncrementAndReturn(int value, int result)
    {
        Assert.Equal(result, cMain_t.s_ApplyPostfixIncrementAndReturn1(value));
        Assert.Equal(result, cMain_t.s_ApplyPostfixIncrementAndReturn2(value));
    }

    [Theory]
    [InlineData(10, true)]
    [InlineData(0, false)]
    [InlineData(9, false)]
    public void Test_014_PrefixIncrementAndCompareIfIsGreaterThan10(int value, bool result)
    {
        Assert.Equal(result, cMain_t.s_ApplyPrefixIncrementAndCompareIfIsGreaterThan10_1(value));
        Assert.Equal(result, cMain_t.s_ApplyPrefixIncrementAndCompareIfIsGreaterThan10_2(value));
    }

    [Theory]
    [InlineData(11, true)]
    [InlineData(10, false)]
    [InlineData(0, false)]
    [InlineData(9, false)]
    public void Test_015_PostfixIncrementAndCompareIfIsGreaterThan10(int value, bool result)
    {
        Assert.Equal(result, cMain_t.s_ApplyPostfixIncrementAndCompareIfIsGreaterThan10_1(value));
        Assert.Equal(result, cMain_t.s_ApplyPostfixIncrementAndCompareIfIsGreaterThan10_2(value));
    }

    [Theory]
    [InlineData(10, 10, "10 is greater or equal than 10")]
    [InlineData(0, 1, "0 is less than 1")]
    [InlineData(0, -1, "0 is greater or equal than -1")]
    public void Test_016_Compare2Numbers(int val1, int val2, string result)
    {
        Assert.Equal(result, cMain_t.s_Compare2Numbers_1(val1, val2));
        Assert.Equal(result, cMain_t.s_Compare2Numbers_2(val1, val2));
    }

    [Theory]
    [InlineData("12345", 5)]
    [InlineData(null, 0)]
    public void Test_017_GetStringLength(string? text, int result)
    {
        Assert.Equal(result, cMain_t.s_GetStringLength_1(text));
        Assert.Equal(result, cMain_t.s_GetStringLength_2(text));
    }

    [Theory]
    [InlineData(5, 2, 1)]
    [InlineData(3, 10, 3)]
    [InlineData(10, 10, 0)]
    [InlineData(31, 10, 1)]
    [InlineData(31, 8, 7)]
    public void Test_018_GetModulus(int val1, int val2, int result)
    {
        Assert.Equal(result, cMain_t.s_GetModulus(val1, val2));
    }

    [Fact]
    public void Test_019_ExperimentingWithNumbers()
    {
        string result = cMain_t.s_ExperimentingWithNumbers();
    }

    [Fact]
    public void Test_020_ExperimentingWithStrings()
    {
        string result = cMain_t.s_ExperimentingWithString();
    }

    [Theory]
    [InlineData(5, 2, 1, false, "Error: Min (2) must be lower or equal than Max (1)")]
    [InlineData(5, 10, 5, false, "Error: Min (10) must be lower or equal than Max (5)")]
    [InlineData(3, 2, 5, true, "")]
    [InlineData(6, 2, 5, false, "")]
    public void Test_021_IsNumberInRange(int num, int min, int max, bool resExpected, string errorExpected)
    {
        string error = "???";
        bool res = cMain_t.s_IsNumberInRange(num, min, max, ref error);
        Assert.Equal(resExpected, res);
        Assert.Equal(errorExpected, error);
    }

    [Theory]
    [InlineData(5, 2, null, true)]
    [InlineData(5, null, 1, false)]
    [InlineData(5, 10, 5, false)]
    [InlineData(3, 2, 5, true)]
    [InlineData(3, null, null, true)]
    [InlineData(6, 2, 5, false)]
    public void Test_022_IsNumberInRangeWithNull(int num, int? min, int? max, bool resExpected)
    {
        Assert.Equal(resExpected, cMain_t.s_IsNumberInRangeWithNull_1(num, min, max));
        Assert.Equal(resExpected, cMain_t.s_IsNumberInRangeWithNull_2(num, min, max));
    }

    [Theory]
    [InlineData(5, 5, 5)]
    [InlineData(5, 4, 4)]
    [InlineData(0b_0110_0101, 0b_0110_0110, 0b_0110_0100)]
    public void Test_023_BitwiseAnd(int num1, int num2, int result)
    {
        Assert.Equal(result, cMain_t.s_BitwiseAnd(num1, num2));
    }

    [Theory]
    [InlineData(0b_0110_0101, 3, 0b_0110_1101)]
    [InlineData(0b_0110_0101, 0, 0b_0110_0101)]
    [InlineData(0b_0110_0101, 7, 0b_1110_0101)]
    public void Test_024_SetBit(int num, int bitPosition, int result)
    {
        Assert.Equal(result, cMain_t.s_SetBit(num, bitPosition));
    }

    [Theory]
    [InlineData(0b_0110_0101, 3, 0b_0110_0101)]
    [InlineData(0b_0110_0101, 0, 0b_0110_0100)]
    [InlineData(0b_1110_0101, 7, 0b_0110_0101)]
    public void Test_025_ClearBit(int num, int bitPosition, int result)
    {
        Assert.Equal(result, cMain_t.s_ClearBit(num, bitPosition));
    }

    [Theory]
    [InlineData(0b_0110_0101, 3, 0b_0010_1000)]
    // [InlineData(0b_0110_0101, 5, ???)]
    // [InlineData(0b_0110_0101, 8, ???)]
    public void Test_026_ShiftToLeftByte(byte num, int positions, byte result)
    {
        Assert.Equal(result, cMain_t.s_ShiftToLeftByte(num, positions));
    }

    [Theory]
    [InlineData(0b_0110_0101, 3, 0b_011_0010_1000)]
    [InlineData(0b_0110_0101, 5, 0b_1100_1010_0000)]
    // [InlineData(0b_0110_0101, 8, ???)]
    public void Test_027_ShiftToLeftInt(int num, int positions, int result)
    {
        Assert.Equal(result, cMain_t.s_ShiftToLeftInt(num, positions));
    }

    [Theory]
    [InlineData(0, "zero")]
    [InlineData(1, "one")]
    [InlineData(2, "two")]
    [InlineData(3, "three")]
    [InlineData(4, "four")]
    [InlineData(5, "five")]
    [InlineData(6, "six")]
    [InlineData(7, "seven")]
    [InlineData(8, "eight")]
    [InlineData(9, "nine")]
    [InlineData(10, "I don't know the name for 10")]
    [InlineData(100, "I don't know the name for 100")]
    // [InlineData(0b_1_0000_0000, ???)]
    // [InlineData(0x1234, ???)]
    public void Test_028_ConvertIntsToStrings(int num, string result)
    {
        Assert.Equal(result, cMain_t.s_ConvertIntsToStrings_UsingIf(num));
        Assert.Equal(result, cMain_t.s_ConvertIntsToStrings_UsingSwitch(num));
        Assert.Equal(result, cMain_t.s_ConvertIntsToStrings_UsingSwitchExpressions(num));  //Curiosity
    }

    [Theory]
    [InlineData(0, 5, "0,1,2,3,4,5")]
    [InlineData(8, 15, "8,9,10,11,12,13,14,15")]
    public void Test_029_GetStringNumbersSeparatedByCommas(int from, int to, string result)
    {
        Assert.Equal(result, cMain_t.s_GetStringNumbersSeparatedByCommas_UsingWhile(from, to));
        Assert.Equal(result, cMain_t.s_GetStringNumbersSeparatedByCommas_UsingDo(from, to));
        Assert.Equal(result, cMain_t.s_GetStringNumbersSeparatedByCommas_UsingFor(from, to));
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 3)]
    [InlineData(new int[] { -3, -2, -1, 0, 1, 2 }, 6)]
    [InlineData(new int[] { }, 0)]
    [InlineData(null, 0)]
    public void Test_030_GetNumberOfElementsOfArray(int[]? aNumbers, int result)
    {
        Assert.Equal(result, cMain_t.s_GetNumberOfElementsOfArray(aNumbers));
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 6)]
    [InlineData(new int[] { -3, -2, -1, 0, 1, 2 }, -3)]
    public void Test_031_SumElementsOfArray(int[] aNumbers, int result)
    {
        Assert.Equal(result, cMain_t.s_SumElementsOfArray_UsingFor(aNumbers));
        Assert.Equal(result, cMain_t.s_SumElementsOfArray_UsingForeach(aNumbers));
    }

    [Theory]
    [InlineData(new int[] { }, 0, 0)]
    [InlineData(new int[] { 1, 2, 3 }, 1, 3)]
    [InlineData(new int[] { -3, -2, -1, 0, 1, 2 }, -3, 2)]
    [InlineData(new int[] { -3, -2, -1, 0, -1, -2, -3 }, -3, 0)]
    public void Test_032_GetMinAndMaxElementsOfArray(int[] aNumbers, int resMin, int resMax)
    {
        int max;
        int min = cMain_t.s_GetMinAndMaxElementsOfArray(aNumbers, out max);
        Assert.Equal(resMin, min);
        Assert.Equal(resMax, max);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, 0)]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 2 }, 1)]
    [InlineData(new int[] { 1 }, new int[] { 1, 2 }, 2)]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2 }, 3)]
    [InlineData(new int[] { }, new int[] { 1, 2 }, 2)]
    [InlineData(new int[] { }, new int[] { }, 0)]
    public void Test_033_CompareArrays(int[] array1, int[] array2, int result)
    {
        Assert.Equal(result, cMain_t.s_CompareArrays(array1, array2));
    }

    [Theory]
    [InlineData(new char[] { '1', '2', '3' }, "123")]
    [InlineData(new char[] { 'T', 'e', 't', 'é' }, "Teté")]
    public void Test_034_GetStringFromArrayOfChars(char[] arrayChars, string result)
    {
        Assert.Equal(result, cMain_t.s_GetStringFromArrayOfChars(arrayChars));
    }

    [Theory]
    [InlineData("123", 123)]
    [InlineData("-123", -123)]
    [InlineData("A0", 160)]
    [InlineData("10F", 271)]
    [InlineData("1001", 9)]
    [InlineData("100100", 36)]
    public void Test_035_CustomConvertStringToNumber(string input, int result)
    {
        //When the 'input' string contains only 1 and 0 -> it is a binary number
        //When the 'input' string contains 'A' to 'F'   -> it is a hex number
        //otherwise it is a decimal number
        Assert.Equal(result, cMain_t.s_CustomConvertStringToNumber(input));
    }

    [Theory]
    [InlineData("123", 123)]
    [InlineData("-123", -123)]
    [InlineData("A0", 0)]
    [InlineData("10F", 0)]
    [InlineData("1001", 1001)]
    [InlineData("100100", 100100)]
    public void Test_036_ParseADecimalInt(string input, int result)
    {
        //Return 0 when the parsing fails
        Assert.Equal(result, cMain_t.s_ParseADecimalInt_UsingExceptions(input));
        Assert.Equal(result, cMain_t.s_ParseADecimalInt_UsingTryParse(input));
    }
}
