using Solutions.BusinessLogic;
using Solutions.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Solutions.WebApplication.Security
{
    public class AuthorizationAttribute : AuthorizeAttribute
    {
        UserRoleType[] RoleTypes { get; set; }

        int[] RoleCodes { get; set; }

        /// <summary>
        /// The controller to redirect if authorization does not succeed.
        /// </summary>
        string Result { get; set; }

        public AuthorizationAttribute(UserRoleType[] roleTypes, string result = "")
        {
            RoleCodes = roleTypes.Select(x => (int) x).ToArray();
            Result = result;
        }

        public AuthorizationAttribute(UserRoleType roleType, string result = "")
        {
            RoleCodes = new int[] { (int)roleType };
            Result = result;
        }

        public AuthorizationAttribute(int roleCode, string result = "")
        {
            RoleCodes = new int[] { roleCode };
            Result = result;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (!IsInRole(RoleCodes, SessionPersister.RoleCode))
            {
                if (string.IsNullOrEmpty(Result))
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary
                            (new { controller = "AccessDenied", action = "Index" }));
                }
                else
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary
                            (new { controller = Result, action = "Index" }));
                }
            }
        }

        public bool IsInRole(int[] roleCodes, int roleCodeToCheck)
        {
            if (roleCodes.Contains(roleCodeToCheck))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}