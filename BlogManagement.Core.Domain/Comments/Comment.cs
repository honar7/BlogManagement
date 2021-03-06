using Golrang.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogManagement.Core.Domain.Comments
{
    public class Comment: BaseEntity
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public int? ParentId { get; set; }
    }
}
