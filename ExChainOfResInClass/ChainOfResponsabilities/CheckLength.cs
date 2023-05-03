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
            _wordsToManipulate = OperationString.GetArrayFromString(numbers);
            var message = string.Empty;

            if (!IsLegthArrayEqualsTwo(_wordsToManipulate))
			{
				message = $"Rejected by checker legth.Impossible to sum values \"{numbers}\": length of array is not 2.";
			}
			else if(_successorApprover != null)
			{
				return _successorApprover.ProcessString(numbers);
			}

			return (false, message);
		}

        private bool IsLegthArrayEqualsTwo(string[] words)
        {
            if (words.Length == 2)
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

