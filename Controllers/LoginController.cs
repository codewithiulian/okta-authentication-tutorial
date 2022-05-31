using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Blazer.Controllers
{
	public class LoginController : Controller
	{
		[HttpGet("Login")]
		public IActionResult Login([FromQuery] string returnUrl)
		{
			var redirectUri = returnUrl is null ? Url.Content("~/") : "/" + returnUrl;

			if (User.Identity.IsAuthenticated)
			{
				return LocalRedirect(redirectUri);
			}

			return Challenge();
		}

		// This is the method the Logout button should get to when clicked.
		[HttpGet("Logout")]
		public async Task<ActionResult> Logout([FromQuery] string returnUrl)
		{
			var redirectUri = returnUrl is null ? Url.Content("~/") : "/" + returnUrl;

			if (!User.Identity.IsAuthenticated)
			{
				return LocalRedirect(redirectUri);
			}

			await HttpContext.SignOutAsync();

			return LocalRedirect(redirectUri);
		}
	}
}
