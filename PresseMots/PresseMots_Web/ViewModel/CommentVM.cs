using System.Collections.Generic;
using Microsoft.AspNetCore.Routing;
using PresseMots.Models;

namespace PresseMots.ViewModel
{
    public class CommentVM
    {
        public int WordCount { get; set; }
        public string StoryTitle { get; set; }
        public string ShortStory { get; set; }
        public int? StoryId { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
