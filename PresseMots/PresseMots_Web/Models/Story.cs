using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using PresseMots.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresseMots.Models
{
    public class Story : IWordCountable
    {

        public Story()
        {
            Likes = new List<Like>();
            Shares = new List<Share>();
            Comments = new List<Comment>();

        }
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage ="le contenu de l'histoire est obligatoire")]
        [Range(25,1000,ErrorMessage ="Le {0} doit être d'un minimum de {1} et un maximum de {2}")]
        public string Content { get; set; }

        //[NotMapped]
        //public IList<string> Tags { get; set; } = new List<string>();
        

        [ValidateNever]
        public virtual List<StoryTags> StoryTags { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? LastEditTime { get; set; }
        public DateTime? PublishTime { get; set; }
        public bool Draft { get; set; }

        public virtual User Owner { get; set; }
        public int OwnerId { get; set; }
        public virtual IList<Like> Likes { get; set; }

        public virtual IList<Share> Shares { get; set; }

        public virtual IList<Comment> Comments { get; set; }


    }
}
