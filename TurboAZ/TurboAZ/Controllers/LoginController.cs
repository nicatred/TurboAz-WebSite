using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TurboAZ.Entity.IdentityModel;
using TurboAZ.Repository;
using TurboAZ.Repository.Identity;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace TurboAZ.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
           _signInManager = signInManager;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserLogin()
        {
            LoginUserModel loginUserModel = new LoginUserModel();
            return View(loginUserModel);
        }
        public IActionResult AdminLogin()
        {
            AdminLoginModelView model = new AdminLoginModelView();
            return View(model);
        }
        [HttpPost]
        public IActionResult AdminAuth(AdminLoginModelView model)
        {
            if (ModelState.IsValid)
            {
                var signResult = _signInManager.PasswordSignInAsync(model.Email, model.Password, model.Remember, false).Result;
                if (signResult.Succeeded)
                {
                    return RedirectToAction("Index", "Ads", new { area = "Admin" });
                }
                ModelState.AddModelError("","İstifadəçi adı və ya şifrə yalnışdır");
            }
            

           return  View("AdminLogin",model);
        }
        [HttpPost]
        
        public async Task<IActionResult> UserRegister(LoginUserModel loginUserModel)
        {
            string ShortNumber = loginUserModel.PhoneNumber;
            for (int i = 0; i < ShortNumber.Length; i++)
            {
                if (ShortNumber[i] == '-' || ShortNumber[i] == ')'|| ShortNumber[i] == '('|| ShortNumber[i] == ' ')
                {
                    ShortNumber = ShortNumber.Remove(i, 1);
                }
            }
            Random random = new Random();
            int rand = random.Next();
                AppUser appUser = new AppUser()
                {
                    PhoneNumber = loginUserModel.PhoneNumber,
                    UserName= rand.ToString()      
                };
               
            var identityResult= await _userManager.CreateAsync(appUser);
            if (identityResult.Succeeded)
            {

              var result = _signInManager.PasswordSignInAsync(appUser, "", true, false).Result;
                var claims = new List<Claim>
                  {
                      new Claim(ClaimTypes.Name,rand.ToString())
                  };
                var indentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(indentity);
                var props = new AuthenticationProperties();
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props).Wait();

                return RedirectToAction("Index", "{User}/Home");
            }
            return View("UserLogin", loginUserModel);
            
            }
   

            
        [HttpGet]
        public IActionResult NewUser(LoginUserModel loginUserModel)
        {
            return View();
        }


    }
}
