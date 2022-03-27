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

Console.WriteLine(employee1);

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

Console.WriteLine(employee2);

