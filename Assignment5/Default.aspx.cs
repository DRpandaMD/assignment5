﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MemberRegisterButtonClick(object sender, EventArgs e)
        {
            Response.Redirect("Member/MemberRegister");
        }

        protected void MemberLoginButtonClick(object sender, EventArgs e)
        {
            Response.Redirect("Member/MemberLogin");
        }
    }
}