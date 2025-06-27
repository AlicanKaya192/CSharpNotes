using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlistirma
{
    internal class Program
    {
        static List<Vehicle> vehicleList = new List<Vehicle>();

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Vehicle Menu");
                Console.WriteLine("----------");
                Console.WriteLine("1 - Show Vehicles");
                Console.WriteLine("2 - Add Vehicle");
                Console.WriteLine("3 - Remove Vehicle");
                Console.WriteLine("4 - Exit");

                Console.WriteLine("----------");
                Console.Write("Your Choise : ");
                string menuSecenek = Console.ReadLine();

                switch (menuSecenek)
                {
                    case "1":
                        ShowVehicles();
                        break;
                    case "2":
                        AracEkle();
                        break;
                    case "3":
                        AracCikar();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            } while (true);
        }

        static void ShowVehicles()
        {
            if (vehicleList.Count == 0)
            {
                Console.WriteLine("There are no registered vehicles.");
            }
            else
            {
                foreach (var arac in vehicleList)
                {
                    Console.WriteLine($"Marka: {arac.Marka}, Model: {arac.Model}, Year: {arac.ModelYil}, Km: {arac.Km}");
                }
            }
            Console.WriteLine();
        }

        static void AracEkle()
        {
            Console.WriteLine("To add the vehicle, enter Brand, Model, Year and Km respectively: ");
            Console.Write("Brand: ");
            string marka = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Year: ");
            int yil = int.Parse(Console.ReadLine());
            Console.Write("Km: ");
            int km = int.Parse(Console.ReadLine());

            Vehicle yeniArac = new Vehicle(marka, model, yil, km);
            vehicleList.Add(yeniArac);
            Console.WriteLine("The car has been added successfully.");
            Console.WriteLine();
        }

        static void AracCikar()
        {
            Console.WriteLine("Enter the Brand and Model information of the vehicle you want to remove: ");
            Console.Write("Brand: ");
            string marka = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();

            Vehicle findVehicle = vehicleList.Find(arac => arac.Marka == marka && arac.Model == model);

            if (findVehicle != null)
            {
                vehicleList.Remove(findVehicle);
                Console.WriteLine("The vehicle was successfully removed.");
            }
            else
            {
                Console.WriteLine("The specified vehicle was not found.");
            }
            Console.WriteLine();
        }
    }

    public class Vehicle
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int ModelYil { get; set; }
        public int Km { get; set; }

        public Vehicle() { }

        public Vehicle(string marka, string model)
        {
            Marka = marka;
            Model = model;
        }

        public Vehicle(string marka, string model, int modelYil)
        {
            Marka = marka;
            Model = model;
            ModelYil = modelYil;
        }

        public Vehicle(string marka, string model, int modelYil, int km)
        {
            Marka = marka;
            Model = model;
            ModelYil = modelYil;
            Km = km;
        }
    }
}
