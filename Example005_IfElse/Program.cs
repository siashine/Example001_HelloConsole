Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "анастасия")
{
  Console.WriteLine("Ура, это же Настя!");
}
else 
{
  Console.Write("Привет, ");
  Console.WriteLine(username);
}
