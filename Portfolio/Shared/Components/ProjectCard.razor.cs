using Microsoft.AspNetCore.Components;
using Portfolio.Library;
using System.Security.Cryptography;

namespace Portfolio.Shared.Components
{
    public partial class ProjectCard
    {
        [Inject]
        protected NavigationManager mNavManager { get; set; }

        [Inject]
        protected IProvideColors mColorProvider { get; set; }


        [Parameter]
        public ProjectStatus ProjectStatus { get; set; }

        [Parameter]
        public string ProjectName { get; set; }

        [Parameter]
        public List<string> ProjectTags { get; set; } = new List<string>();

        [Parameter]
        public string TeaserImage { get; set; }

        private readonly Dictionary<string, string> TagColorMap = new Dictionary<string, string>();

        protected void RedirectToProject() 
        {
            string projectUrl = ProjectName.Replace(' ', '_');
            mNavManager.NavigateTo($"/{projectUrl}");
        }

        protected string FetchTagColor(string tag) 
        {
            return mColorProvider.FetchCSSColor(tag);
        }
    }
}
