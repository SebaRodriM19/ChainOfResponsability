using System;
namespace ExChainOfResInClass
{
	public abstract class StringApprover
	{
		protected StringApprover _successorApprover;

		public StringApprover()
		{
		}

		public void SetChainSuccessor(StringApprover stringApprover)
		{
			_successorApprover = stringApprover;
		}

		public abstract (bool,string) ProcessString(string numbers);
	}
}

