using DentistBookingSystem.DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.Components.Authorize
{
    public class MyAuthorizeAttribute : AuthorizeAttribute
    {
        private UserRoles roleEnum;
        public UserRoles RoleEnum
        {
            get { return roleEnum; }
            set { roleEnum = value; base.Roles = value.ToString(); }
        }
    }
}
