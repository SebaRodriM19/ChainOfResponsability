using System;
namespace ExChainOfResInClass.ChainOfResponsabilities
{
	public static class OperationString
    { 
        public static string SumValuesFromString(string[] numbers)
        {
            var stringOfValues = string.Empty;
            var sumOfValues = 0;

            foreach (var number in numbers)
            {
                sumOfValues = sumOfValues + int.Parse(number);
                stringOfValues = stringOfValues + "+" + $" {number} ";
            }

            return $"{stringOfValues.Substring(1)}= {sumOfValues}";
        }

        public static string[] GetArrayFromString(string word)
        {
            var res = word.Split(',');

            return res;
        }
    }
}

