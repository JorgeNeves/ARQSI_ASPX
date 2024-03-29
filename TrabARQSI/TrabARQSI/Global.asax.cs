﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;


namespace EnviarMAILS
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            if (ex.Message != "File does not exist.")
            {
                EnviarMAILS.Email.enviarEmail("1110603@isep.ipp.pt", "Erro na aplicação", ex.ToString());
                EnviarMAILS.Email.enviarEmail("1110297@isep.ipp.pt", "Erro na aplicação", ex.ToString());
                Response.Redirect("paginaErro.aspx");
            }
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}