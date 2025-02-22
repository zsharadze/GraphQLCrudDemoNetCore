using GraphQLCrudDemo.Models;
using GraphQLCrudDemo.Repository;

namespace GraphQLCrudDemo.GraphQL
{
    public class EmployeeMutations
    {
        public async Task<Employee> AddEmployee(Employee input, [Service] EmployeeRepository repository)
        {
            var employee = await repository.AddEmployeeAsync(input);
            return employee;
        }

        public async Task<Employee> UpdateEmployee(Employee input, [Service] EmployeeRepository repository)
        {
            var updatedEmployee = await repository.UpdateEmployeeAsync(input);
            return updatedEmployee;
        }

        public async Task<bool> DeleteEmployee(int id, [Service] EmployeeRepository repository)
        {
            return await repository.DeleteEmployeeAsync(id);
        }
    }
}