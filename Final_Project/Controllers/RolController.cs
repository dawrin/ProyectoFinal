using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class RolController : Controller
    {

        private readonly RoleManager<IdentityRole> roleManager;

        public RolController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        public IActionResult Agregar()
        {

            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Agregar(Roles role)
        {
            var roleExist = await roleManager.RoleExistsAsync(role.Rol);
            if (!roleExist)
            {
                var result = await roleManager.CreateAsync(new IdentityRole(role.Rol));
            }
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
