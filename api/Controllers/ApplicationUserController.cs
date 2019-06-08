using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using wepApiAuth.Models;

namespace wepApiAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
       
       private UserManager<ApplicationUser> _userManger;
       private SignInManager<ApplicationUser> _siginManger;

       public ApplicationUserController(UserManager<ApplicationUser> UserManager, 
                        SignInManager<ApplicationUser> SignInManager )
       {
           _siginManger = SignInManager;
           _userManger = UserManager;
       }
       

       [HttpPost]
       [Route("Regester")]
       public async Task<Object> POstApllicationUser(ApplicationUserModel model){
            var applicationUser = new ApplicationUser() {
                 Email = model.Email,
                 FullName = model.FullName,
                 UserName = model.UserName,
            };
            try
            {
                var result = await _userManger.CreateAsync(applicationUser, model.Password);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }

       }
    }
}
