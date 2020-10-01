using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YSKProje.Web.TagHelpers
{
    [HtmlTargetElement("gizem")]
    public class Paragraf:TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //string data
            //tagbuilder
            //stringbuilder

            var tagBuilder = new TagBuilder("p");
            tagBuilder.InnerHtml.AppendHtml("<b>Cennet gizem söylemez</b>");
            base.Process(context, output);
        }
    }
}
