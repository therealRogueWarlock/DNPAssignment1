using Microsoft.AspNetCore.Components;

namespace DNPAssignment1.Shared
{
    public partial class SurveyPrompt
    {
        
        // Demonstrates how a parent component can supply parameters
        [Parameter]
        public string Title { get; set; }
    }
}