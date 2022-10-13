using KESCHAA.Classes;

Animal keschaa = new Animal(name: "Kescha", age: 2);

Console.WriteLine("Enter your name: ");
string userName = Console.ReadLine();
keschaa.Greet(userName);

System.Console.WriteLine("Entr your age: ");
string ageAsString =Console.ReadLine();
System.Console.WriteLine("Converting...");
int userAge =Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Successfully converted ! {userAge}");


keschaa.CalculateAgeDifferenceWithNoReturn(userAge);
keschaa.PrintAgeDifferent();
keschaa.CompareAges(userAge);
keschaa.TellAboutFriends(userName, userAge);
