using Microsoft.AspNetCore.Http;
using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.ViewModels
{
    public class CollectionModel
    {
        public int IdCollection { get; set; }
        public string NameCollection { get; set; }
        public string Description { get; set; }
        public List<string> NameField { get; set; }
        public List<string> TypeField { get; set; }
        public string NicknameUser { get; set; }
    }
}
