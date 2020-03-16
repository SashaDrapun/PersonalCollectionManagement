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
        }

        public int CollectionId { get; set; }
        public Collection Collection { get; set; }
    }
}
