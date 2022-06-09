using System.Text;

Dictionary<int, string> InitializeCarPark(int capacity)
{
    Dictionary<int, string> carPark = new Dictionary<int, string>();
    
    for(int i = 0; i < capacity; i++)
    {
        carPark.Add(i, null);
    }
    return carPark; 
}

Dictionary<int, string> newCarPark = InitializeCarPark(6); // To Create a Car pack with 5 stalls.







    int AddVehicle(Dictionary<int, string> carPark, string licence) // To register a car to an empty stall.
{
    
        foreach (KeyValuePair<int, string> pair in carPark)

    {
        if (licence.Length == 7 && licence[3] == '-')
        {
            if (pair.Value == null)
            {
                carPark[pair.Key] = licence;
                return pair.Key;
                break;
            }


        }
    }
           
    return -1;
}

AddVehicle(newCarPark, "AAA-VVV");
AddVehicle(newCarPark, "ADA-IVV");
AddVehicle(newCarPark, "AAA-XVV");
AddVehicle(newCarPark, "ACA-VVI");
AddVehicle(newCarPark, "AAA-721");
AddVehicle(newCarPark, "XB-721"); // Invalid license number that wont be added to the CarPark.

Console.WriteLine("QUESTION 2");

foreach (KeyValuePair<int, string> pair in newCarPark)
{
    Console.WriteLine($"{pair.Key}:{pair.Value}");
}






bool VacateStall(Dictionary<int, string> carPark, int stallNumber) // To remove a car from a car park with the stall number.
{
    bool isAvailable = false;
    foreach (KeyValuePair<int, string> pair in carPark)
    {
        if (pair.Value != null)
        {
            carPark[stallNumber] = null;
            return isAvailable = true;
        }
    }
    return isAvailable;

}

VacateStall(newCarPark, 0);
VacateStall(newCarPark, 1);


Console.WriteLine("\nQUESTION 3");

foreach (KeyValuePair<int, string> pair in newCarPark)
{
    Console.WriteLine($"{pair.Key}:{pair.Value}");
}


bool LeaveParkade(Dictionary<int, string> carPark, string licenceNumber) // To remove a car from stall in the car park with the licenseNumber.
{
    bool isAvailable = false;
    foreach (KeyValuePair<int, string> pair in carPark)
    {      
        if(pair.Value == licenceNumber)
        {
            carPark[pair.Key] = null;
            return isAvailable = true;
        }
    }
    return isAvailable;
    
}


LeaveParkade(newCarPark, "ACA-VVI");

Console.WriteLine("\nQUESTION 4");

foreach (KeyValuePair<int, string> pair in newCarPark)
{
    Console.WriteLine($"{pair.Key}:{pair.Value}");
}




string Manifest(Dictionary<int, string> carPack) // To print out the stalls and vehicle each stall in the car park.
{
    StringBuilder sb = new StringBuilder();
    foreach(KeyValuePair<int, string> pair in carPack)
    {
        sb.Append($"\n{pair.Key}: {pair.Value}");
    }  
    return sb.ToString();   
}

Console.WriteLine("\nQUESTION 5");

Console.WriteLine(Manifest(newCarPark));


