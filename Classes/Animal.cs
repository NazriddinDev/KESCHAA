namespace KESCHAA.Classes
{
    class Animal
    {
        //filed => xususiyat
        //private int age;

        //property => xossa
        // public int Age
        // {
        //     get
        //     {
        //         return age;
        //     }
        //     set
        //     {
        //         if(value > 0)
        //         {
        //             age = value;
        //         }
        //     }
        // }

        public string Name { get; set; }
        public int Age { get; set; }
        public int AgeDiffenence { get; set; }

        public Animal()
        {
            Name = "No name";
            Age = 0;
            AgeDiffenence = 0;
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Animal(
             string name,
             int userAge,
             int animalAge)
        {
            Name = name;
            Age = animalAge;
            CalculateAgeDifferenceWithNoReturn(userAge, animalAge);
        }

        public void PrintAgeDifferent()
        {
            Console.WriteLine($"The difference between your and {Name}'s age is {AgeDiffenence}");
        }

        public void CompareAges(int userAge)
        {
            if(userAge > Age)
            {
                System.Console.WriteLine(" You are older !");
            }
            else if(userAge == Age)
            {
                System.Console.WriteLine("You are equal !");
            }
            else
            {
                System.Console.WriteLine("You are younger !");
            }
        }

        public void TellAboutFriends(string userName, int userAge)
        {
            System.Console.WriteLine("Let me tell you about my friends.");
            string[] friendsName = new string[3];
            friendsName[0] = "Kase";
            friendsName[1] = "Nasya";
            friendsName[2] = userName;
            int[] friendsAge = {1, 2, userAge};


            for(int iteration = 0; iteration < friendsName.Length; iteration++)
            {
                System.Console.WriteLine($"{friendsName[iteration]} is {friendsAge[iteration]} year old !");
            }
        }


        public void CalculateAgeDifferenceWithNoReturn(int userAge)
        {
            AgeDiffenence =  userAge - Age;
        }


        public int CalculateAgeDifference(int userAge, int animalAge)
        {
            return userAge - animalAge;
        }

        public void Greet(string userName)
        {
            if(userName == "")
            {
                userName = "Unknown Person";
            }

            System.Console.WriteLine($"Hello, {userName}");
        }

        private void CalculateAgeDifferenceWithNoReturn(int userAge, int animalAge)
        {
            AgeDiffenence = userAge - animalAge;
        }


    }
}