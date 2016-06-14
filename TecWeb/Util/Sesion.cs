using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecWeb.Util
{
    public class Sesion
    {
        static public long UserID { get; set; }
        static public string UserName { get; set; }

        static public void Logout()
        {
            UserID = -1;
            UserName = "Unknown";
        }

        static public bool Authenticated()
        {
            return UserID != -1;
        }
    }
}