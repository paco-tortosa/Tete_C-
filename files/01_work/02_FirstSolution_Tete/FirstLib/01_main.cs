namespace FirstLib;

public class cMain_t
{
    public static double s_Add(double op1, double op2)
    {
        return op1 + op2;
    }

    public static string s_Get5NextNumbersInaString(int startingInt)
    {
        string result = "";
        for (int i = 1; i <= 5; i++)
        {
            result += (startingInt + i) % 10;
        }
        return result;
    }

    public static string s_Get5NextCharsInaString(char startingChar)
    {
        string result = "";
        for (int i = 1; i <= 5; i++)
        {
            startingChar++;
            result += startingChar;
        }
        return result;
    }

    public static string s_GetStringAgeAndName(int age, string name)
    {
        //Use interpolated string
        return $"My name is {name} and my age is {age}.";
    }

    public static string s_GetInterpolatedStringWithBracesSigns(int amount)
    {
        //To have a brace { or } inside an interpolated string, just double it
        return $"I have {{{amount}}}";
    }

    public static string s_GetHex(int num)
    {
        return $"The number {num:N0} in hex is 0x{num:X}";
    }

    public static string s_GetBin(int num)
    {
        return $"The number {num:N0} in binary is {num:b}";
    }

    public static string s_GetFormattedNumberAlignedToTheRight(decimal num)
    {
        return $"{num,10:0000.0}";
    }

    public static string s_GetFormattedNumberAlignedToTheLeft(decimal num)
    {
        return $"{num,-10:0000.0}";
    }

    public static string s_GetFormattedNumberAlignedToTheRightConditional(decimal num)
    {
        return $"{num,10:0000.0;-####.#;0}";
    }

    public static string s_GetFormattedDateTime(DateTime dt)
    {
        return $"{dt:yyyy-MM-dd HH:mm:ss}";
    }

    public static int s_ApplyPrefixIncrementAndReturn1(int value)
    {
        return ++value;
    }

    public static int s_ApplyPrefixIncrementAndReturn2(int value)
    {
        ++value;
        return value;
    }

    public static int s_ApplyPostfixIncrementAndReturn1(int value)
    {
        return value++;
    }

    public static int s_ApplyPostfixIncrementAndReturn2(int value)
    {
        return value;
        // value++;
    }

    public static bool s_ApplyPrefixIncrementAndCompareIfIsGreaterThan10_1(int value)
    {
        bool result = ++value > 10;
        return result;
    }

    public static bool s_ApplyPrefixIncrementAndCompareIfIsGreaterThan10_2(int value)
    {
        ++value;
        bool result = value > 10;
        return result;
    }

    public static bool s_ApplyPostfixIncrementAndCompareIfIsGreaterThan10_1(int value)
    {
        bool result = value++ > 10;
        return result;
    }

    public static bool s_ApplyPostfixIncrementAndCompareIfIsGreaterThan10_2(int value)
    {
        bool result = value > 10;
        value++;
        return result;
    }

    public static string s_Compare2Numbers_1(int val1, int val2)
    {
        return (val1 >= val2) ? $"{val1} is greater or equal than {val2}" : $"{val1} is less than {val2}";
    }

    public static string s_Compare2Numbers_2(int val1, int val2)
    {
        if (val1 >= val2)
        {
            return $"{val1} is greater or equal than {val2}";
        }
        else
        {
            return $"{val1} is less than {val2}";
        }
    }

    public static void s_ExperimentingWithNullable()
    {
        string? value = null;
        Console.Write(value);
    }

    public static int s_GetStringLength_1(string? text)
    {
        return text?.Length ?? 0;
    }

    public static int s_GetStringLength_2(string? text)
    {
        if (text is null)
        {
            return 0;
        }
        return text.Length;
    }

    public static int s_GetModulus(int val1, int val2)
    {
        //0,1,2,3,4,5,6,7,8,9,10,11,12,13,...
        //modulus 3 -> Only will be numbers less than 3
        //0,1,2,0,1,2,0,1,2,0,1,2,0,1,2,0,1,2,
        //0%3 = 0
        //1%3 = 1
        //2%3 = 2
        //3%3 = 0
        //4%3 = 1
        //5%3 = 2     5/3 = 1 -> remainder (modulus) = 2
        return val1 % val2;
    }

