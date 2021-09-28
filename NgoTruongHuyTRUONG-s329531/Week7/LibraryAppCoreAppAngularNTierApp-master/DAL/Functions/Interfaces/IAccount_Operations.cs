using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Functions.Interfaces
{
    public interface IAccount_Operations
    {
        Task<Account> Create(Account objectToAdd);
        Task<Account> Read(Int64 entityId);
        Task<List<Account>> ReadAll();
        Task<Account> Update(Account objectToUpdate, Int64 entityId);
        Task<bool> Delete(Int64 entityId);
    }
}
