using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Functions.Interfaces
{
    public interface IBlog_Operations
    {
        Task<Blog> Create(Blog objectToAdd);
        Task<Blog> Read(Int64 entityId);
        Task<List<Blog>> ReadAll();
        Task<Blog> Update(Blog objectToUpdate, Int64 entityId);
        Task<bool> Delete(Int64 entityId);
    }
}
