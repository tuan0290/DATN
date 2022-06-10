using Entities.DTOs;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Services.Common;
using System;
using System.Linq;

namespace Web.Controllers
{
    public class AccountController : WebBaseController
    {
        private ICommonService commonService;
        public AccountController(ICommonService commonService)
        {
            this.commonService = commonService;
        }
        [Route("tai-khoan")]
        [HttpGet]
        public IActionResult Index()
        {
            var member = GetMemberData();
            if (member != null)
            {
                GetDataMenu();
                return View(member);
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }

        [Route("tai-khoan")]
        [HttpPost]
        public IActionResult Index(Accounts account)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Error"] = "Cần nhập đầy đủ các trường dữ liệu bắt buộc!";
                return View(account);
            }
            account.ModifiedBy = GetMemberData().Username;
            account.ModifiedDate = DateTime.Now;
            var check = commonService.InsertOrUpdateAccount(account);
            if (check)
            {
                ViewData["Success"] = "Cập nhật thông tin tài khoản thành công!";
                SetMemberData(account);
                return View(account);
            }
            else
            {
                ViewData["Error"] = "Có lỗi trong quá trình cập nhật tài khoản!";
                return View(account);
            }
        }

        [Route("doi-mat-khau")]
        [HttpGet]
        public IActionResult ChangePass()
        {
            var member = GetMemberData();
            if (member != null)
            {
                GetDataMenu();
                var data = new AccountChangePassDTO();
                data.id = member.Id;
                data.username = member.Password;
                return View(data);
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }

        [Route("doi-mat-khau")]
        [HttpPost]
        public IActionResult ChangePass(AccountChangePassDTO account)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Error"] = "Cần nhập đầy đủ các trường dữ liệu bắt buộc!";
                return View(account);
            }
            if (account.password != account.repassword)
            {
                ViewData["Error"] = "2 mật khẩu không trùng nhau!";
                return View(account);
            }
            var member = GetMemberData();
            member.ModifiedBy = member.Username;
            member.ModifiedDate = DateTime.Now;
            member.Password = account.password;
            var check = commonService.InsertOrUpdateAccount(member);
            if (check)
            {
                ViewData["Success"] = "Cập nhật thông tin tài khoản thành công!";
                SetMemberData(member);
                return View(account);
            }
            else
            {
                ViewData["Error"] = "Có lỗi trong quá trình cập nhật tài khoản!";
                return View(account);
            }
        }

        [Route("quen-mat-khau")]
        [HttpGet]
        public IActionResult Forget()
        {
            GetDataMenu();
            var member = GetMemberData();
            if (member == null)
            {
                return View(member);
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }
        [Route("quen-mat-khau")]
        [HttpPost]
        public IActionResult Forget(ForgetDTO forget)
        {
            var member = GetMemberData();
            if (member == null)
            {
                return View(member);
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }

        [HttpGet]
        [Route("dang-nhap")]
        public IActionResult Login()
        {
            GetDataMenu();
            var member = GetMemberData();
            if (member == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        [Route("dang-nhap")]
        [ValidateAntiForgeryToken]
        public IActionResult Login(AccountLoginDTO member)
        {
            var check = commonService.AccountLogin(member);
            if (check != null)
            {
                SetMemberData(check);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData["Error"] = "Tên đăng nhập hoặc mật khẩu không chính xác!";
                return View(member);
            }
        }
        [HttpGet]
        [Route("dang-xuat")]
        public IActionResult Logout()
        {
            ClearMemberData();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [Route("dang-ky")]
        public IActionResult Register()
        {
            GetDataMenu();
            var member = GetMemberData();
            if (member == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        [Route("dang-ky")]
        [ValidateAntiForgeryToken]
        public IActionResult Register(AccountRegisterDTO register)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Error"] = "Cần nhập đầy đủ các trường dữ liệu bắt buộc!";
                return View(register);
            }
            if (register.Password != register.RePassword)
            {
                ViewData["Error"] = "2 mật khẩu không trùng nhau!";
                return View(register);
            }
            var newAccount = new Accounts();
            newAccount.Username = register.Username;
            newAccount.Password = register.Password;
            newAccount.Phone = register.Phone;
            newAccount.Email = register.Email;
            newAccount.CreateBy = register.Username;
            newAccount.CreateDate = DateTime.Now;
            newAccount.IsActive = true;
            var check = commonService.InsertOrUpdateAccount(newAccount);
            if (check)
            {
                var account = commonService.AccountLogin(new AccountLoginDTO { username = register.Username, password = register.Password });
                SetMemberData(account);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData["Error"] = "Có lỗi trong quá trình đăng ký!";
                return View(register);
            }
        }

        #region private Func
        private Accounts GetMemberData()
        {
            var member = HttpContext.Session.GetString("member");
            var data = member != null ? JsonConvert.DeserializeObject<Accounts>(member) : null;
            return data;
        }
        private void SetMemberData(Accounts member)
        {
            string jsonData = JsonConvert.SerializeObject(member);
            HttpContext.Session.SetString("member", jsonData);
        }
        private void ClearMemberData()
        {
            var session = HttpContext.Session;
            session.Remove("member");
        }
        private void GetDataMenu()
        {
            TempData["productmenu"] = commonService.GetListProductCategory().OrderBy(x => x.CategoryOrder).ToList();
            TempData["newsmenu"] = commonService.GetListCategoryNews().OrderBy(x => x.CategoryOrder).ToList();
        }
        #endregion
    }
}
