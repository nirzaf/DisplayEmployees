global using static  System.Console;
using Employess;


List<Employee> employees = new ();

for (int i = 1; i <= 10; i++)
{
    Employee emp = new()
    {
        EmployeeId = Faker.RandomNumber.Next(50000,10000000),
        EmployeeName = Faker.Internet.UserName(),
        Department = Faker.Company.Name()
    };
    employees.Add(emp);
}

foreach (Employee e in employees)
{
    WriteLine($"Employee Id: {e.EmployeeId}, Employee Name : {e.EmployeeName}, Employee Department : {e.Department}");
}