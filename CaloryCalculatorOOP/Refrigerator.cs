public static class Refrigerator
{
    public static int breadCount { get; private set; } = 10;
    public static int EggCount { get; private set; } = 10;
    public static int MilkCount { get; private set; } = 10;
    public static int CheeseCount { get; private set; } = 10;
    public static int RiceCount { get; private set; } = 10;
    public static int KebabCount { get; private set; } = 10;
    private static bool IsOpen { get; set; } = false;

    public static string Open()
    {
        if (!IsOpen)
        {
            IsOpen = true;
            return "Refrigerator Opened.";
        }
        else
        {
            return "Refrigerator Already Is Open";
        }
    }
    public static string Close()
    {
        if (IsOpen)
        {
            IsOpen = false;
            return "Refrigerator Closed.";
        }
        else
        {
            return "Refrigerator Already Is Close";
        }
        
    }
    public static String Pick(FoodEnum food , int count)
    {
        if (!IsOpen)
            return "Refrigerator Is Closed.";

        switch (food)
        {
            case FoodEnum.Bread:
                if (breadCount< count)
                {
                    return "There is not enough bread in the refrigerator.";
                }
                else
                {
                    breadCount = breadCount - count;
                    return "OK";
                }
            case FoodEnum.Egg:
                if (EggCount < count)
                {
                    return "There is not enough egg in the refrigerator.";
                }
                else
                {
                    EggCount = EggCount - count;
                    return "OK";
                }
            case FoodEnum.Milk:
                if (MilkCount < count)
                {
                    return "There is not enough milk in the refrigerator.";
                }
                else
                {
                    MilkCount = MilkCount - count;
                    return "OK";
                }
            case FoodEnum.Cheese:
                if (CheeseCount < count)
                {
                    return "There is not enough cheese in the refrigerator.";
                }
                else
                {
                    CheeseCount = CheeseCount - count;
                    return "OK";
                }
            case FoodEnum.Rice:
                if (RiceCount < count)
                {
                    return "There is not enough rice in the refrigerator.";
                }
                else
                {
                    RiceCount = RiceCount - count;
                    return "OK";
                }
            case FoodEnum.Kebab:
                if (KebabCount < count)
                {
                    return "There is not enough kebab in the refrigerator.";
                }
                else
                {
                    KebabCount = KebabCount - count;
                    return "OK";
                }
            default:
                return "Food Not Fund.";
        }
    }
}