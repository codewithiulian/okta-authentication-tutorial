using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Blazer.Shared
{
	public partial class RedirectToLogin
	{
		[Inject] public NavigationManager Navigation { get; set; }

		protected override async Task OnInitializedAsync()
		{
			var returnUrl = Navigation.ToBaseRelativePath(Navigation.Uri);

			Navigation.NavigateTo($"Login?returnUrl={returnUrl}", true);
		}
	}
}
