// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// zmienne
var name = "Ewa";
var sex = "female";
var age = 33;

if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == "female" && age < 30)
{
    Console.WriteLine("kobieta poniżej 30 lat");
}
else if (sex != "female" && age < 18)
{
    Console.WriteLine("niepełnoletni mężczyzna");
}
