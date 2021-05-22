using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Connection
{
    class Class_Con
    {
    public static    SqlConnection Con = new SqlConnection(@"Server="+ Properties.Settings.Default.server + "; Database=" + Properties.Settings.Default.database + ";Integrated Security=true");

    }
}
