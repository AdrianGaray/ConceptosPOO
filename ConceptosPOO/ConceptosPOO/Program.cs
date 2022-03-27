using ConceptosPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");
Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    lastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815453.45M
};
//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Patricia",
    lastName = "Perez",
    BirthDate = new Date(1995, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Sales = 320000000M, // Es una constante de tipo Mnoey, por eso se pone M
    CommissionPercentaje = 0.03F, //Es una constante de tipo float, por eso se pone F. Las unicas constantes que no hay q ponerle nada son double
};
//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Gonzalo",
    lastName = "Cardona",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    HourValue = 12356.56M, // M => representa dinero
    Hours = 123.5F
};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Jazmin",
    lastName = "Salazar",
    BirthDate = new Date(1988, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Base = 860678.45M,
    Sales = 58000000M,
    CommissionPercentaje = 0.015F
};
//Console.WriteLine(employee4);


// Crear una lista de empleados.
ICollection<Employee> employees = new List<Employee>()
{
    employee1, 
    employee2, 
    employee3, 
    employee4
};

/* employees.Add(employee1);
employees.Add(employee2);
employees.Add(employee3);
employees.Add(employee4); */

decimal payroll = 0; // es plata/moneda
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                               ==================");
Console.WriteLine($"TOTAL                          {$"{payroll:C2}",18}");

Invoice invoice1 = new Invoice()
{
    Description = "iPhone 13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
};
Invoice invoice2 = new Invoice()
{
    Description = "Posta Preum",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F
};
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);


