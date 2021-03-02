using FuckCore.Contracts;
using FuckCore.Contracts.v1;
using FuckCore.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuckCore.Controllers.v1
{
    public class PostsController : Controller
    {
        private List<Post> _posts;

        public PostsController()
        {
            _posts = new List<Post>();
            for (var i = 0; i < 5; i++)
            {
                _posts.Add(new Post { Id = Guid.NewGuid().ToString() });
            }
        }
        [HttpGet(Contracts.ApiRoutes.Posts.GetAll)]

        public IActionResult GetAll()
        {
            return Ok(_posts);
        }
    }
}
