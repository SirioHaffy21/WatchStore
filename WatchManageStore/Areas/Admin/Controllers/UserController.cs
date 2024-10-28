using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WatchManageStore.Data.SeedData;
using WatchManageStore.Models;
using adminModel = WatchManageStore.Areas.Admin.Models;

namespace WatchManageStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class UserController : Controller
    {
        private readonly UserManager<Account> _userManager;
        private readonly IMapper _mapper;

        public UserController(UserManager<Account> userManager, IMapper mapper)
        {
            this._userManager = userManager;
            this._mapper = mapper;
        }

        // GET: UserController
        public ActionResult Index()
        {
            var users = _userManager.Users;

            var model = _mapper.Map<List<adminModel.AccountVM>>(users);  

            return View(model);
        }


        // GET: UserController/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            var model = _mapper.Map<adminModel.AccountVM>(user);

            return View(model);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(adminModel.AccountVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = await _userManager.FindByIdAsync(model.Id);

                    var result = await _userManager.UpdateAsync(_mapper.Map<adminModel.AccountVM, Account>(model, user));

                    if(result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);

                    }

                    return View();

                }
                else
                {
                    return View(model);
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                return View();
            }
        }


        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(id);

                if(await _userManager.IsInRoleAsync(user, Role.Administrator))
                {
                    ModelState.AddModelError("", "Cannot remove this user");

                    return RedirectToAction(nameof(Index));
                }

                await _userManager.DeleteAsync(user);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
