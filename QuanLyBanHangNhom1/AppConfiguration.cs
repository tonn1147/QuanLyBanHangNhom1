using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLyBanHangNhom1
{
    internal static class AppConfiguration
    {
        //public static string ConnectionString { get; } = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public static string ConnectionString { get; } = Environment.GetEnvironmentVariable("ConnectionStringForQuanLyBanHangNhom1");
    }
}
