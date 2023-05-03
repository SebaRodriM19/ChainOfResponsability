using System;
namespace ExChainOfResInClass.ChainOfResponsabilities
{
	public class CheckNumbers : StringApprover
	{
		public CheckNumbers()
		{
		}

        public override (bool, string) ProcessString(string numbers)
        {
            _wordsToManipulate = OperationString.GetArrayFromString(numbers);
            var message = string.Empty;

            if (!AreStringsANumbers(_wordsToManipulate))
            {
                message = $"Rejected by checker numbers.\nImpossible to sum values \"{numbers}\": one of those (or more) characters are not a number.";
            }
            else if (_successorApprover != null)
            {
                return _successorApprover.ProcessString(numbers);
            }

            return(false, message);
        }

        private bool AreStringsANumbers(string[] words)
        {
            var result = false;

            foreach (var value in words)
            {
                if (IsStringANumber(value))
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

        private bool IsStringANumber(string word)
        {
            var result = false;

            if (word == string.Empty)
            {
                return false;
            }
            //Case string starts with character - (negative number)
            if (word[0] == '-')
            {
                for (int i = 1; i < word.Length; i++)
                {
                    //check if all charachters of string are numbers
                    if (char.IsNumber(word[i]))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }
            //Case string starts with a number
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    //check if all charachters of string are numbers
                    if (char.IsNumber(word[i]))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }
    }
}

