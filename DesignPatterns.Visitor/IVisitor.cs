using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public interface IVisitor
    {
        void Visit(Element element);
    }
}
