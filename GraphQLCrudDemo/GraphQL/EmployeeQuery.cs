using GraphQLCrudDemo.Models;
using GraphQLCrudDemo.Repository;

namespace GraphQLCrudDemo.GraphQL
{
    public class EmployeeQueryTypes
    {
        public async Task<List<Employee>> GetEmployees([Service] EmployeeRepository repository) =>
        await repository.GetAllEmployeeAsync();

        public async Task<Employee> GetEmployee(int id, [Service] EmployeeRepository repository) =>
        await repository.GetEmployeeAsync(id);
    }
}
