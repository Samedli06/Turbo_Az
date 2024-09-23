using Turbo_Az;



TruckController truckController = new TruckController();
CarController carController = new CarController();
BikeController bikeController = new BikeController();
UserController userController = new UserController();



while (true)
{
    Console.WriteLine("=== User Authentication ===");
    Console.WriteLine("1. Sign In");
    Console.WriteLine("2. Sign Up");
    Console.WriteLine("3. Continue as Guest");
    Console.Write("Select an option: ");

    string authChoice = Console.ReadLine();
    Console.Clear();

    switch (authChoice)
    {
        case "1":
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            userController.signin(email, password);
            break;

        case "2":
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter user surname: ");
            string usersurname = Console.ReadLine();
            Console.Write("Enter email: ");
            string emailup = Console.ReadLine();
            Console.Write("Enter password: ");
            string passwordup = Console.ReadLine();
            userController.signup(username, usersurname, emailup, passwordup);
            break;

        case "3":
            Console.WriteLine("Welcome as a guest");
            break;

        default:
            Console.WriteLine("Incorrect option, try again!");
            continue; 
    }
    break; 
}


while (true)
{
    Console.WriteLine("=== Vehicle Management System ===");
    Console.WriteLine("1. Add Truck");
    Console.WriteLine("2. Add Car");
    Console.WriteLine("3. Add Bike");
    Console.WriteLine("4. Show All Trucks");
    Console.WriteLine("5. Show All Cars");
    Console.WriteLine("6. Show All Bikes");
    Console.WriteLine("7. Search Trucks by Price");
    Console.WriteLine("8. Search Cars by Price");
    Console.WriteLine("9. Search Bikes by Price");
    Console.WriteLine("10. Search by model");
    Console.WriteLine("11. Search by km");
    Console.WriteLine("0. Exit");
    Console.Write("Select an option: ");

    string choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":
            truckController.AddVehicle();
            break;
        case "2":
            carController.AddVehicle();
            break;
        case "3":
            bikeController.AddVehicle();
            break;
        case "4":
            truckController.ShowVehicles();
            break;
        case "5":
            carController.ShowVehicles();
            break;
        case "6":
            bikeController.ShowVehicles();
            break;
        case "7":
            Console.Write("Enter price to search: ");
            double truckPrice = Convert.ToDouble(Console.ReadLine());
            truckController.SearchByPrice(truckPrice);
            break;
        case "8":
            Console.Write("Enter price to search: ");
            double carPrice = Convert.ToDouble(Console.ReadLine());
            carController.SearchByPrice(carPrice);
            break;
        case "9":
            Console.Write("Enter price to search: ");
            double bikePrice = Convert.ToDouble(Console.ReadLine());
            bikeController.SearchByPrice(bikePrice);
            break;
        case "10":
            Console.WriteLine("Choose vehicle:\n1.Car\n2.Bike\n3.Truck");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter model: ");
                    string modelcar = Console.ReadLine();
                    carController.SearchByModel(modelcar);
                    break;
                case "2":
                    Console.Write("Enter model: ");
                    string modelbike = Console.ReadLine();
                    carController.SearchByModel(modelbike);
                    break;
                case "3":
                    Console.Write("Enter model: ");
                    string modeltruck = Console.ReadLine();
                    carController.SearchByModel(modeltruck);
                    break;
                default:
                    break;
            }
            break;

        case "11":
            Console.WriteLine("Choose vehicle:\n1.Car\n2.Bike\n3.Truck");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter km: ");
                    double kmcar = Convert.ToDouble(Console.ReadLine());
                    carController.SearchByKm(kmcar);
                    break;
                case "2":
                    Console.Write("Enter km: ");
                    double kmbike = Convert.ToDouble(Console.ReadLine());
                    carController.SearchByKm(kmbike);
                    break;
                case "3":
                    Console.Write("Enter km: ");
                    double kmtruck = Convert.ToDouble(Console.ReadLine());
                    carController.SearchByKm(kmtruck);
                    break;
                default:
                    break;
            }
            break;
        case "0":
            Console.WriteLine("Exiting the application...");
            return;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
    Console.Clear();
}
