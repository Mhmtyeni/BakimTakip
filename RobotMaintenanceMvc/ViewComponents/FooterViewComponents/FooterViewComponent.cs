﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotMaintenanceMvc.ViewComponents.FooterViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("_footer");
        }
    }
}
