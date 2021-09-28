using DAL.DataContext;
using DAL.Entities;
using DAL.Functions.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Functions.Specific
{
    public class Account_Operations : IAccount_Operations
    {
        public async Task<Account> Create(Account objectToAdd)
        {
            try
            {
                using (var context = new DatabaseContext(DatabaseContext.Options.DatabaseOptions))
                {
                    await context.AddAsync<Account>(objectToAdd);
                    await context.SaveChangesAsync();
                    return objectToAdd;
                }
            }
            catch
            {
                throw;
            }
        }

        public async Task<Account> Read(Int64 entityId)
        {
            try
            {
                using (DatabaseContext context = new DatabaseContext(DatabaseContext.Options.DatabaseOptions))
                {
                    var result = await context.FindAsync<Account>(entityId);
                    return result;
                }
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<Account>> ReadAll()
        {
            try
            {
                using (DatabaseContext context = new DatabaseContext(DatabaseContext.Options.DatabaseOptions))
                {
                    var result = await context.Set<Account>().ToListAsync();
                    return result;
                }
            }
            catch
            {
                throw;
            }
        }

        public async Task<Account> Update(Account objectToUpdate, Int64 entityId)
        {
            try
            {
                using (var context = new DatabaseContext(DatabaseContext.Options.DatabaseOptions))
                {
                    var objectFound = await context.FindAsync<Account>(entityId);
                    if (objectFound != null)
                    {
                        context.Entry(objectFound).CurrentValues.SetValues(objectToUpdate);
                        await context.SaveChangesAsync();
                    }
                    return objectFound;
                }
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Delete(Int64 entityId)
        {
            try
            {
                using (DatabaseContext context = new DatabaseContext(DatabaseContext.Options.DatabaseOptions))
                {
                    var recordToDelete = await context.FindAsync<Account>(entityId);
                    if (recordToDelete != null)
                    {
                        context.Remove(recordToDelete);
                        await context.SaveChangesAsync();
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
