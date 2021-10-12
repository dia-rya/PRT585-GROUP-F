using LOGIC.Services.Models;
using LOGIC.Services.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Services.Interfaces
{
    public interface IBlog_Service
    {
        /* fetch methods */
        Task<Generic_ResultSet<List<Blog_ResultSet>>> GetAllBlogs();
        Task<Generic_ResultSet<Blog_ResultSet>> GetBlogById(Int64 id);

        //Task<Generic_ResultSet<Blog_ResultSet>> GetBlogByName(String name); always can add extra new calls as needed, and add to its dedicated
        //dal service and interface


        /* Create/Edit/Delete methods */
        Task<Generic_ResultSet<Blog_ResultSet>> AddBlog(string name);
        Task<Generic_ResultSet<Blog_ResultSet>> UpdateBlog(Int64 id, string name);
        Task<Generic_ResultSet<bool>> DeleteBlog(Int64 id);

    }
}

