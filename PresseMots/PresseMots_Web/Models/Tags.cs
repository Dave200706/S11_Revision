using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Identity.Client;

namespace PresseMots.Models
{
    public class Tags
    {
        public int Id { get; set; }
        public string Name { get;set; }

        

        

        [ValidateNever]
        public virtual List<StoryTags> StoryTags { get; set; }
    }
}
