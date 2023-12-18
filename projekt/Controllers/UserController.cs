using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

public class UserController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;

    public UserController(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    [HttpGet]
    public IActionResult Dodaj()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Dodaj(string username, string email, string password)
    {
        var user = new IdentityUser { UserName = username, Email = email };
        var result = await _userManager.CreateAsync(user, password);

        if (result.Succeeded)
        {
            return RedirectToAction("Index", "Home"); // Przekierowanie na główną stronę lub gdziekolwiek indziej
        }
        else
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View();
        }
    }
}
