//Display 8 items and prices
Dictionary<string, double> menuPrices = new Dictionary<string, double>();
menuPrices.Add("Asparagus", 2.50);
menuPrices.Add("Radish", 0.50);
menuPrices.Add("Spinach", 1.00);
menuPrices.Add("Peas", 0.75);
menuPrices.Add("Olive Oil", 5.00);
menuPrices.Add("Lemon", 1.00);
menuPrices.Add("Feta Cheese", 3.50);
menuPrices.Add("Onion", 2.00);

Console.WriteLine(string.Format("\n{0,20}, {1,30}", "Product", "Price"));
Console.WriteLine(string.Format("\n{0,20}, {1,30}", "=====", "====="));

    foreach (KeyValuePair<string, double> kvp in menuPrices)
    {
        Console.WriteLine(string.Format ("{0,20} {1,30}", kvp.Key, kvp.Value));
    }



//Ask user to enter item name
List<string> order = new List<string>();
//bool runProgram = true;
//while(runProgram == true)

    Console.WriteLine("\n" + "Please enter an item you'd want");
    string result = Console.ReadLine();

    if (menuPrices.ContainsKey(result))
    {
        order.Add(result);
    }

    else
    {
        Console.WriteLine("Item does nopt exist");
    }

