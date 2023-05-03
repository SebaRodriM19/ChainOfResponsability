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
            CreateNumbersToCheck(numbers);

            if (!AreNumbersPositive(_wordsToManipulate))
            {
                Console.WriteLine("Rejected by checker two numbers positives.");
                return (false, $"Impossible to sum values \"{numbers}\": one those (or more) numbers are negative.");
            }
            else
            {
                Console.WriteLine("Approved by Check two numbers to a top level.");
                return (true, $"Sum of {numbers} is : {OperationString.SumValuesFromString(numbers)}");
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

