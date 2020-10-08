using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSKProje.Web.TagHelpers
{
    [HtmlTargetElement("gizem")]//("") yazdığım yerde override edebilmem için ir tag alması lazım onun için kendimiz bir tag yazıyoruz 
    public class Paragraf:TagHelper
    {
        //TagHelper olarak Paargraf classını ooluşturmamdaki amaç benim yerime paragraf oluşturabilsin 

        //gelen-data
        public string GelenData { get; set; } = "Cennet Gizem Söylemez";
                                           //Process methodu tagheperin kendi içinde barındırıyor
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //string data
            //tagbuilder
            //stringbuilder


            //1.Yöntem
            //var tagBuilder = new TagBuilder("p");//p dersem p etiketi dönecek bana 
            //tagBuilder.InnerHtml.AppendHtml("<b>Cennet gizem söylemez</b>");
            //base.Process(context, output);


            //2.Yönetem
            //var stringBuilder = new StringBuilder();
            //stringBuilder.Append("<p>");//AppendFormat da kullanılabilir 
            ////("<p> {0}", "Cennet Gizem Söylemez"); //0 gördüğün yere cennet gizem söylemez yaz diyoruz 
            //output.Content.SetHtmlContent(stringBuilder.ToString());

            //3.Yöntem
            string data = string.Empty;

            data = "<p>" + "Cennet Gizem Söylemez";
            output.Content.SetHtmlContent(data);

        }
    }
}
