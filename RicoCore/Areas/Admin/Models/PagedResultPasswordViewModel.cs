﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RicoCore.Services.Content.Posts.Dtos;
using RicoCore.Utilities.Dtos;
using RicoCore.Services.Content.PostCategories.Dtos;
using RicoCore.Services.Systems.Passwords.Dtos;

namespace RicoCore.Areas.Admin.Models
{
    public class PagedResultPasswordViewModel : PagedResultBaseViewModel<PasswordViewModel>
    {
        public List<SelectListItem> SortTypes { get; } = new List<SelectListItem>
        {
            new SelectListItem(){Value = "theo-thu-tu",Text = "Thứ tự"},            
            new SelectListItem(){Value = "theo-ten",Text = "Tên"},
        };
    }
}
