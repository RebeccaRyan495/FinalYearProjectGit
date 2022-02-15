using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public interface IDataLayer
    {
        void closeConnection();
        System.Data.SqlClient.SqlConnection getConnection();
        void openConnection();
    }
}
