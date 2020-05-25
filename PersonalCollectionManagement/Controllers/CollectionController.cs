
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.ViewModels;
using PersonalCollectionManagement.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using PersonalCollectionManagement.Services.CollectionServices;

namespace PersonalCollectionManagement.Controllers
{
    public class CollectionController : Controller
    {
        public CollectionController(ApplicationContext applicationContext)
        {
            Database.SetDB(applicationContext);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCollection(CollectionModel collectionModel)
        {
            await CollectionAdder.AddCollection(collectionModel);
            return RedirectToAction("UserPage", "Home", new { idUser = collectionModel.IdUser});
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCollection(int idCollection)
        {
            User ownerUser = UsersSearcher.GetUser(idCollection);
            await CollectionDeleter.DeleteCollectionAsync(idCollection);
            return RedirectToAction("UserPage", "Home", new { idUser = ownerUser.Id });
        }


        [HttpPost]
        public async Task<IActionResult> EditCollection(CollectionModel collectionModel)
        {
            await CollectionUpdater.UpdateCollection(collectionModel);
            return RedirectToAction("UserPage", "Home", new { idUser = collectionModel.IdUser });
        }
    }
}
