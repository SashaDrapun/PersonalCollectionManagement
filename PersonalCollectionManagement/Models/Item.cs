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

        public string Values { get; set; }

        public string Tegs { get; set; }

        [NotMapped]
        public List<string> FormattedValues
        {
            get
            {
                List<string> result = new List<string>();
                string[] values = Values.Split(new char[] { ',' });

                for (int i = 0; i < values.Length; i++)
                {
                    result.Add(values[i]);
                }

                return result;
            }
            set
            {
                string result = "";
                if(value != null)
                {
                    for (int i = 0; i < value.Count; i++)
                    {
                        result += value[i];
                        if (i != value.Count - 1)
                        {
                            result += ",";
                        }
                    }
                   
                }
               
                Values = result;
            }
        }

        [NotMapped]
        public List<HtmlString> MarkdownFormattedValues
        {
            get
            {
                List<HtmlString> markdownValues = new List<HtmlString>();
                for (int i = 0; i < FormattedValues.Count; i++)
                {
                    markdownValues.Add(Markdown.ParseHtmlString(FormattedValues[i]));
                }
                return markdownValues;
            }
        }

        [NotMapped]
        public List<string> FormattedTegs
        {
            get
            {
                List<string> result = new List<string>();

                if(Tegs != null)
                {
                    string[] tegs = Tegs.Split(new char[] { '#' });

                    for (int i = 1; i < tegs.Length; i++)
                    {
                        result.Add(tegs[i]);
                    }
                }
                return result;
            }
        }

        public int CollectionId { get; set; }
        public Collection Collection { get; set; }
    }
}
