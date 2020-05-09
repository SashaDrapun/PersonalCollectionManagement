using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Models
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Collection")]
        public int CollectionId { get; set; }

        [NotMapped]
        public List<HtmlString> MarkdownFormattedValues
        {
            get
            {
                List<HtmlString> markdownValues = new List<HtmlString>();
                for (int i = 0; i < Values.Count; i++)
                {
                    markdownValues.Add(Markdown.ParseHtmlString(Values[i]));
                }
                return markdownValues;
            }
        }

        [NotMapped]
        public List<string> Values { get; set; }

        [NotMapped]
        public List<string> Tags { get; set; }

        [NotMapped]
        public Collection Collection { get; set; }
    }
}
