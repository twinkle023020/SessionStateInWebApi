using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SessionStateInWepApi.Helper
{
    public class SessionManager
    {
        public static string CurrentUser
        {
            get
            {
                if (HttpContext.Current.Session.Contents["SomeData"] == null)
                    return null;
                else return HttpContext.Current.Session.Contents["SomeData"].ToString();
            }
            set
            {
                HttpContext.Current.Session.Contents["SomeData"] = value;
            }
        }
    }
}