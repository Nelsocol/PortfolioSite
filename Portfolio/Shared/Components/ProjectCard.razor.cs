using Microsoft.AspNetCore.Components;

namespace Portfolio.Shared.Components
{
    public partial class ProjectCard
    {
        [Inject]
        protected NavigationManager NavManager { get; set; }

        protected void RedirectToProject() 
        {
            NavManager.NavigateTo("/outlineProject");
        }
    }
}
