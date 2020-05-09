using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Models
{
    public class Field
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }

        [ForeignKey("Collection")]
        public int IdCollection { get; set; }

        public Field(string name, string type, int idCollection)
        {
            Name = name;
            Type = type;
            IdCollection = idCollection;
        }
    }
}
