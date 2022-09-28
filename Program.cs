using static System.Console;
Entrance();
//Ett menysystem med flera olika menyer som skiljer sig åt beroende på vilket rum man befinner sig i.
static void Entrance()
{
    while (true)
    {
        string abc;
        int choice;
        bool success;
        do
        {
            //Detta är första menyn. Användaren får göra ett val, sedan skickas den vidare till nästa val.
            Clear();
            DrawLine();
            //Sätt in text om vad som finns i rummet
            WriteLine("Text om vad som finns i detta rum.");
            DrawLine();
            WriteLine();
            DrawLine();
            WriteLine("Du är i Entrén");
            OptionText();
            WriteLine("1. Gå till Utställningshall Ett");
            WriteLine("2. Gå till Utställningshall Två");
            WriteLine("3. Gå till Caféet");
            DrawLine();
            WriteLine("4. Kolla på Saltskulpturer");
            WriteLine("5. Kolla på Cigarrer");
            DrawLine();
            WriteLine("6. Gå ut");
            DrawLine();
            //Kollar ifall användaren har skrivit in en siffra. Är den mellan 1-6 skicka vidare användaren, annars försök igen.
            success = int.TryParse(ReadLine(), out choice);
            Clear();
        }
        while (!success);
        //Här är de 6 olika valen.
        switch (choice)
        {
            case 1:
                ExhibitionHall1();
                break;
            case 2:
                ExhibitionHall2();
                break;
            case 3:
                Cafe();
                break;
            case 4:
                Clear();
                DrawLine();
                WriteLine("Saltskulpturer");
                DrawLine();
                //Sätt in text om saltskulpturer.
                WriteLine("Text om vad man tittar på");
                ExitText();
                ReadLine();
                Clear();
                break;
            case 5:
                Clear();
                DrawLine();
                WriteLine("Cigarrer");
                DrawLine();
                //Sätt in text om cigarrer.
                WriteLine("Text om vad man tittar på");
                ExitText();
                ReadLine();
                Clear();
                break;
            case 6:
                return;
            default:
                break;
        }
    }
}
static void ExhibitionHall1()
{
    while (true)
    {
        int choice;
        bool success;
        do
        {
            Clear();
            DrawLine();
            //Sätt in text om vad som finns i rummet
            WriteLine("Text om vad som finns i detta rum.");
            DrawLine();
            WriteLine();
            DrawLine();
            WriteLine("Du är i Utställningshall Ett");
            OptionText();
            WriteLine("1. Gå till Entrén");
            WriteLine("2. Gå till Caféet");
            DrawLine();
            WriteLine("3. Kolla på Saltvatten Dunstar Bort");
            DrawLine();
            success = int.TryParse(ReadLine(), out choice);
            Clear();
        }
        while (!success);
        switch (choice)
        {
            case 1:
                Entrance();
                break;
            case 2:
                Cafe();
                break;
            case 3:
                Clear();
                DrawLine();
                WriteLine("Saltvatten Dunstar Bort");
                DrawLine();
                //Sätt in text om saltvatten
                WriteLine("Text om vad man tittar på");
                ExitText();
                ReadLine();
                Clear();
                break;
            default:
                break;
        }
    }
}
static void ExhibitionHall2()
{
    while (true)
    {
        int choice;
        bool success;
        do
        {
            Clear();
            DrawLine();
            //Sätt in text om vad som finns i rummet
            WriteLine("Text om vad som finns i detta rum.");
            DrawLine();
            WriteLine();
            DrawLine();
            WriteLine("Du är i Utställningshall Två");
            OptionText();
            WriteLine("1. Gå till Entrén");
            DrawLine();
            WriteLine("2. Kolla på Rör");
            WriteLine("3. Kolla på Bilder på Himalayas");
            DrawLine();
            success = int.TryParse(ReadLine(), out choice);
            Clear();
        }
        while (!success);
        switch (choice)
        {
            case 1:
                Entrance();
                break;
            case 2:
                Clear();
                DrawLine();
                WriteLine("Rör");
                DrawLine();
                //Sätt in text om rör
                WriteLine("Text om vad man tittar på");
                ExitText();
                ReadLine();
                Clear();
                break;
            case 3:
                Clear();
                DrawLine();
                WriteLine("Bilder på Himalayas");
                DrawLine();
                //Sätt in text om Himalayas
                WriteLine("Text om vad man tittar på");
                ExitText();
                ReadLine();
                Clear();
                break;
            default:
                break;
        }
    }
}
static void Cafe()
{
    while (true)
    {
        int choice;
        bool success;
        do
        {
            Clear();
            DrawLine();
            //Sätt in text om vad som finns i rummet
            WriteLine("Text om vad som finns i detta rum.");
            DrawLine();
            WriteLine();
            DrawLine();
            WriteLine("Du är i Caféet");
            OptionText();
            WriteLine("1. Gå till Entrén");
            WriteLine("2. Gå till Utställningshall Ett");
            WriteLine("3. Gå till Souvenir Affären");
            DrawLine();
            success = int.TryParse(ReadLine(), out choice);
            Clear();
        }
        while (!success);
        switch (choice)
        {
            case 1:
                Entrance();
                break;
            case 2:
                ExhibitionHall1();
                break;
            case 3:
                GiftShop();
                break;
            default:
                break;
        }
    }
}
static void GiftShop()
{
    while (true)
    {
        int choice;
        bool success;
        do
        {
            Clear();
            DrawLine();
            //Sätt in text om vad som finns i rummet
            WriteLine("Text om vad som finns i detta rum.");
            DrawLine();
            WriteLine();
            DrawLine();
            WriteLine("Du är i Souvenir Affären");
            OptionText();
            WriteLine("1. Gå till Caféet");
            DrawLine();
            success = int.TryParse(ReadLine(), out choice);
            Clear();
        }
        while (!success);
        switch (choice)
        {
            case 1:
                Cafe();
                break;
            default:
                break;
        }
    }
}
static void OptionText()
{
    //Dessa texter finns på flera ställen så vi gjorde dem lättare att repetera
    WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    WriteLine("Gör ett val genom att skriva in en siffra");
    WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
}
static void DrawLine()
{
    WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
}
static void ExitText()
{
    WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    WriteLine("Tryck på ENTER för att gå bakåt");
    WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
}