﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethod
{
    public abstract class DataAccessObject
    {
        protected string connectionString;

        public virtual void Connect()
        {
            // Make sure mdb is available to app

            connectionString = "cs";
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            connectionString = "";
        }

        // The 'Template Method' 

        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}
