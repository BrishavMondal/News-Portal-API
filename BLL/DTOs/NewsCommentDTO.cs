using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class NewsCommentDTO: NewsDTO
    {
        public List<CommentDTO >Comments { get; set; }
        public NewsCommentDTO()
        {
            Comments = new List<CommentDTO>();
        }
    }
}
