// See https://aka.ms/new-console-template for more information
using ConceptosPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");
// Date date1 = new Date(2022, 2, 11);

try
{
    Console.WriteLine(new Date(2024, 2, 29)); // Biciesto Correcto
    //Console.WriteLine(new Date(2022, 2, 29)); // Biciesto Incorrecto
    Console.WriteLine(new Date(2022, 12, 7)); // 2022 / 12 / 07
    Console.WriteLine(new Date(1974, 9, 23)); // 1974 / 09 / 23
    //Console.WriteLine(new Date(1985, 18, 45)); // Invalid month
    // Console.WriteLine(new Date(1985, 11, 45));   // Invalid day
    Console.WriteLine(new Date(1974, 11, 23)); // 1974 / 09 / 23
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}

