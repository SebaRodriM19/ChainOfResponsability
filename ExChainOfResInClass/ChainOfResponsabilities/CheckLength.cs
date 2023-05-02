using System;
namespace ExChainOfResInClass.ChainOfResponsabilities
{
	public class CheckLength : StringApprover
	{
		public CheckLength()
		{
		}

        public override (bool,string) ProcessString(string numbers)
        {
			if (!OperationString.LengthArray(numbers))
			{
				Console.WriteLine("Rejected by checker legth.");
			}
			else if(_successorApprover != null)
			{
				Console.WriteLine("Approved by length checker to a top level.");
				return _successorApprover.ProcessString(numbers);
			}

			return (false, $"Impossible to sum values \"{numbers}\": length of array is not 2.");
        }
    }
}

