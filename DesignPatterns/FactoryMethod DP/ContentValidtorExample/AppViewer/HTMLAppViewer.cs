﻿using DesignPatterns.FactoryMethod_DP.ContentValidtorExample.Interpreters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod_DP.ContentValidtorExample.AppViewer
{
    public class HTMLAppViewer : AppViewer
    {
        public override Interpreter CreateInterpreter()
        {
            return new HTMLInterpreter("<DOCTYPE html>");
        }
    }
}
