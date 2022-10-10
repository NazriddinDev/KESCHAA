Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
string greeting = $"Hello, {name}";
System.Console.WriteLine(greeting);
System.Console.WriteLine("Entr your age: ");
string ageAsString =Console.ReadLine();
System.Console.WriteLine("Converting...");
int age =Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Successfully converted ! {age}");


int keschaAge=5;
int ageDifference = age - keschaAge;
System.Console.WriteLine($"The difference between your and Kescha's age is {ageDifference}");
