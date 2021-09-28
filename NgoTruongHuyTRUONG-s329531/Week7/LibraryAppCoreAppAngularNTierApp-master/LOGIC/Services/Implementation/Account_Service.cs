using DAL.Entities;
using DAL.Functions.Interfaces;
using DAL.Functions.Specific;
using LOGIC.Services.Interfaces;
using LOGIC.Services.Models;
using LOGIC.Services.Models.Account;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LOGIC.Services.Implementation
{
    /// <summary>
    /// This service allows us to Add, Fetch and Update Account account Data
    /// </summary>
    public class Account_Service : IAccount_Service
    {
        //Reference to our crud functions
        private IAccount_Operations _account_operations = new Account_Operations();

        /// <summary>
        /// Obtains all the Account accountes that exist in the database
        /// </summary>
        /// <returns></returns>
        public async Task<Generic_ResultSet<List<Account_ResultSet>>> GetAllAccounts()
        {
            Generic_ResultSet<List<Account_ResultSet>> result = new Generic_ResultSet<List<Account_ResultSet>>();
            try
            {
                //GET ALL Account accountES
                List<Account> Accountes = await _account_operations.ReadAll();
                //MAP DB Account RESULTS
                result.result_set = new List<Account_ResultSet>();
                Accountes.ForEach(s =>
                {
                    result.result_set.Add(new Account_ResultSet
                    {
                        account_id = s.AccountID,
                        name = s.Account_Name,
                    });
                });

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("All Account accountes obtained successfully");
                result.internalMessage = "LOGIC.Services.Implementation.Account_Service: GetAllAccounts() method executed successfully.";
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed fetch all the required Account accountes from the database.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Account_Service: GetAllAccounts(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }


        public async Task<Generic_ResultSet<Account_ResultSet>> GetAccountById(long id)
        {
            Generic_ResultSet<Account_ResultSet> result = new Generic_ResultSet<Account_ResultSet>();
            try
            {
                //GET by ID Account 
                var Account = await _account_operations.Read(id);

                //MAP DB Account RESULTS
                result.result_set = new Account_ResultSet
                {
                    name = Account.Account_Name,
                    account_id = Account.AccountID
                };

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("Get ByID - Account  obtained successfully");
                result.internalMessage = "LOGIC.Services.Implementation.Account_Service: Get ByID() method executed successfully.";
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed fetch Get ByID the required Account  from the database.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Account_Service: Get ByID(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }


        /// <summary>
        /// Adds a new account to the database
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<Generic_ResultSet<Account_ResultSet>> AddAccount(string name)
        {
            Generic_ResultSet<Account_ResultSet> result = new Generic_ResultSet<Account_ResultSet>();
            try
            {
                //INIT NEW DB ENTITY OF Account
                Account Account = new Account
                {
                    Account_Name = name
                };

                //ADD Account TO DB
                Account = await _account_operations.Create(Account);

                //MANUAL MAPPING OF RETURNED Account VALUES TO OUR Account_ResultSet
                Account_ResultSet accountAdded = new Account_ResultSet
                {
                    name = Account.Account_Name,
                    account_id = Account.AccountID
                };

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("The supplied Account account {0} was added successfully", name);
                result.internalMessage = "LOGIC.Services.Implementation.Account_Service: AddAccount() method executed successfully.";
                result.result_set = accountAdded;
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed to register your information for the Account account supplied. Please try again.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Account_Service: AddAccount(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }

        /// <summary>
        /// Updat an Account accounts name.
        /// </summary>
        /// <param name="account_id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<Generic_ResultSet<Account_ResultSet>> UpdateAccount(Int64 account_id, string name)
        {
            Generic_ResultSet<Account_ResultSet> result = new Generic_ResultSet<Account_ResultSet>();
            try
            {
                //INIT NEW DB ENTITY OF Account
                Account Account = new Account
                {
                    AccountID = account_id,
                    Account_Name = name,
                    //Account_ModifiedDate = DateTime.UtcNow 
                };

                //UPDATE Account IN DB
                Account = await _account_operations.Update(Account, account_id);

                //MANUAL MAPPING OF RETURNED Account VALUES TO OUR Account_ResultSet
                Account_ResultSet accountUpdated = new Account_ResultSet
                {
                    name = Account.Account_Name,
                    account_id = Account.AccountID
                };

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("The supplied Account account {0} was updated successfully", name);
                result.internalMessage = "LOGIC.Services.Implementation.Account_Service: UpdateAccount() method executed successfully.";
                result.result_set = accountUpdated;
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed to update your information for the Account account supplied. Please try again.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Account_Service: UpdateAccount(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }


        public async Task<Generic_ResultSet<bool>> DeleteAccount(long account_id)
        {
            Generic_ResultSet<bool> result = new Generic_ResultSet<bool>();
            try
            {
                //delete Account IN DB
                var accountDeleted = await _account_operations.Delete(account_id);

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("The supplied Account account {0} was deleted successfully", account_id);
                result.internalMessage = "LOGIC.Services.Implementation.Account_Service: DeleteAccount() method executed successfully.";
                result.result_set = accountDeleted;
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed to Delete your information for the Account account supplied. Please try again.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Account_Service: DeleteAccount(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }

    }
}
