using System;
namespace ExChainOfResInClass.ChainOfResponsabilities
{
	public static class OperationString
	{

        public static bool LengthArray(string word)
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

        public static string SumValuesFromString(string word)
        {
            var values = GetArrayFromString(word);
            var num1 = int.Parse(values[0]);
            var num2= int.Parse(values[1]);

            return $"{num1} + {num2} = {num1 + num2}";
        }

        public static bool CheckNumbersInString(string word)
        {
            var values = GetArrayFromString(word);
            var number1 = CheckNumberInString(values[0]);
            var number2 = CheckNumberInString(values[1]);

            if (number1 && number2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckPositiveNumbers(string word)
        {
            var values = GetArrayFromString(word);

            var num1 = CheckNumberInString(values[0]) ? int.Parse(values[0]) : 0;
            var num2 = CheckNumberInString(values[1]) ? int.Parse(values[1]) : 0;

            if (num1 > 0 && num2 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string[] GetArrayFromString(string word)
        {
            var res = word.Split(',');

            return res;
        }

        private static bool CheckNumberInString(string word)
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

