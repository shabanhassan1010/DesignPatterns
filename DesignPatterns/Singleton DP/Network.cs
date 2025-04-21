using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton_DP
{
    public class Network
    {
        // Now i have ref from Network and he refer to null
        public static Network network;   
        private Network()  
        {
            // Private Constructor
        }
        public static Network GetNetwork()
        {
            if(network == null)  
            {
                network = new Network(); // i will create Obj
            }
            return network;  // the object already created and i will reuse it
        }
    }
}
