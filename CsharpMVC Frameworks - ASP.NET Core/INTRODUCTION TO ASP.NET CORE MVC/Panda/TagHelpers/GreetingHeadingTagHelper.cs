using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Panda.TagHelpers
{
    [HtmlTargetElement("h1", Attributes = "asp-name")]
    public class GreetingHeadingTagHelper : TagHelper
    {
        public string AspName { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetContent($"hello, {this.AspName}");
        }
    }
}