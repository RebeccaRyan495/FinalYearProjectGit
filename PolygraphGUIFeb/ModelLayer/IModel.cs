using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace ModelLayer
{
    public interface IModel
    {
        DataAccess.IDataLayer DataLayer { get; set; }

        List<IAdmin> AdminList { get; set; }
        void GetAllAdmin();
    }
}
