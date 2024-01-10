// See https://aka.ms/new-console-template for more information
using ConAppTwo;

List<Employee> employees = new List<Employee>()
{
    new Employee(){Id=1,Name="Vijay",Designation="Developer",Doj=new DateTime(day:12,month:11,year:2022)},
    new Employee(){Id=2,Name="Kamal",Designation="Tester",Doj=new DateTime(day:12,month:11,year:2022)},
    new Employee(){Id=3,Name="Ajith",Designation="Manager",Doj=new DateTime(day:12,month:11,year:2022)},
    new Employee(){Id=4,Name="Surya",Designation="Manager",Doj=new DateTime(day:12,month:11,year:2023)},
    new Employee(){Id=5,Name="Vikran",Designation="Developer",Doj=new DateTime(day:12,month:11,year:2021)},
};
Console.WriteLine("ID\t Name \t Designation \t Date of Joining");
foreach(Employee emp in employees)
{
    Console.Write(emp.Id+"\t \t");
    Console.Write(emp.Name + "\t \t");
    Console.Write(emp.Designation + "\t \t");
    Console.Write(emp.Doj.ToLongDateString());
    Console.WriteLine("\n");
}
Console.ReadKey();
