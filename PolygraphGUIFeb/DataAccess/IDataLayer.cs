﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace DataAccess
{
    public interface IDataLayer
    {
        void closeConnection();
        System.Data.SqlClient.SqlConnection getConnection();
        void openConnection();

        List<IAdmin> getAllAdmin();
    }
}