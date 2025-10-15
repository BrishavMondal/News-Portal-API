using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class NewsService
    {
        public static List<NewsDTO> Get()
        {
            var data =DataAccessFactory.NewsData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<News,NewsDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map < List<NewsDTO>>(data);
            return mapped;

        }
        public static NewsDTO Get(int id)
        {
            var data = DataAccessFactory.NewsData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<News, NewsDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<NewsDTO>(data);
            return mapped;
        }

        public static NewsCommentDTO GetNewsComment(int id) {


            var data = DataAccessFactory.NewsData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<News, NewsDTO>();
                c.CreateMap<Comment, CommentDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<NewsCommentDTO>(data);
          
            return mapped;
        }
    }
}
