﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGTI_Calender.Controllers {
    public class TeamsController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
