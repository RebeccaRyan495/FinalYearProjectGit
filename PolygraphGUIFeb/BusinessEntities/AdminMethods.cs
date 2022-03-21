using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class AdminMethods
    {
        private static IAdmin admin = null;

        public static IAdmin GetAdmin(string AdminID, string AdminFirstName, string AdminLastName, string UserName, string Password)
        {
            if (admin != null)  // ie is Factory is primed with an object. 
                return admin;
            else
                return new Admin(AdminID, AdminFirstName, AdminLastName, UserName, Password);
        }
        public static void SetUser(IAdmin aUser)   // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            admin = aUser;
        }
    }
}
