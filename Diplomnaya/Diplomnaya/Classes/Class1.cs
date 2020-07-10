using System.Configuration;

namespace Diplomnaya
{
    class Class1
    {
        public static string login;
        public static string stateuser;
        readonly public static string connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
    }
}
