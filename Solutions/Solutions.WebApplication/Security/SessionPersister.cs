using Solutions.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solutions.WebApplication.Security
{
    public static class SessionPersister
    {
        const string roleCodeSessionVar = "RoleCode";
        const string userCodeSessionVar = "UserCode";

        public static int UserCode
        {
            get
            {
                if (HttpContext.Current == null)
                    return ConstantHelper.AnonymousUserRoleCode;
                else
                {
                    return (int?)HttpContext.Current.Session[userCodeSessionVar] ?? ConstantHelper.AnonymousUserRoleCode;
                }
            }
            set
            {
                HttpContext.Current.Session[userCodeSessionVar] = value;
            }
        }

        public static int RoleCode
        {
            get
            {
                if (HttpContext.Current == null)
                    return ConstantHelper.AnonymousUserRoleCode;
                else
                {
                    return (int?)HttpContext.Current.Session[roleCodeSessionVar] ?? ConstantHelper.AnonymousUserRoleCode;
                }
            }
            set
            {
                HttpContext.Current.Session[roleCodeSessionVar] = value;
            }
        }
    }
}