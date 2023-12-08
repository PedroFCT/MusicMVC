using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MusicMVC.TagHelper
{
    public class AlertTagHelper
    {
        public string AlertMessage { get; set; }

        public void Process(
                  TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "alert alert-danger");
            output.Content.SetContent(AlertMessage);
        }

    }
}
