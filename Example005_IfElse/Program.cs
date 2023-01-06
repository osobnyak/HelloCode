Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это де МАША!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}