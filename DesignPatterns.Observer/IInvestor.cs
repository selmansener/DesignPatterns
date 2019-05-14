using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
