using System;
namespace ExChainOfResInClass.ChainOfResponsabilities
{
	public class SetUpChainUpgrade
	{
		private readonly StringApprover _stringApproverUpgrade;
		public SetUpChainUpgrade()
		{
			var checkEmpty = new CheckEmptyString();
			var checkTwoNumbersUpgrade = new CheckTwoNumbers();
			var checkPositivesNumbersUpgrade = new CheckTwoPositiveNumbers();

			checkEmpty.SetChainSuccessor(checkTwoNumbersUpgrade);
			checkTwoNumbersUpgrade.SetChainSuccessor(checkPositivesNumbersUpgrade);

			_stringApproverUpgrade = checkEmpty;
		}

		public StringApprover GetChainUpgrade() => _stringApproverUpgrade;
	}
}

