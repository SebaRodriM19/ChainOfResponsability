using System;
namespace ExChainOfResInClass.ChainOfResponsabilities
{
	public class CheckTwoPositiveNumbers : StringApprover
	{
		public CheckTwoPositiveNumbers()
		{
		}

        public override (bool, string) ProcessString(string numbers)
        {

            if (!OperationString.CheckPositiveNumbers(numbers))
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
    }
}

