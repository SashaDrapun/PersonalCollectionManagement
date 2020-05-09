using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Models
{
    public class Collection
    {
        public Collection(string name, string description, string image)
        {
            Name = name;
            Description = description;
            Image = image;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        [NotMapped]
        public HtmlString MarkdownDescription
        {
            get
            {
                return Markdown.ParseHtmlString(Description);
            }
        }

        [NotMapped]
        public int CountItems { get; set; }

        [NotMapped]
        public List<Field> Fields{ get; set; }

        [NotMapped]
        public User OwnerCollection { get; set; }

        [NotMapped]
        public string FormattedFields { 
            get 
            {
                string result = "";
                for (int i = 0; i < Fields.Count; i++)
                {
                    result += Fields[i].Name + "," + Fields[i].Type;

                    if(i != Fields.Count - 1)
                    {
                        result += ";";
                    }
                }
                return result;
            }  
        }
    }
}
