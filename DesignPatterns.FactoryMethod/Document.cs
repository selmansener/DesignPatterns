using DesignPatterns.FactoryMethod.Pages.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public abstract class Document
    {
        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages { get; } = new List<Page>();

        public abstract void CreatePages();
    }
}
