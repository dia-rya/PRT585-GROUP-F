using LOGIC.Services.Models;
using LOGIC.Services.Models.EnrolledClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Services.Interfaces
{
    public interface IEnrolledClass_Service
    {
        /* fetch methods */
        Task<Generic_ResultSet<List<EnrolledClass_ResultSet>>> GetAllEnrolledClasses();
        Task<Generic_ResultSet<EnrolledClass_ResultSet>> GetEnrolledClassById(Int64 id);

        //Task<Generic_ResultSet<Student_ResultSet>> GetStudentByName(String name); always can add extra new calls as needed, and add to its dedicated
        //dal service and interface


        /* Create/Edit/Delete methods */
        Task<Generic_ResultSet<EnrolledClass_ResultSet>> AddEnrolledClass(string name);
        Task<Generic_ResultSet<EnrolledClass_ResultSet>> UpdateEnrolledClass(Int64 id, string name);
        Task<Generic_ResultSet<bool>> DeleteEnrolledClass(Int64 id);

    }
}

