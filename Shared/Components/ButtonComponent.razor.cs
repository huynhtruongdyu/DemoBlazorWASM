using DemoBlazorWASM.Themes;

using Microsoft.AspNetCore.Components;

namespace DemoBlazorWASM.Shared.Components
{
    public partial class ButtonComponent
    {
        #region parameters

        [Parameter]
        public string Title { get; set; } = string.Empty;

        [Parameter]
        public string Classes { get; set; } = string.Empty;

        [Parameter]
        public EventCallback OnClickEvent { get; set; }

        #endregion parameters

        public async Task HandleOnClick()
        {
            await OnClickEvent.InvokeAsync();
        }
    }
}