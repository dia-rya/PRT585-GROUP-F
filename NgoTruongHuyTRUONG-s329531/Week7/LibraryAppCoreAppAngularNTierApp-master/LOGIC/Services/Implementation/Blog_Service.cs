using DAL.Entities;
using DAL.Functions.Interfaces;
using DAL.Functions.Specific;
using LOGIC.Services.Interfaces;
using LOGIC.Services.Models;
using LOGIC.Services.Models.Blog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LOGIC.Services.Implementation
{
    /// <summary>
    /// This service allows us to Add, Fetch and Update Blog blog Data
    /// </summary>
    public class Blog_Service : IBlog_Service
    {
        //Reference to our crud functions
        private IBlog_Operations _blog_operations = new Blog_Operations();

        /// <summary>
        /// Obtains all the Blog bloges that exist in the database
        /// </summary>
        /// <returns></returns>
        public async Task<Generic_ResultSet<List<Blog_ResultSet>>> GetAllBlogs()
        {
            Generic_ResultSet<List<Blog_ResultSet>> result = new Generic_ResultSet<List<Blog_ResultSet>>();
            try
            {
                //GET ALL Blog blogES
                List<Blog> Bloges = await _blog_operations.ReadAll();
                //MAP DB Blog RESULTS
                result.result_set = new List<Blog_ResultSet>();
                Bloges.ForEach(s =>
                {
                    result.result_set.Add(new Blog_ResultSet
                    {
                        blog_id = s.BlogID,
                        name = s.Blog_Name,
                    });
                });

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("All Blog bloges obtained successfully");
                result.internalMessage = "LOGIC.Services.Implementation.Blog_Service: GetAllBlogs() method executed successfully.";
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed fetch all the required Blog bloges from the database.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Blog_Service: GetAllBlogs(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }


        public async Task<Generic_ResultSet<Blog_ResultSet>> GetBlogById(long id)
        {
            Generic_ResultSet<Blog_ResultSet> result = new Generic_ResultSet<Blog_ResultSet>();
            try
            {
                //GET by ID Blog 
                var Blog = await _blog_operations.Read(id);

                //MAP DB Blog RESULTS
                result.result_set = new Blog_ResultSet
                {
                    name = Blog.Blog_Name,
                    blog_id = Blog.BlogID
                };

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("Get ByID - Blog  obtained successfully");
                result.internalMessage = "LOGIC.Services.Implementation.Blog_Service: Get ByID() method executed successfully.";
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed fetch Get ByID the required Blog  from the database.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Blog_Service: Get ByID(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }


        /// <summary>
        /// Adds a new blog to the database
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<Generic_ResultSet<Blog_ResultSet>> AddBlog(string name)
        {
            Generic_ResultSet<Blog_ResultSet> result = new Generic_ResultSet<Blog_ResultSet>();
            try
            {
                //INIT NEW DB ENTITY OF Blog
                Blog Blog = new Blog
                {
                    Blog_Name = name
                };

                //ADD Blog TO DB
                Blog = await _blog_operations.Create(Blog);

                //MANUAL MAPPING OF RETURNED Blog VALUES TO OUR Blog_ResultSet
                Blog_ResultSet blogAdded = new Blog_ResultSet
                {
                    name = Blog.Blog_Name,
                    blog_id = Blog.BlogID
                };

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("The supplied Blog blog {0} was added successfully", name);
                result.internalMessage = "LOGIC.Services.Implementation.Blog_Service: AddBlog() method executed successfully.";
                result.result_set = blogAdded;
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed to register your information for the Blog blog supplied. Please try again.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Blog_Service: AddBlog(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }

        /// <summary>
        /// Updat an Blog blogs name.
        /// </summary>
        /// <param name="blog_id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<Generic_ResultSet<Blog_ResultSet>> UpdateBlog(Int64 blog_id, string name)
        {
            Generic_ResultSet<Blog_ResultSet> result = new Generic_ResultSet<Blog_ResultSet>();
            try
            {
                //INIT NEW DB ENTITY OF Blog
                Blog Blog = new Blog
                {
                    BlogID = blog_id,
                    Blog_Name = name,
                    //Blog_ModifiedDate = DateTime.UtcNow 
                };

                //UPDATE Blog IN DB
                Blog = await _blog_operations.Update(Blog, blog_id);

                //MANUAL MAPPING OF RETURNED Blog VALUES TO OUR Blog_ResultSet
                Blog_ResultSet blogUpdated = new Blog_ResultSet
                {
                    name = Blog.Blog_Name,
                    blog_id = Blog.BlogID
                };

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("The supplied Blog blog {0} was updated successfully", name);
                result.internalMessage = "LOGIC.Services.Implementation.Blog_Service: UpdateBlog() method executed successfully.";
                result.result_set = blogUpdated;
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed to update your information for the Blog blog supplied. Please try again.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Blog_Service: UpdateBlog(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }


        public async Task<Generic_ResultSet<bool>> DeleteBlog(long blog_id)
        {
            Generic_ResultSet<bool> result = new Generic_ResultSet<bool>();
            try
            {
                //delete Blog IN DB
                var blogDeleted = await _blog_operations.Delete(blog_id);

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("The supplied Blog blog {0} was deleted successfully", blog_id);
                result.internalMessage = "LOGIC.Services.Implementation.Blog_Service: DeleteBlog() method executed successfully.";
                result.result_set = blogDeleted;
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed to Delete your information for the Blog blog supplied. Please try again.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Blog_Service: DeleteBlog(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }

    }
}
