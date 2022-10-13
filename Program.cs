using KESCHAA.Classes;

string password = "";

do
{
    System.Console.WriteLine("Enter password: ");
    password=Console.ReadLine();
}while(password != "qwerty123");

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


string message =
    (userAge > 0)
        ? "your age is older 0"
        : "your age is less 0";
        System.Console.WriteLine(message);

string ex =
    (userAge > 0 || keschaa.Age > 0)
        ? "your and kescha age older 0"
        : "your and kescha age less 0";
        System.Console.WriteLine(ex);

string exe =
    !(keschaa.AgeDiffenence > 0)
        ? "ageDifference is not +"
        : "ageDifference is not -";
        System.Console.WriteLine(exe);
        

System.Console.WriteLine("Sonni kiriting");
string[] numbers = new string[10];
for(int i=0; i<numbers.Length; i++)
{
    System.Console.WriteLine(i);
}
