using MauiTest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest2.Services
{
    public class DataService : IDataService
    {
        private readonly Supabase.Client _client;

        public DataService(Supabase.Client client)
        {
            _client = client;
        }

        public async Task DeleteEmployee(int id)
        {
            await _client.From<Employee>().Where(it => it.Id == id).Delete();
        }

        public async Task<IEnumerable<Employee>> GetData()
        {
            var response = await _client.From<Employee>().Get();
            return response.Models.OrderBy(x => x.Id);
        }

        public async Task<Employee> GetEmployee(int id)
        {
            var response = await _client.From<Employee>().Where(it => it.Id == id).Get();
            return response.Model;
        }

        public async Task CreateEmployee(Employee employee)
        {
            await _client.From<Employee>().Insert(employee);
            await GetData();
        }

        public async Task UpdateEmployee(Employee employee)
        {
            await _client.From<Employee>().Where(it => it.Id == employee.Id)
                .Set(it => it.Name, employee.Name)
                .Set(it => it.Surname, employee.Surname)
                .Set(it => it.Age, employee.Age)
                .Update(employee);
        }

        public async Task<IEnumerable<Employee>> SearchEmployee(string prompt)
        {
            var response = await _client.From<Employee>().Where(it => it.Name.Contains(prompt.ToLower()) || it.Surname.Contains(prompt.ToLower())).Get();
            return response.Models;
        }
    }
}
