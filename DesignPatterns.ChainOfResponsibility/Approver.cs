using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class Approver
    {
        protected Approver successor;

        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
