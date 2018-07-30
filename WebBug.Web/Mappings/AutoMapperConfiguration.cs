using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBug.Model.Models;
using WebBug.Web.Models;

namespace WebBug.Web.Mappings
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Post, PostViewModel>();
            CreateMap<PostCategory, PostCategoryViewModel>();
            CreateMap<PostTag, PostTagViewModel>();

        }
    }
}