using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebSocket_Asp.net
{
    public class Global : System.Web.HttpApplication
    {
        private WebSocketManager webSocketManager = new WebSocketManager();

        protected void Application_Start(object sender, EventArgs e)
        {
            webSocketManager.Init();
        }

     
        protected void Application_End(object sender, EventArgs e)
        {
            webSocketManager.Close();
        }
    }
}