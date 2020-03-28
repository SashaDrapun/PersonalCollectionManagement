using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Models
{
    public class User : IdentityUser
    {
        public User(string nickname, string email)
        {
            Nickname = nickname;
            Email = email;
            this.IsAdmin = false;
            this.Status = "Разблокирован";
            this.Language = "ru";
            this.Theme = "Dark";
        }

        public bool IsAdmin { get; set; }
        public string Nickname { get; set; }

        public string Status { get; set; }

        public string Language { get; set; }

        public string Theme { get; set; }

        public DateTime DateRegistration { get; set; }

        public DateTime DateLastLogin { get; set; }
    }
}
