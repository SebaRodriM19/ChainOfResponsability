using System;
namespace ExChainOfResInClass.ChainOfResponsabilities
{
	public class SetUpChain
	{
		private readonly StringApprover _chainApprover;

		public SetUpChain()
		{
			var checkLenght = new CheckLength();
			var checkTwoNumbers = new CheckNumbers();
			var checkTwoPositiveNumbers = new CheckPositiveNumbers();

			checkLenght.SetChainSuccessor(checkTwoNumbers);
			checkTwoNumbers.SetChainSuccessor(checkTwoPositiveNumbers);
			_chainApprover = checkLenght;
		}

		public StringApprover GetChain() => _chainApprover;
	}
}

