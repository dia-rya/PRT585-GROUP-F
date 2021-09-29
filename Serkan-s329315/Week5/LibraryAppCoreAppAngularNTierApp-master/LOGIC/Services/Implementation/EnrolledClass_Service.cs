using DAL.Entities;
using DAL.Functions.Interfaces;
using DAL.Functions.Specific;
using LOGIC.Services.Interfaces;
using LOGIC.Services.Models;
using LOGIC.Services.Models.EnrolledClass;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LOGIC.Services.Implementation
{
    /// <summary>
    /// This service allows us to Add, Fetch and Update Student student Data
    /// </summary>
    public class EnrolledClass_Service : IEnrolledClass_Service
    {
        //Reference to our crud functions
        private IEnrolledClass_Operations _EnrolledClass_operations = new EnrolledClass_Operations();

        /// <summary>
        /// Obtains all the Student studentes that exist in the database
        /// </summary>
        /// <returns></returns>
        public async Task<Generic_ResultSet<List<EnrolledClass_ResultSet>>> GetAllEnrolledClasses()
        {
            Generic_ResultSet<List<EnrolledClass_ResultSet>> result = new Generic_ResultSet<List<EnrolledClass_ResultSet>>();
            try
            {
                //GET ALL Student studentES
                List<EnrolledClass> EnrolledClasses = await _EnrolledClass_operations.ReadAll();
                //MAP DB Student RESULTS
                result.result_set = new List<EnrolledClass_ResultSet>();
                EnrolledClasses.ForEach(s =>
                {
                    result.result_set.Add(new EnrolledClass_ResultSet
                    {
                        EnrolledClass_id = s.EnrolledClassID,
                        name = s.EnrolledClass_Name,
                    });
                });

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("All EnrolledClass EnrolledClasses obtained successfully");
                result.internalMessage = "LOGIC.Services.Implementation.EnrolledClass_Service: GetAllEnrolledClasses() method executed successfully.";
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed fetch all the required EnrolledClass EnrolledClasses from the database.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.EnrolledClass_Service: GetAllEnrolledClasses(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }


        public async Task<Generic_ResultSet<EnrolledClass_ResultSet>> GetEnrolledClassById(long id)
        {
            Generic_ResultSet<EnrolledClass_ResultSet> result = new Generic_ResultSet<EnrolledClass_ResultSet>();
            try
            {
                //GET by ID Student 
                var EnrolledClass = await _EnrolledClass_operations.Read(id);

                //MAP DB Student RESULTS
                result.result_set = new EnrolledClass_ResultSet
                {
                    name = EnrolledClass.EnrolledClass_Name,
                    EnrolledClass_id = EnrolledClass.EnrolledClassID
                };

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("Get ByID - EnrolledClass  obtained successfully");
                result.internalMessage = "LOGIC.Services.Implementation.EnrolledClass_Service: Get ByID() method executed successfully.";
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed fetch Get ByID the required EnrolledClass  from the database.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.EnrolledClass_Service: Get ByID(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }


        /// <summary>
        /// Adds a new student to the database
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<Generic_ResultSet<EnrolledClass_ResultSet>> AddEnrolledClass(string name)
        {
            Generic_ResultSet<EnrolledClass_ResultSet> result = new Generic_ResultSet<EnrolledClass_ResultSet>();
            try
            {
                //INIT NEW DB ENTITY OF Student
                EnrolledClass EnrolledClass = new EnrolledClass
                {
                    EnrolledClass_Name = name
                };

                //ADD Student TO DB
                EnrolledClass = await _EnrolledClass_operations.Create(EnrolledClass);

                //MANUAL MAPPING OF RETURNED Student VALUES TO OUR Student_ResultSet
                EnrolledClass_ResultSet EnrolledClassAdded = new EnrolledClass_ResultSet
                {
                    name = EnrolledClass.EnrolledClass_Name,
                    EnrolledClass_id = EnrolledClass.EnrolledClassID
                };

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("The supplied EnrolledClass EnrolledClass {0} was added successfully", name);
                result.internalMessage = "LOGIC.Services.Implementation.EnrolledClass_Service: AddEnrolledClass() method executed successfully.";
                result.result_set = EnrolledClassAdded;
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed to register your information for the EnrolledClass EnrolledClass supplied. Please try again.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.EnrolledClass_Service: AddEnrolledClass(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }

        /// <summary>
        /// Updat an Student students name.
        /// </summary>
        /// <param name="EnrolledClass_id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<Generic_ResultSet<EnrolledClass_ResultSet>> UpdateEnrolledClass(Int64 EnrolledClass_id, string name)
        {
            Generic_ResultSet<EnrolledClass_ResultSet> result = new Generic_ResultSet<EnrolledClass_ResultSet>();
            try
            {
                //INIT NEW DB ENTITY OF Student
                EnrolledClass EnrolledClass = new EnrolledClass
                {
                    EnrolledClassID = EnrolledClass_id,
                    EnrolledClass_Name = name,
                    //Student_ModifiedDate = DateTime.UtcNow 
                };

                //UPDATE Student IN DB
                EnrolledClass = await _EnrolledClass_operations.Update(EnrolledClass, EnrolledClass_id);

                //MANUAL MAPPING OF RETURNED Student VALUES TO OUR Student_ResultSet
                EnrolledClass_ResultSet EnrolledClassUpdated = new EnrolledClass_ResultSet
                {
                    name = EnrolledClass.EnrolledClass_Name,
                    EnrolledClass_id = EnrolledClass.EnrolledClassID
                };

                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("The supplied EnrolledClass EnrolledClass {0} was updated successfully", name);
                result.internalMessage = "LOGIC.Services.Implementation.EnrolledClass_Service: UpdateEnrolledClass() method executed successfully.";
                result.result_set = EnrolledClassUpdated;
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed to update your information for the EnrolledClass EnrolledClass supplied. Please try again.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.EnrolledClass_Service: UpdateEnrolledClass(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }


        public async Task<Generic_ResultSet<bool>> DeleteEnrolledClass(long EnrolledClass_id)
        {
            Generic_ResultSet<bool> result = new Generic_ResultSet<bool>();
            try
            {               
                //delete Student IN DB
                var EnrolledClassDeleted = await _EnrolledClass_operations.Delete(EnrolledClass_id);
                
                //SET SUCCESSFUL RESULT VALUES
                result.userMessage = string.Format("The supplied Student student {0} was deleted successfully", EnrolledClass_id);
                result.internalMessage = "LOGIC.Services.Implementation.EnrolledClass_Service: DeleteStudent() method executed successfully.";
                result.result_set = EnrolledClassDeleted;
                result.success = true;
            }
            catch (Exception exception)
            {
                //SET FAILED RESULT VALUES
                result.exception = exception;
                result.userMessage = "We failed to Delete your information for the Student student supplied. Please try again.";
                result.internalMessage = string.Format("ERROR: LOGIC.Services.Implementation.Student_Service: DeleteStudent(): {0}", exception.Message); ;
                //Success by default is set to false & its always the last value we set in the try block, so we should never need to set it in the catch block.
            }
            return result;
        }

    }
}
