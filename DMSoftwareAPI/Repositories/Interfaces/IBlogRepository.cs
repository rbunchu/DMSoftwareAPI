using DMSoftwareAPI.Models.Data;
using System;
using System.Collections.Generic;

namespace DMSoftwareAPI.Repositories.Interfaces
{
    public interface IBlogRepository
    {
        BlogPost GetPost(Guid Id);
        List<BlogPost> ListPosts(int top);
        void AddPost(BlogPost post);
        void UpdatePost(Guid Id, BlogPost post);
        void RemovePost(Guid Id);
    }
}
