using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class NewsRepo : Repo, IRepo<News, int, bool>
    {
        public bool Create(News obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<News> Read()
        {
            return db.Newses.ToList();
        }

        public News Read(int id)
        {
            return db.Newses.Find(id);
        }

        public bool Update(News obj)
        {
            throw new NotImplementedException();
        }
    }
}
