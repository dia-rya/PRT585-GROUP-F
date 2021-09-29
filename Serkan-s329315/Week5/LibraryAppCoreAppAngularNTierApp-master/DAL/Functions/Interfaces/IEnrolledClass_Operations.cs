using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Functions.Interfaces
{
    public interface IEnrolledClass_Operations
    {
        Task<EnrolledClass> Create(EnrolledClass objectToAdd);
        Task<EnrolledClass> Read(Int64 entityId);
        Task<List<EnrolledClass>> ReadAll();
        Task<EnrolledClass> Update(EnrolledClass objectToUpdate, Int64 entityId);
        Task<bool> Delete(Int64 entityId);
    }
}
