using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminLTE.Domain.Service;
using AdminLTE.Models.VModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdminLTE.Net.Web.Pages.Account
{
    [Authorize(AuthenticationSchemes = CookieService.AuthenticationScheme)]
    public class UserListModel : BasePageModel
    {
        public UserListModel(UserService service)
        {
            userService = service;
        }
        public void OnGet()
        {
        }

        protected UserService userService { get; set; }

        public List<VUserListModel> UserList { get; set; }


    }
}