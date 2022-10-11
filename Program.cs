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
System.Console.WriteLine($"You are older than KESCHAA: {ageDifference>0}");
System.Console.WriteLine($"You are younger than KESCHAA: {ageDifference<0}");
System.Console.WriteLine($"You are older or equal to KESCHAA: {ageDifference>=0}");
System.Console.WriteLine($"You are younger or equal to KESCHAA: {ageDifference<=0}");
System.Console.WriteLine($"You are equal KESCHAA's: age: {ageDifference==0}");
System.Console.WriteLine($"You are'nt equal KESCHAA's age: {ageDifference!=0}"); 