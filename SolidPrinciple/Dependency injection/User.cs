using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.Dependency_injection
{
    internal class User
    {
        public string userName;
        public int userAge;
        public User(string userName, int userAge)
        {
            this.userName = userName;
            this.userAge = userAge;
        }
    }
}