    public static string s_ExperimentingWithNumbers()
    {
        //int, uint, long, ulong, float, double, decimal 

        // Sum of int + int
        // int variable1 = 7;
        // int variable2 = 10;
        // int sum = variable1 + variable2;
        // return $"The sum of {variable1} and {variable2} is {sum}";

        // Sum of int + double
        // int variable1 = 10;
        // double variable2 = 15.1;
        // // int sum = var1 + var2;
        // int sum = variable1 + (int) variable2;
        // return $"The sum of {variable1} and {variable2} is {sum}";

        // Sum of int + double
        // int variable1 = 10;
        // double variable2 = 15.1;
        // // int sum = var1 + var2;
        // double sum = variable1 + variable2;
        // return $"The sum of {variable1} and {variable2} is {sum}";

        // Sum of double + double 
        // double variable1 = 0.1;
        // double variable2 = 0.2;
        // double sum = variable1 + variable2;
        // return $"The sum of {variable1} and {variable2} is {sum}";

        // Check is 0.1 + 0.2 is 0.3 (the wrong way)
        // double variable1 = 0.1;
        // double variable2 = 0.2;
        // if (variable1 + variable2 == 0.3)
        // {
        //     return $"Yes, the sum of {variable1} + {variable2} is 0.3";
        // }
        // else
        // {
        //     return $"No, the sum of {variable1} + {variable2} is not 0.3";
        // }

        // Check is 0.1 + 0.2 is 0.3 (the right way)
        // double variable1 = 0.1;
        // double variable2 = 0.2;
        // if ( 0.3 - (variable1 + variable2) < 0.001)
        // {
        //     return $"Yes, the sum of {variable1} + {variable2} is 0.3";
        // }
        // else
        // {
        //     return $"No, the sum of {variable1} + {variable2} is not 0.3";
        // }

        // Check is 0.1 + 0.2 is 0.3
        // decimal variable1 = 0.1M;
        // decimal variable2 = 0.2M;
        // if (variable1 + variable2 == 0.3M)
        // {
        //     return $"Yes, the sum of {variable1} + {variable2} is 0.3";
        // }
        // else
        // {
        //     return $"No, the sum of {variable1} + {variable2} is not 0.3";
        // }

        // Math formulas
        // // s = ((a*b)/(c+d))+e
        // float s = 0;
        // float a = 10;
        // float b = 20;
        // int c = 5;
        // double d = 100;
        // float e = -1;

        // // s = ((a * b) / (c + d)) + e;
        // s = (a * b);
        // s /= (c + (float) d);
        // s += e;

        // return $"The result of the math formula is {s}";

        return "";
    }

    public static string s_ExperimentingWithString()
    {
        // Concatenate 2 strings
        // string variable1 = "Hey ";
        // string variable2 = "Teté";
        // return variable1 + variable2;

        // Concatenate 2 strings
        // string variable1 = "Hey ";
        // string variable2 = "Teté";
        // return String.Concat(variable1, variable2);

        // Concatenate 2 strings
        string variable1 = "Hey ";
        string variable2 = "Teté";
        return $"{variable1}{variable2}";
    }

    public static bool s_IsNumberInRange(int num, int min, int max, ref string error2return)
    {
        //Clear the error 
        error2return = "";

        //Check the range   
        if (min > max)
        {
            error2return = $"Error: Min ({min}) must be lower or equal than Max ({max})";
            return false;
        }

        //Check if the number is within range
        if ((num >= min) && (num <= max))
        {
            return true;
        }

        return false;
    }

    public static bool s_IsNumberInRangeWithNull_1(int num, int? min, int? max)
    {
        bool minOk = false;
        bool maxOk = false;

        //Check min
        if (min is null)
        {
            minOk = true;
        }
        else
        {
            minOk = num >= min;
        }

        //Check max
        if (max is null)
        {
            maxOk = true;
        }
        else
        {
            maxOk = num <= max;
        }

        return minOk && maxOk;
    }

    public static bool s_IsNumberInRangeWithNull_2(int num, int? min, int? max)
    {
        min ??= int.MinValue;
        max ??= int.MaxValue;

        //Check if the number is within range
        if ((num >= min) && (num <= max))
        {
            return true;
        }

        return false;
    }

    public static int s_BitwiseAnd(int num1, int num2)
    {
        return num1 & num2;
    }

    public static int s_SetBit(int num, int bitPosition)
    {
        return num | (1 << bitPosition);
    }

