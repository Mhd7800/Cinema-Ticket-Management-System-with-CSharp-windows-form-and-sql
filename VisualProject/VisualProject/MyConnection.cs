using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace VisualProject
{
    class MyConnection
    {
        public SqlConnection con;
        public MyConnection()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["CC"].ConnectionString);

        }

        public static string type;
        
    }
}
