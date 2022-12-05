Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.Write("Ур, это же МАША!");
}
else
{
    Console.Write("Ну привет, ");
    Console.Write(username);
    Console.Write("...");
}