﻿using Microsoft.AspNetCore.Mvc;
using RicoCore.Services.Content.Posts;
using RicoCore.Services.Systems.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RicoCore.Controllers.Components
{
    public class BannerAdBlockViewComponent : ViewComponent
    {
       

        public BannerAdBlockViewComponent()
        {           
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {            
            return View();
        }
    }
}
