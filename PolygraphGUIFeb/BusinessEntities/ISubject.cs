using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface ISubject
    {
        string SubjectID { get; set; }
        string SubjectFirstName { get; set; }
        string SubjectLastName { get; set; }
        int Incarceration { get; set; }
        int PreviousTests { get; set; }
        string SubjectAddress { get; set; }
        string CustodianName { get; set; }

    }
}
