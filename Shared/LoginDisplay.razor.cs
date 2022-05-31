using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Blazer.Shared
{
	public partial class LoginDisplay
	{
		[Inject] public NavigationManager Navigation { get; set; }
		[Parameter] public string ReturnUrl { get; set; }

		protected override async Task OnInitializedAsync()
		{
			ReturnUrl = Navigation.ToBaseRelativePath(Navigation.Uri);
		}
	}
}
