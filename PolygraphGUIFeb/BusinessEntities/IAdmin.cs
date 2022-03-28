using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IAdmin
    {

        string AdminID { get; set; }
        string AdminFirstName { get; set; }
        string AdminLastName { get; set; }
        string UserName { get; set; }
        string Password { get; set; }

    }
}
