using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IQuestion
    {
        string QuestionID { get; set; }
        string AQuestion { get; set; }
    }
}
