using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecWeb.Util
{
    //Clase de utilidad para emular una sesion de usuario
    public class Sesion
    {
        static private long userID = -1;
        static public long UserID { get { return userID; } set { userID = value; } }
        static public string UserName { get; set; }

        static public void Logout()
        {
            userID = -1;
            UserName = "Unknown";
        }

        static public bool Authenticated()
        {
            return userID != -1;
        }
    }
}