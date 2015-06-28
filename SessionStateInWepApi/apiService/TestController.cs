using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace SessionStateInWepApi.apiService
{
    public class TestController : ApiController
    {

        public string GetFromSession()
        {
            if ((HttpContext.Current.Session["SomeData"] as string) == null)
                HttpContext.Current.Session["SomeData"] = "Hello from session";
            return (HttpContext.Current.Session["SomeData"] as string);
        }
       
    }
}