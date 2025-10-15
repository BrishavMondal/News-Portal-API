using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CommentRepo : Repo, IRepo<Comment, int, bool>
    {
        public bool Create(CommentRepo obj)
        {
            throw new NotImplementedException();
        }

        public bool Create(Comment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CommentRepo> Read()
        {
            throw new NotImplementedException();
        }

        public CommentRepo Read(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CommentRepo obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Comment obj)
        {
            throw new NotImplementedException();
        }

        List<Comment> IRepo<Comment, int, bool>.Read()
        {
            throw new NotImplementedException();
        }

        Comment IRepo<Comment, int, bool>.Read(int id)
        {
            throw new NotImplementedException();
        }
    }
}
