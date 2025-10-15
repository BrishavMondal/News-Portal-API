using System;
using DAL.Models;
using DAL.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repos;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<News, int, bool> NewsData()
        {
            return new NewsRepo();
        }
        public static IRepo<Comment, int, bool> CommentData()
        {
            return new CommentRepo();
        }
        public static IRepo<User, string, User> UserData()
        {
            return new UserRepo();
        }
    }
}
