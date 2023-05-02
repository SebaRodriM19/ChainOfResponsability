using System;
namespace ExChainOfResInClass.ChainOfResponsabilities
{
	public static class OperationString
	{

        public static bool IsLegthArrayEqualsTwo(string word)
        {
            var values = GetArrayFromString(word);

            if (values.Length == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsStringEmpty(string word)
        {
            if (word != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string SumValuesFromString(string word)
        {
            var stringOfValues = string.Empty;
            var sumOfValues = 0;
            var values = GetArrayFromString(word);

            foreach (var value in values)
            {
                sumOfValues = sumOfValues + int.Parse(value);
                stringOfValues = stringOfValues + "+" + $" {value} ";
            }
            
            return $"{stringOfValues.Substring(0)} = {sumOfValues}";
        }

        public static bool AreStringsANumbers(string word)
        {
            var result = false;
            var values = GetArrayFromString(word);

            foreach (var value in values)
            {
                if (IsStringANumber(value))
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public static bool AreNumbersPositive(string word)
        {
            var result = false;

            var values = GetArrayFromString(word);

            foreach (var value in values)
            {
                if (int.Parse(value) > 0)
                {
                    result = true;

                }
                else
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        private static string[] GetArrayFromString(string word)
        {
            var res = word.Split(',');

            return res;
        }

        private static bool IsStringANumber(string word)
        {
            var result = false;
            //Case string empty
            if (word == string.Empty)
            {
                return result;
            }
            //Case string starts with character - (negative number)
            if (word[0] == '-')
            {
                for (int i = 1; i < word.Length; i++)
                {
                    //check if all charachters of string are numbers
                    if (char.IsNumber(word[i]))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }
            //Case string starts with a number
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    //check if all charachters of string are numbers
                    if (char.IsNumber(word[i]))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }
    }
}

