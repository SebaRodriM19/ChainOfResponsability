using System;
using ExChainOfResInClass.ChainOfResponsabilities;

namespace ExChainOfResInClass
{
	public abstract class StringApprover
	{
		protected StringApprover _successorApprover;
		protected string[] _wordsToManipulate;

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