using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Models
{
    public class User
    {
        public User(string nickname, string email, string password)
        {
            Nickname = nickname;
            Email = email;
            Password = password;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nickname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime DateRegistration { get; set; }

        public DateTime DateLastLogin { get; set; }
    }
}
