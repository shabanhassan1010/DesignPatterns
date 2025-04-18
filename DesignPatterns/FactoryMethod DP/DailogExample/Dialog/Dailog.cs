using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.FactoryMethod_DP.Buttons;

namespace DesignPatterns.FactoryMethod_DP.Dialog
{
    public abstract class Dialog  // Abstract Class
    {
        public abstract Button CreatedButton();  // Factory Method 
        public string RenderDialog()
        {
            Button button = this.CreatedButton();
            return $@" {button.Show()}  ";
        }
    }
}