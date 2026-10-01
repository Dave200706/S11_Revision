using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace PresseMots.Models
{
    public class StoryTags
    {
        public int Id { get; set; }

        [ForeignKey("Tags")]
        public int TagsId { get; set; }
        [ValidateNever]
        public virtual Tags Tags { get; set; }


        [ForeignKey("Stroy")]
        public int StoryId { get; set; }
        [ValidateNever]
        public virtual Story Story { get; set; }
    }
}
