using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserCommentDTO: UserDTO
    {
        public List<CommentDTO> Comments { get; set; }
        public UserCommentDTO()
        {
            Comments = new List<CommentDTO>();
        }
    }
}
