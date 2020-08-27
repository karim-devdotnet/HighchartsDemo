using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace Highcharts_8._2._0.Helpers
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlString GetJavaScriptObject(this HtmlHelper htmlHelper, object data)
        {
            if (data == null) return MvcHtmlString.Create("{}");

            char quoteChar = '\'';
            string result;

            var serializer = JsonSerializer.Create(new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });

            using (var stringWriter = new StringWriter())
            {
                using (var writer = new JsonTextWriter(stringWriter))
                {
                    writer.QuoteName = false;
                    writer.QuoteChar = quoteChar;
                    serializer.Serialize(writer, data);
                }

                result = stringWriter.ToString();
            }

            IList<string> noValueQuoteMembers = new List<string>() { "formatter" };

            foreach (string member in noValueQuoteMembers)
            {
                int memberPosition = result.IndexOf(member);

                for (int i = 0; i < 2 && memberPosition >= 0; i++)
                {
                    int quotePosition = result.NextIndexOf(quoteChar, memberPosition);
                    if (quotePosition >= 0) result = result.Remove(quotePosition, 1);
                }
            }

            return MvcHtmlString.Create(result);
        }
    }
}