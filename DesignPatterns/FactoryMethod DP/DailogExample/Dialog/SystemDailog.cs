﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.FactoryMethod_DP.Buttons;

namespace DesignPatterns.FactoryMethod_DP.Dialog
{
    public class SystemDailog : Dialog
    {
        public override Button CreatedButton()
        {
            return new SystemButton();
        }
    }
}
