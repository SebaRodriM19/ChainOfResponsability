using System;
namespace ExChainOfResInClass.ChainOfResponsabilities
{
	public static class OperationString
    { 
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

            return $"{stringOfValues.Substring(1)} = {sumOfValues}";
        }

        public static string[] GetArrayFromString(string word)
        {
            var res = word.Split(',');

            return res;
        }
    }
}

