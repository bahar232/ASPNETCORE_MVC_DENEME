using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QUANTUMWEB.Models;
using System.Security.Claims;

namespace QUANTUMWEB.Controllers
{

    public class AccountController : Controller
    {
        private WebDbContext _context;
        private readonly ILogger<AccountController> _logger;

        public AccountController(WebDbContext context, ILogger<AccountController> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> LoginAsync()
        {



            return View("Login");
        }

        [HttpPost]
        //        public async Task<IActionResult> LoginAsync(Login model)
        //        {
        //            //Yeni bir Login nesnesi oluştur
        //           var userClaims = new List<Claim>()
        //{
        //            new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
        //            new Claim(ClaimTypes.Name, user.Username),
        //            new Claim(ClaimTypes.Email, user.Email),
        //            new Claim(ClaimTypes.Role,user.Type.ToString()),
        //};

        //            var grandmaIdentity = new ClaimsIdentity(userClaims, user.Type.ToString());

        //            var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });
        //            await HttpContext.SignInAsync(userPrincipal);


        //            return View("Login");
        //        }

        public IActionResult Login()
        {
            // Yeni bir Login nesnesi oluştur
            var newLogin = new Login
            {
                BayiKodu = "5432",
                BayiAdi = "Quantum app",
                KullaniciAdi = "kullanici",
                Parola = "123",

            };

            // Yeni oluşturulan Login nesnesini veritabanına ekleyin
            _context.Bayiler.Add(newLogin);

            // Veritabanındaki tüm bayileri alın
            var bayiler = _context.Bayiler.ToList();

            // Login view'ını gösterirken bayileri model olarak gönderin
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Hata işleme kodu
                Console.WriteLine(ex.Message);
            }


            return View("Login");
        }


        [HttpPost]
        public async Task<IActionResult> DoLogin([FromForm] LoginViewModel model)
        {
            if (model.Email=="bahar@gmail.com")
            {
                var identity = new ClaimsIdentity(new List<Claim> { new("Email", model.Email) }, CookieAuthenticationDefaults.AuthenticationScheme);
                var user = new ClaimsPrincipal(identity);
                HttpContext.User = user;
                await HttpContext.SignInAsync(user);

                return Redirect("/");
                //return View("Views/Home/Index.cshtml");

            }
            else
            {
                return View("Views/Account/Login.cshtml", new LoginErrorViewModel {Message="Kullanıcı adı yanlış"});
            }

            


        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login", "Account", new { });
        }
    }
}
