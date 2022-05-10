// See https://aka.ms/new-console-template for more information
//namespace PersonalRegister
//{ 
Console.WriteLine("Enter username:");
string userName = Console.ReadLine();
Employee emp = new Employee();
emp.Name = userName;
Console.WriteLine("Enter Salary:");
string userSalary = Console.ReadLine();
emp.Salary = Convert.ToInt32(userSalary);
Console.WriteLine("Enter username:" + emp.Name);
Console.WriteLine("Enter username:" + emp.Salary);

class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

    }
//}