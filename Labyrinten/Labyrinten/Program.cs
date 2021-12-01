using System;


string room = "house";
string postravel1 = "livingroom";
string postravel2 = "upstairs";
string travelback = "start";

while (room != "Bed")
{
    System.Console.WriteLine($"You are in the " + room + "." + " Where do you go?");
    System.Console.WriteLine(postravel1);
    System.Console.WriteLine(postravel2);
    System.Console.WriteLine(travelback);

    string travel = Console.ReadLine().ToLower();
    if (travel == "upstairs")
    {
        System.Console.WriteLine("You walk up along the stairs squeaking by every step.");
        System.Console.WriteLine("");
        room = "corridor upstairs";
        postravel1 = "bedroom";
        postravel2 = "wc";
    }

    if (travel == "livingroom")
    {
        System.Console.WriteLine("");
        room = "livingroom";
        postravel1 = "laundryroom";
        postravel2 = "kitchen";
    }


    if (travel == "start")
    {
        System.Console.WriteLine("You walk back to the start to regain you sense of orientation.");
        System.Console.WriteLine("");
        room = "house";
        postravel1 = "livingroom";
        postravel2 = "upstairs";
    }

    if (travel != postravel1 || travel != postravel2 || travel != travelback)
    {
        System.Console.WriteLine("You can't walk there from your position");
        System.Console.WriteLine("");
    }

}