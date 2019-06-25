using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorBB.Server.Controllers
{
    public class ForumController : Controller
    {
        // GET: /api/forums/all
        [HttpGet("/api/forums/all", Name = "Forums/All")]
        public IActionResult All()
        {
            //TODO

            List<Shared.Models.Forum> forums = new List<Shared.Models.Forum>();

            forums.Add(new Shared.Models.Forum { Id = MongoDB.Bson.ObjectId.GenerateNewId(), name = "Test 1" });
            forums.Add(new Shared.Models.Forum { Id = MongoDB.Bson.ObjectId.GenerateNewId(), name = "Test 2" });
            forums.Add(new Shared.Models.Forum { Id = MongoDB.Bson.ObjectId.GenerateNewId(), name = "Test 3" });
            forums.Add(new Shared.Models.Forum { Id = MongoDB.Bson.ObjectId.GenerateNewId(), name = "Test 4" });

            return Json(forums);
        }
    }
}
