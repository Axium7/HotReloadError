using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HotReloadError.Components.Pages;

public partial class DlgMudCheckBoxError
{
	[CascadingParameter]
	private IMudDialogInstance MudDialog { get; set; }

	private bool blnError;

	private async Task SaveRecord()
	{
		
	}
}