using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Backend6.Models.ViewModels
{
    public class ForumMessageAttachmentsEditModel
    {
        public IFormFile File { get; set; }
    }
}

