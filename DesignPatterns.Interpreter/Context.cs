﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interpreter
{
    public class Context
    {
        private string _input;
        private int _output;

        // Constructor

        public Context(string input)
        {
            this._input = input;
        }

        // Gets or sets input

        public string Input
        {
            get { return _input; }
            set { _input = value; }
        }

        // Gets or sets output

        public int Output
        {
            get { return _output; }
            set { _output = value; }
        }
    }
}