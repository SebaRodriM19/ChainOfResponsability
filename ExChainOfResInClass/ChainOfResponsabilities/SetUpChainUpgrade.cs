using System;
namespace ExChainOfResInClass.ChainOfResponsabilities
{
	public class SetUpChainUpgrade
	{
		private readonly StringApprover _stringApproverUpgrade;
		public SetUpChainUpgrade()
		{
			var checkEmpty = new CheckEmptyString();
			var checkTwoNumbersUpgrade = new CheckNumbers();
			var checkPositivesNumbersUpgrade = new CheckPositiveNumbers();

			checkEmpty.SetChainSuccessor(checkTwoNumbersUpgrade);
			checkTwoNumbersUpgrade.SetChainSuccessor(checkPositivesNumbersUpgrade);

			_stringApproverUpgrade = checkEmpty;
		}

		public StringApprover GetChainUpgrade() => _stringApproverUpgrade;
	}
}

