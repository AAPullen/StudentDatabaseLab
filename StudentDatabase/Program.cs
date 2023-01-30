using StudentDatabase;

string[] name = new string[]
{
    "Peter Parker",
    "Bruce Wayne",
    "Ash Williams",
    "Laurie Strode",
    "Sidney Prescott",
    "Snake Plissken",
    "Alex Murphy",
    "Henry Armitage",
    "Rick Deckard",
    "Joeseph Dredd"
};

string[] hometown = new string[]
{
    "New York City",
    "Gotham",
    "Elk Grove",
    "Haddonfield",
    "Woodsboro",
    "Cleveland",
    "Detroit",
    "Arkham",
    "Los Angeles",
    "Mega-City One"
};

string[] favoriteFood = new string[]
{
    "Pizza",
    "Nachos",
    "Churros",
    "Pumpkin Pie",
    "Popcorn",
    "Beef Jerky",
    "Coney Dog",
    "Roast Beef",
    "Noodles",
    "Recycled Food"
};

Console.Write("Welcome! ");

bool loop = true;
do
{
    string answer = null;
    bool isValidAnswer = false;
    do
    { 
        Console.Write("Would you like to see a list of our students?\n" +
           "Enter \"y\" for yes or \"n\" for no: ");

        answer = Console.ReadLine().ToLower().Trim();

        isValidAnswer = StudentDatabaseClass.isValidAnswer(answer);

        if (isValidAnswer == false)
        {
            Console.WriteLine("\nI'm sorry, that is not a valid response.\n");
        }

    } while (isValidAnswer == false);

    if (answer == "y")
    {
    Console.WriteLine();
        for (int i = 0; i < name.Length; i++)
        {
        Console.WriteLine($"{i + 1} {name[i]}");
        }
    Console.WriteLine();
}
else
{
    Console.WriteLine("\nAlright.\n");
}

Console.Write("Which student would you like to know more about?\n" +
        $"Enter the student's name or a number from 1-{name.Length}: ");

    string userStudent = Console.ReadLine().ToLower().Trim();
    userStudent = StudentDatabaseClass.CheckName(userStudent);


    if (int.TryParse(userStudent, out int student))
    {
        bool isValidStudent = StudentDatabaseClass.IsValidStudent(student, name.Length);

        if (isValidStudent == true) 
        {
            int index = student - 1;
            string category;
            bool isValidCategory = false;
            do
            {
                Console.Write($"\nStudent {student} is {name[index]}. What would you Like to know?\n" +
                    $"Enter \"hometown\" or \"favorite food\": ");
                category = Console.ReadLine().ToLower().Trim();

                isValidCategory = StudentDatabaseClass.IsValidCategory(category);

                if (isValidCategory == false)
                {
                    Console.WriteLine("\nI'm sorry, that is not a valid answer.\n");
                }
            }while (isValidCategory == false);

            
            if (category == "home" || category == "town" || category == "hometown")
            {
                Console.WriteLine($"\n{name[index]} is from {hometown[index]}\n");
            }
            else
            {
                Console.WriteLine($"\n{name[index]}'s favorite food is {favoriteFood[index]}\n");
            }

            do
            {
                Console.Write("Would you like to know about another student?\n" +
                        "Enter \"y\" for yes or \"n\" for no: ");

                answer = Console.ReadLine().ToLower().Trim();

                isValidAnswer = StudentDatabaseClass.isValidAnswer(answer);

                if (isValidAnswer == false)
                {
                    Console.WriteLine("\nI'm sorry, that is not a valid response.\n");
                }

            } while (isValidAnswer == false);

            if (answer == "y")
            {
                Console.WriteLine("\nOkay.\n");
            }
            else
            {
                Console.WriteLine("\nOkay. Thanks for using our student database.\n" +
                    "Have a great day!");

                loop = false;
            }
        }
        else
        {
            Console.WriteLine("\nI'm Sorry, that is not a valid selection\n");
        }
    }
    else
    {
        Console.WriteLine("\nI'm sorry, that is not a valid selection\n");
    }

} while (loop == true);