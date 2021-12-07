using System;


string room = "house";
string postravel1 = "livingroom";
string postravel2 = "upstairs";
string travelback = "start";

while (room != "bed" && room != "hell")
{
    System.Console.WriteLine($"You are in the " + room + "." + " Where do you go?");
    System.Console.WriteLine(postravel1);
    System.Console.WriteLine(postravel2);
    System.Console.WriteLine(travelback);

    string travel = Console.ReadLine().ToLower();


    if (travel != postravel1 && travel != postravel2 && travel != travelback)
    {
        System.Console.WriteLine("You can't walk there from your position");
        System.Console.WriteLine("");
    }

    if (room == "house" && travel == "upstairs")
    {
        System.Console.WriteLine("You walk up along the stairs squeaking by every step.");
        System.Console.WriteLine("");
        room = "corridor upstairs";
        postravel1 = "bedroom";
        postravel2 = "wc";
    }

    if (travel == "bedroom" && room == "corridor upstairs")
    {
        System.Console.WriteLine("");
        room = "bedroom";
        postravel1 = "go to bed";
        postravel2 = "corridor";
    }
    if (travel == "go to bed" && room == "bedroom")
    {
        System.Console.WriteLine("You fall asleep");
        room = "bed";
    }


    if (travel == "corridor" && room == "bedroom" || travel == "corridor" && room == "wc")
    {
        System.Console.WriteLine("");
        room = "corridor upstairs";
        postravel1 = "bedroom";
        postravel2 = "wc";
    }

    if (travel == "wc" && room == "corridor upstairs")
    {
        System.Console.WriteLine("");
        room = "wc";
        postravel1 = "corridor";
        postravel2 = "commit sepuko";
    }

    if (travel == "commit sepuko" && room == "wc")
    {
        System.Console.WriteLine("");
        System.Console.WriteLine("You died and will not be remembered");
        room = "hell";
    }

    if (room == "house" && travel == "livingroom" || room == "kitchen" && travel == "livingroom" || room == "laundryroom" && travel == "livingroom")
    {
        System.Console.WriteLine("");
        room = "livingroom";
        postravel1 = "laundryroom";
        postravel2 = "kitchen";
    }

    if (room == "livingroom" && travel == "kitchen" || room == "breadceller" && travel == "kitchen")
    {
        System.Console.WriteLine("");
        room = "kitchen";
        postravel1 = "breadceller";
        postravel2 = "livingroom";
    }

    if (travel == "breadceller" && room == "kitchen")
    {
        System.Console.WriteLine("");
        room = "breadceller";
        postravel1 = "kitchen";
        postravel2 = "none";
    }

    if (room == "livingroom" && travel == "laundryroom")
    {
        System.Console.WriteLine("");
        room = "laundryroom";
        postravel1 = "livingroom";
        postravel2 = "none";
    }


    if (travel == "start")
    {
        System.Console.WriteLine("You walk back to the start to regain you sense of orientation.");
        System.Console.WriteLine("");
        room = "house";
        postravel1 = "livingroom";
        postravel2 = "upstairs";
    }
}

if (room == "bed")
{
    System.Console.WriteLine("");
    System.Console.WriteLine("You live to die another day");
}

if (room == "hell")
{
    System.Console.WriteLine("");
    System.Console.WriteLine("Wuss");
}
Console.ReadLine();