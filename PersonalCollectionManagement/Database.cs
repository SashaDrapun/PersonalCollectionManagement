using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement
{
    public static class Database
    {
        public static ApplicationContext db;

        public static void SetDB(ApplicationContext applicationContext)
        {
            db = applicationContext;
        }
    }
}
