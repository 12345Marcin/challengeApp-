string name = "Marcin";
char sex = 'm';
int age = 33;

if (sex == 'K' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa,lat30");
}
else if (sex == 'm' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
