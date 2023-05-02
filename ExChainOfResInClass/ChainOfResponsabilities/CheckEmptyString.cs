﻿using System;
namespace ExChainOfResInClass.ChainOfResponsabilities
{
	public class CheckEmptyString : StringApprover
	{
		public CheckEmptyString()
		{
		}

        public override (bool, string) ProcessString(string numbers)
        {
            if (!OperationString.IsStringEmpty(numbers))
            {
                Console.WriteLine("Rejected by checker emmpty string.");
            }
            else if (_successorApprover != null)
            {
                Console.WriteLine("Approved by checker empty string to a top level.");
                return _successorApprover.ProcessString(numbers);
            }

            return (false, $"Impossible to sum values \"{numbers}\": input is an empty string.");
        }
    }
}
