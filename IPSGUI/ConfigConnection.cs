using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace IPSGUI
{
    public class ConfigConnection
    {
       public static string connectionString = 
       ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }
}

