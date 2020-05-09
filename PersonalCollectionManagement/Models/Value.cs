using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Models
{
    public class Value
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Information { get; set; }

        [ForeignKey("Item")]
        public int IdItem { get; set; }

        public Value(string information, int idItem)
        {
            Information = information;
            IdItem = idItem;
        }
    }
}
