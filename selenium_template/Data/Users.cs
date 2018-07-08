using selenium_template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_template.Data
{

    public class Users
    {
        public static User RealUser => new User("user@phptravels.com", "demouser");
        public static User FakeUser => new User("user@phptravels.com", "demouser2");
    }


}
