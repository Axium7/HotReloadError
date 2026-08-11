using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HotReloadError.Components.Pages;

public partial class DlgMudCheckBox
{
	[CascadingParameter]
	private IMudDialogInstance MudDialog { get; set; }

	private MudTextField<string> refComment;
	private bool blnError;
	private string strABC;

	private async Task SaveRecord()
	{
		
	}

	protected override async Task OnAfterRenderAsync(bool firstRender)
	{
		if (firstRender)
		{
			// Dialog content may not be focusable on the very first render due to portal + animation timing.
			await Task.Delay(250);

			if (refComment is not null)
			{
				await refComment.FocusAsync();
			}
		}
	}
}