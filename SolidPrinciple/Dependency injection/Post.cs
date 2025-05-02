using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.Dependency_injection
{
    internal class Post
    {
        public string PostTitle;
        public string PostMessage;
        public User _user;

        public Post(User user)
        {
            _user = user; 
        }
    }
}