    public static int s_ClearBit(int num, int bitPosition)
    {
        return num & ~(1 << bitPosition);
    }

    public static byte s_ShiftToLeftByte(byte num, int positions)
    {
        return (byte)(num << positions);
    }

    public static int s_ShiftToLeftInt(int num, int positions)
    {
        return num << positions;
    }

    public static string s_ConvertIntsToStrings_UsingIf(int num)
    {
        string result = $"I don't know the name for {num}";

        if (num == 0)
        {
            result = "zero";
        }
        else if (num == 1)
        {
            result = "one";
        }
        else if (num == 2)
        {
            result = "two";
        }
        else if (num == 3)
        {
            result = "three";
        }
        else if (num == 4)
        {
            result = "four";
        }
        else if (num == 5)
        {
            result = "five";
        }
        else if (num == 6)
        {
            result = "six";
        }
        else if (num == 7)
        {
            result = "seven";
        }
        else if (num == 8)
        {
            result = "eight";
        }
        else if (num == 9)
        {
            result = "nine";
        }

        return result;
    }

    public static string s_ConvertIntsToStrings_UsingSwitch(int num)
    {
        string result = "";

        switch (num)
        {
            case 0:
                result = "zero";
                break;
            case 1:
                result = "one";
                break;
            case 2:
                result = "two";
                break;
            case 3:
                result = "three";
                break;
            case 4:
                result = "four";
                break;
            case 5:
                result = "five";
                break;
            case 6:
                result = "six";
                break;
            case 7:
                result = "seven";
                break;
            case 8:
                result = "eight";
                break;
            case 9:
                result = "nine";
                break;
            default:
                result = $"I don't know the name for {num}";
                break;
        }
        return result;
    }

    public static string s_ConvertIntsToStrings_UsingSwitchExpressions(int num)
    {
        string result = num switch
        {
            0 => "zero",
            1 => "one",
            2 => "two",
            3 => "three",
            4 => "four",
            5 => "five",
            6 => "six",
            7 => "seven",
            8 => "eight",
            9 => "nine",
            _ => $"I don't know the name for {num}"
        };
        return result;
    }

    public static string s_GetStringNumbersSeparatedByCommas_UsingWhile(int from, int to)
    {
        string result = "";
        int i = from;

        while (i <= to)
        {
            result += i;
            if (i != to)
            {
                result += ",";
            }
            i++;
        }

        return result;
    }

    public static string s_GetStringNumbersSeparatedByCommas_UsingDo(int from, int to)
    {
        string result = "";
        int i = from;

        do
        {
            result += i;
            if (i != to)
            {
                result += ",";
            }
            i++;
        } while (i <= to);

        return result;
    }

    public static string s_GetStringNumbersSeparatedByCommas_UsingFor(int from, int to)
    {
        string result = "";
        for (int i = from; i <= to; i++)
        {
            result += i;
            if (i != to)
            {
                result += ",";
            }
        }
        return result;
    }

    public static int s_GetNumberOfElementsOfArray(int[]? aNumbers)
    {
        return int.MaxValue;
    }

    public static int s_SumElementsOfArray_UsingFor(int[] aNumbers)
    {
        int result = int.MaxValue;
        return result;
    }

    public static int s_SumElementsOfArray_UsingForeach(int[] aNumbers)
    {
        int result = int.MaxValue;
        return result;
    }

    public static int s_GetMinAndMaxElementsOfArray(int[] aNumbers, out int max)
    {
        //This function returns the min value using return and the max value via the out parameter 'max'
        max = 0;
        return int.MaxValue;
    }

    public static int s_CompareArrays(int[] array1, int[] array2)
    {
        //Return values:
        //0 : both arrays are identical
        //1 : both arrays have same lenght but different elements
        //2 : array 1 has less elements than array 2
        //3 : array 1 has more elements than array 2

        return int.MaxValue;
    }

    public static string s_GetStringFromArrayOfChars(char[] arrayOfChars)
    {
        string result = "???";
        return result;
    }

    public static int s_CustomConvertStringToNumber(string input)
    {
        return int.MaxValue;
    }

    public static int s_ParseADecimalInt_UsingExceptions(string input)
    {
        return int.MaxValue;
    }

    public static int s_ParseADecimalInt_UsingTryParse(string input)
    {
        return int.MaxValue;
    }
}
