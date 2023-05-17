// See https://aka.ms/new-console-template for more information

var passwordList = new List<string>();
var random = new Random();
const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

while (passwordList.Count() < 150)
{
    var password = new string(Enumerable.Repeat(characters, 4)
        .Select(s => s[random.Next(s.Length)]).ToArray());

    if (!passwordList.Contains(password))
    {
        passwordList.Add(password);
    }
}

foreach (var password in passwordList)
{
    Console.WriteLine(password);
}
Console.ReadLine();