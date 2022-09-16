using Microsoft.AspNetCore.Components;

namespace Portfolio.Shared.Components
{
    public partial class ProjectCard
    {
        [Inject]
        protected NavigationManager NavManager { get; set; }

        [Parameter]
        public ProjectStatus ProjectStatus { get; set; }

        [Parameter]
        public string ProjectName { get; set; }

        [Parameter]
        public List<string> ProjectTags { get; set; } = new List<string>();

        private readonly Dictionary<string, string> TagColorMap = new Dictionary<string, string>()
        {
            {"C#", "var(--cs)"},
            {"C++", "var(--cpp)"},
            {"Unity", "var(--unity)"},
            {"Unreal", "var(--unreal)"}
        };

        protected void RedirectToProject() 
        {
            NavManager.NavigateTo("/outlineProject");
        }

        protected string FetchTagColor(string tag) 
        {
            return TagColorMap.ContainsKey(tag) ? TagColorMap[tag] : "var(--defaultTag)";
        }
    }
}
