using System;
namespace ExChainOfResInClass.ChainOfResponsabilities
{
	public class CheckPositiveNumbers : StringApprover
	{
		public CheckPositiveNumbers()
		{
		}

        public override (bool, string) ProcessString(string numbers)
        {
            _wordsToManipulate = OperationString.GetArrayFromString(numbers);

            if (!AreNumbersPositive(_wordsToManipulate))
            {
                return (false, $"Rejected by checker numbers positives.\nImpossible to sum values \"{numbers}\": one those (or more) numbers are negative.");
            }
            else
            {
                return (true, $"String was validate. Sum of {numbers} is : {OperationString.SumValuesFromString(_wordsToManipulate)}");
            }
        }

        private bool AreNumbersPositive(string[] words)
        {
            var result = false;

            foreach (var value in words)
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
    }
}

