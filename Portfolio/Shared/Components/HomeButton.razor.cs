using Microsoft.AspNetCore.Components;

namespace Portfolio.Shared.Components
{
    public partial class HomeButton
    {
        [Inject]
        protected NavigationManager NavManager { get; set; }

        protected void RedirectHome()
        {
            NavManager.NavigateTo("/");
        }
    }
}
