﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartBreadcrumbs.Attributes;
using yogaAshram.Models;
using yogaAshram.Models.ModelViews;
using yogaAshram.Services;

namespace yogaAshram.Controllers
{
    [Authorize(Roles = "manager")]
    public class ManagerController : Controller
    {
        private readonly UserManager<Employee> _userManager;
        private readonly SignInManager<Employee> _signInManager;
        private YogaAshramContext _db;
        private readonly RoleManager<Role> _roleManager;

        public ManagerController(
            UserManager<Employee> userManager,
            SignInManager<Employee> signInManager,
            YogaAshramContext db, 
            RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
            _roleManager = roleManager;
        }
        
        [Authorize]
        [Breadcrumb("Личный кабинет менеджера")]
        // GET
        public async Task<IActionResult> Index()
        {
            Employee empl = await _userManager.GetUserAsync(User);
            return View(new ManagerIndexModelView() { Employee = empl });
        }
       
    }
}