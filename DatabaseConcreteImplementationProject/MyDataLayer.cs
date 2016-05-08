using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConcreteImplementationProject
{
    public class MyDataLayer
    {
        public virtual List<User> GetUsers()
        {
            return new List<User>() {
                new User() { UserName = "John Doe", UserEmailAddress = "john@doe.com" },
                new User() { UserName = "Jane Doe", UserEmailAddress = "jane@doe.com" },
            };
        }
    }

    public class User
    {
        public string UserName { get; set; }
        public string UserEmailAddress { get; set; }
    }
}
