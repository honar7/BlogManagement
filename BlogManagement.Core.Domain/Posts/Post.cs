using Golrang.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogManagement.Core.Domain.Posts
{
    public class Post: BaseEntity
    {
        public int BlogId { get; set; }
        public int AuthorId{ get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
