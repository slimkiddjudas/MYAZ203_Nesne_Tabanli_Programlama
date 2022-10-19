using Hafta_2_Odev;

EmployeeManager employeeManager = new EmployeeManager();
Employee employee = new Employee
{
    Id = 4,
    FirstName = "Ali",
    LastName = "Çavuş",
    Age = 20
};

employeeManager.GetAll();
Console.WriteLine("-----------");
employeeManager.Add(employee);
employeeManager.GetAll();
Console.WriteLine("-----------");
employeeManager.Remove(3);
employeeManager.GetAll();
Console.WriteLine("-----------");
employeeManager.Remove(5);
employeeManager.GetAll();
Console.WriteLine("-----------");