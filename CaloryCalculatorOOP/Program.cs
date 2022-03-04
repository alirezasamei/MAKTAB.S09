
List<Person?> people = new List<Person?>();

Person? currentPerson=null;

if (currentPerson == null)
{
    Console.Write("Are you Registered In Application? (Y/N)");
    var registerStatus = Console.ReadKey();
    if (registerStatus.Key == ConsoleKey.Y)
    {
        Login();

    }
    else
    {
        Register();
    }
}
else
{
    Actions();

}




void Register()
{
    
    Console.WriteLine();
    Console.Write("Please Enter Your Name : ");
    var name = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Please Enter Your Gender : ");
    var gender = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Please Enter Your Age : ");
    var age =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Please Enter Your Height : ");
    var height = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Please Enter Your Weight : ");
    var weight = Convert.ToInt32(Console.ReadLine());

    Person newPerson = new Person(name, age, height, weight, gender.ToLower() == "male" ? GenderEnum.Male : GenderEnum.Female);
    currentPerson = newPerson;
    people.Add(newPerson);
    Actions();

}
void LogOff()
{
    currentPerson = null;
    Console.Clear();
    Login();
}
void Login()
{
    Console.WriteLine();
    Console.Write("Please Enter Your Name: ");
    var currentUserName = Console.ReadLine();
    bool isExist = false;
    foreach (var item in people)
    {
        if (item.Name.ToLower() == currentUserName.ToLower())
        {
            currentPerson = item;
            isExist = true;
        }
    }
    if (!isExist)
    {
        Console.WriteLine();
        Console.Write("This Name Dose Not Exist , do yoy want to try again (Y/N):");
        var tryStatus = Console.ReadKey();
        if (tryStatus.Key == ConsoleKey.Y)
            Login();
        else
            Register();
    }
}
void Eat()
{
    Console.WriteLine();
    Console.WriteLine("B - Bread  (35  calory)");
    Console.WriteLine("E - Egg    (74  calory)");
    Console.WriteLine("M - Milk   (146 calory)");
    Console.WriteLine("C - Cheese (150 calory)");
    Console.WriteLine("R - Rice   (400 calory)");
    Console.WriteLine("K - Kebab  (268 calory)");
    Console.Write("Select Your Food :");
    var selectedFood =Console.ReadKey();
    FoodEnum food = FoodEnum.Bread;
    switch (selectedFood.Key)
    {   case ConsoleKey.B:
            food = FoodEnum.Bread;
            break;
        case ConsoleKey.E:
            food = FoodEnum.Egg;
            break;
        case ConsoleKey.M:
            food = FoodEnum.Milk;
            break;
        case ConsoleKey.C:
            food = FoodEnum.Cheese;
            break;
        case ConsoleKey.R:
            food = FoodEnum.Rice;
            break;
        case ConsoleKey.K:
            food = FoodEnum.Kebab;
            break;
    }
    Console.WriteLine();
    Console.Write("How many you want :");
    var count = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine(currentPerson.Eat(food, count));
    Actions();
}
void FoodReport()
{
    Console.WriteLine();
    Console.WriteLine($"{FoodEnum.Bread} ({(int)FoodEnum.Bread} Calory) --- Inventory={Refrigerator.breadCount}");
    Console.WriteLine($"{FoodEnum.Egg} ({(int)FoodEnum.Egg} Calory) --- Inventory={Refrigerator.EggCount}");
    Console.WriteLine($"{FoodEnum.Milk} ({(int)FoodEnum.Milk} Calory) --- Inventory={Refrigerator.MilkCount}");
    Console.WriteLine($"{FoodEnum.Cheese} ({(int)FoodEnum.Cheese} Calory) --- Inventory={Refrigerator.CheeseCount}");
    Console.WriteLine($"{FoodEnum.Rice} ({(int)FoodEnum.Rice} Calory) --- Inventory={Refrigerator.RiceCount}");
    Console.WriteLine($"{FoodEnum.Kebab} ({(int)FoodEnum.Kebab} Calory) --- Inventory={Refrigerator.KebabCount}");
    Actions();
}
void Actions()
{
    Console.WriteLine();
    Console.WriteLine("O - Open Refrigerator");
    Console.WriteLine("C - Close Refrigerator");
    Console.WriteLine("R - View Report Of Your Consumed Calories");
    Console.WriteLine("E - Eat Food");
    Console.WriteLine("F - View Foods Inventory and Calories");
    Console.WriteLine("L - LogOff");
    Console.Write("Please Select Action :");
    var action = Console.ReadKey();
    switch (action.Key)
    {
        case ConsoleKey.O:
            Console.WriteLine();
            Console.WriteLine(Refrigerator.Open());
            break;
        case ConsoleKey.C:
            Console.WriteLine();
            Console.WriteLine(Refrigerator.Close());
            break;
        case ConsoleKey.R:
            Console.WriteLine();
            Console.WriteLine($"Your Consumed Calories = {currentPerson.ConsumedCalories}");
            break;
        case ConsoleKey.E:
            Eat();
            break;
        case ConsoleKey.F:
            FoodReport();
            break;
        case ConsoleKey.L:
            LogOff();
            break;
    }
    Actions();  
}



