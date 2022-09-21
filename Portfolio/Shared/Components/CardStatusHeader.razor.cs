using Microsoft.AspNetCore.Components;

namespace Portfolio.Shared.Components
{
    public enum ProjectStatus { 
        COMPLETE,
        IN_PROGRESS,
        ACTIVE
    }

    public partial class CardStatusHeader
    {
        [Parameter]
        public ProjectStatus CardStatus { get; set; }

        private string mStatusString { get; set; }
        private string mColor { get; set; }
        private readonly Dictionary<ProjectStatus, (string, string)> mDataReference = new Dictionary<ProjectStatus, (string, string)>(){
            {ProjectStatus.COMPLETE, ("COMPLETE", "var(--completed)")},
            {ProjectStatus.IN_PROGRESS, ("IN PROGRESS", "var(--inprogress)")},
            {ProjectStatus.ACTIVE, ("ACTIVE", "var(--active)")}
        };
        
        protected override void OnInitialized()
        {
            mStatusString = mDataReference[CardStatus].Item1;
            mColor = mDataReference[CardStatus].Item2;
            base.OnInitialized();
        }
    }
}
