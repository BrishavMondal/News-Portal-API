 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserNewsDTO: UserDTO
    {
        public List<NewsDTO> Newses { get; set; }
        public UserNewsDTO()
        {
            Newses = new List<NewsDTO>();
        }
    }
}
