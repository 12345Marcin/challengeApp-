using challengeApp_;

Employee employee1 = new Employee("Marcin", "Nowak", 33);
Employee employee2 = new Employee("Krzysztof", "Szrot", 37);
Employee employee3 = new Employee("Dominik", "Kochanek", 40);

employee1.AddScore(2);
employee1.AddScore(4);
employee1.AddScore(6);
employee1.AddScore(8);
employee1.AddScore(10);

employee2.AddScore(1);
employee2.AddScore(4);
employee2.AddScore(7);
employee2.AddScore(2);
employee2.AddScore(2);

employee3.AddScore(3);
employee3.AddScore(4);
employee3.AddScore(3);
employee3.AddScore(6);
employee3.AddScore(6);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{ employee1, employee2, employee3 };

int maxResult = 0;
Employee employeeWithMaxResult = null;
foreach (var employee in employees)
{
    if (employee.maxResult > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.maxResult;
    }

}
Console.WriteLine("Pracownik z najwyższą liczbą punktów: " + employeeWithMaxResult.Name + " " +
employeeWithMaxResult.Surname + " " + employeeWithMaxResult.age + " " + "lat " + "z liczbą punktów" + " " + maxResult);