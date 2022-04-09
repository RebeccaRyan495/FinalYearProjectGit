using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface ITest
    {
        string TestID { get; set; }
        string TestDuration { get; set; }
        int Criminal { get; set; }
    }
}
