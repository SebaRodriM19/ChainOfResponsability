using System;
namespace ExChainOfResInClass.ChainOfResponsabilities
{
	public class CheckTwoNumbers : StringApprover
	{
		public CheckTwoNumbers()
		{
		}

        public override (bool, string) ProcessString(string numbers)
        {

            if (!OperationString.CheckNumbersInString(numbers))
            {
                Console.WriteLine("Rejected by checker two numbers.");
            }
            else if (_successorApprover != null)
            {
                Console.WriteLine("Approved by check two numbers to a top level.");
                return _successorApprover.ProcessString(numbers);
            }

            return (false, $"Impossible to sum values \"{numbers}\": one of those (or more) characters are not a number.");

        }
    }
}

