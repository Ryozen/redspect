﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RedSpect.Shared.Command
{
    public class ResultBuilder
    {

        private List<string> _consoleOutput = null;

        public List<string> ConsoleOutput 
        {
            get
            {
                if (_consoleOutput == null)
                {
                    _consoleOutput = new List<string>();
                }

                return _consoleOutput;
            }
        }

        public void WriteLine(string output)
        {
            ConsoleOutput.Add(output);
        }

        public ActionResult CreateResult(object value)
        {
            return new ActionResult(ConsoleOutput, value);
        }

    }
}