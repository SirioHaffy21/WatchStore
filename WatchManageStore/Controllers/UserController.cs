using AutoMapper;
using EmailService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WatchManageStore.Data.SeedData;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;

namespace WatchManageStore.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<Account> _signInManager;
        private readonly UserManager<Account> _userManager;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;

        public UserController(IUnitOfWork unitOfWork,
                              SignInManager<WatchManageStore.Models.Account> signInManager,
                              UserManager<WatchManageStore.Models.Account> userManager,
                              IMapper mapper,
                              IEmailSender emailSender) : base(unitOfWork,mapper)
        {
            _unitOfWork = unitOfWork;
            this._signInManager = signInManager;
            this._userManager = userManager;
            this._mapper = mapper;
            this._emailSender = emailSender;
        }
        public IActionResult Login(string returnUrl = null)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AccountVM model , string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    return LocalRedirect(returnUrl);
                }

                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");

                    return View();
                }
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(AccountCreateVM model, [FromQuery(Name = "returnUrl")] string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {
                var user = _mapper.Map<Account>(model);
                user.UserName = user.Email;
                

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    await _userManager.AddToRoleAsync(user, Role.Account);

                    return LocalRedirect(returnUrl);
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }

                    return View();
                }
            }

            return View(model);
        }

        /// <summary>
        /// show email form for user to reset password
        /// </summary>
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        /// <summary>
        /// confirm that one link to reset sended to email
        /// </summary>
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        /// <summary>
        /// Send email to reset password
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordModel forgotPasswordModel)
        {
            if (!ModelState.IsValid)
                return View(forgotPasswordModel);

            var user = await _userManager.FindByEmailAsync(forgotPasswordModel.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "User not exist !");

                return View(forgotPasswordModel);
            }    
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callback = Url.Action(nameof(ResetPassword), "User", new { token, email = user.Email }, Request.Scheme);
            var message = new Message(new string[] { user.Email }, "Reset password token", callback, null);
            _emailSender.SendEmail(message);

            return RedirectToAction(nameof(ForgotPasswordConfirmation));
        }

        /// <summary>
        /// form to change password
        /// </summary>
        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            var model = new ResetPasswordModel { Token = token, Email = email };
            return View(model);
        }

        /// <summary>
        /// return to login page
        /// </summary>
        [HttpGet]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }

        /// <summary>
        /// Change password
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel resetPasswordModel)
        {
            if (!ModelState.IsValid)
                return View(resetPasswordModel);
            var user = await _userManager.FindByEmailAsync(resetPasswordModel.Email);
            if (user == null)
                RedirectToAction(nameof(ResetPasswordConfirmation));
            var resetPassResult = await _userManager.ResetPasswordAsync(user, resetPasswordModel.Token, resetPasswordModel.Password);
            if (!resetPassResult.Succeeded)
            {
                foreach (var error in resetPassResult.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return View();
            }
            return RedirectToAction(nameof(ResetPasswordConfirmation));
        }

        [HttpPost]
        public async Task<IActionResult> Logout(string returnUrl = "")
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction(nameof(Login), new {returnUrl});
        }

        [Authorize]
        [HttpGet]
        [Route("{controller}/My-Account")]
        public async Task<IActionResult> InfoDetail() {

            var user = await _userManager.GetUserAsync(HttpContext.User);

            var model = new AccountInfoVM
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> InfoUpdate(AccountInfoVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);

                if(user != null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.Email = model.Email;

                    var result = await _userManager.UpdateAsync(user);

                    if(!string.IsNullOrEmpty(model.Password))
                    {
                        var token = await _userManager.GeneratePasswordResetTokenAsync(user);

                        var resetResult = await _userManager.ResetPasswordAsync(user, token, model.Password);

                        if (result.Succeeded && resetResult.Succeeded)
                        {

                            return RedirectToAction(nameof(InfoDetail));
                        }

                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }

                        foreach (var error in resetResult.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }

                    }

                }


            }

            return View(nameof(InfoDetail), model);
        }
    }
}
