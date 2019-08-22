using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDFService.Dto;
using PDFService.Enums;

namespace PDFService.Services
{
    /// <summary>
    /// Represent service to perfom CRUD operation for Departments table
    /// between database and cient
    /// </summary>
    public interface IDepartmentService : IAppService
    {
        /// <summary>
        /// Get all departments from the database
        /// </summary>
        /// <returns>List of departments represented by <see cref="DepartmentDto"/> type</returns>
        IEnumerable<DepartmentDto> GetAllDepartments();


        /// <summary>
        /// Get department by ID from the database
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        DepartmentDto GetDepartment(int departmentId);
    }
}
