using Microsoft.AspNetCore.Components;

namespace DemoBlazorWASM.Shared.Components
{
    public partial class ButtonComponent
    {
        [Parameter]
        public string Title { get; set; } = string.Empty;

        [Parameter]
        public string Classes { get; set; } = string.Empty;

        [Parameter]
        public EventCallback OnClickEvent { get; set; }

        public async Task HandleOnClick() => await OnClickEvent.InvokeAsync();
    }
}