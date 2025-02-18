using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Narrateo.Data;
using Narrateo.Models;

namespace Narrateo.Controllers
{
    public class Account : Controller
    {
        private readonly AppDbContext _context;

        public Account(AppDbContext context)
        {
            _context = context;
        }
        [Route("Account/LoginView")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("Account/RegisterView")]
        public IActionResult Register()
        {
            return View();
        }

        private Guid GetAdminID()
        {
            var adminRole = _context.Roles.FirstOrDefault(r => r.Description == "Admin");
            if (adminRole == null)
            {
                var role = new Roles
                {
                    Id = Guid.NewGuid(),
                    Description = "Admin"
                };
                _context.Roles.Add(role);
                _context.SaveChanges();
                return role.Id;
            }
            return adminRole.Id;
        }

        private Guid GetDefaultRole()
        {
            var defaultRole = _context.Roles.FirstOrDefault(r => r.Description == "Roles");
            if(defaultRole == null)
            {
                var role = new Roles
                {
                    Id = Guid.NewGuid(),
                    Description = "User"
                };
                _context.Roles.Add(role);
                _context.SaveChanges();
                return role.Id;
            }
            return defaultRole.Id;
        }

        public async Task<IActionResult> SaveRegister(Register register)
        {
            if(ModelState.IsValid)
            {
                var isFirstUser = !_context.Users.Any(); //if there is user returns false, if there are not returns true.
                var roleId = isFirstUser ? GetAdminID() : GetDefaultRole();

                var user = new Users
                {
                    Id = Guid.NewGuid(),
                    FullName = register.FullName,
                    Username = register.Username,
                    Email = register.EmailAddress,
                    HashedPassword = HashPassword(register.Password!),
                    RoleId = roleId
                };

                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return RedirectToAction("Login", "Account");
            }

            return View("Register", register);
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
