using LOGIC.Services.Models;
using LOGIC.Services.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Services.Interfaces
{
    public interface IAccount_Service
    {
        /* fetch methods */
        Task<Generic_ResultSet<List<Account_ResultSet>>> GetAllAccounts();
        Task<Generic_ResultSet<Account_ResultSet>> GetAccountById(Int64 id);

        //Task<Generic_ResultSet<Account_ResultSet>> GetAccountByName(String name); always can add extra new calls as needed, and add to its dedicated
        //dal service and interface


        /* Create/Edit/Delete methods */
        Task<Generic_ResultSet<Account_ResultSet>> AddAccount(string name);
        Task<Generic_ResultSet<Account_ResultSet>> UpdateAccount(Int64 id, string name);
        Task<Generic_ResultSet<bool>> DeleteAccount(Int64 id);

    }
}

