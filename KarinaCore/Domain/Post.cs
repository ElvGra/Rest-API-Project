using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuckCore.Domain
{
   public class Post
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
