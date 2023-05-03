using System;
namespace ExChainOfResInClass.ChainOfResponsabilities
{
	public class CheckEmptyString : StringApprover
	{
		public CheckEmptyString()
		{
		}

        public override (bool, string) ProcessString(string numbers)
        {
            var message = string.Empty;

            if (IsStringEmpty(numbers))
            {
                message = $"Rejected by checker emmpty string.\nImpossible to sum values \"{numbers}\": input is an empty string.";
            }
            else if (_successorApprover != null)
            {
                return _successorApprover.ProcessString(numbers);
            }

            return (false, message);
        }

        private bool IsStringEmpty(string word)
        {
            if (word == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

