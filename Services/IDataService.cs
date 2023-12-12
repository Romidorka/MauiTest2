using MauiTest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest2.Services
{
    public interface IDataService
    {
        public Task<IEnumerable<Employee>> GetData();
        public Task<Employee> GetEmployee(int id);
        public Task CreateEmployee(Employee employee);
        public Task UpdateEmployee(Employee employee);
        public Task DeleteEmployee(int id);
        public Task<IEnumerable<Employee>> SearchEmployee(string prompt);
    }
}
