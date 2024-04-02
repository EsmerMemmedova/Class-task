namespace classandİDtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Galery galery = new Galery(21); 

           
            Car car1 = new Car(1001, "RR", 320);
            Car car2 = new Car(1002, "Buggatti", 300);
            Car car3 = new Car(1003, "BMW", 200);
            Car car4 = new Car(1004, "Toyota", 230);
            Car car5= new Car(1005, "Mercedes", 280);
            
            galery.AddCar(car1);
            galery.AddCar(car2);
            galery.AddCar(car3);
            galery.AddCar(car4);
            galery.AddCar(car5);

            bool exit = false;
            do
            {
                Console.WriteLine("\n1. Butun masinlari goster");
                Console.WriteLine("2. Id ye uygun masin tap");
                Console.WriteLine("3. CarCode a uygun masin tap");
                Console.WriteLine("4. Verilen suret intervalinda masin tap");
                Console.WriteLine("5. Cixis");
                Console.Write("Secim edin (1-5): ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\nButun masinlar:");
                            galery.ShowAllCars();
                            break;
                        case 2:
                            Console.Write("\nId daxil edin: ");
                            int id = int.Parse(Console.ReadLine());
                            Car foundCarById = galery.FindCarById(id);
                            if (foundCarById != null)
                                Console.WriteLine($"Id: {foundCarById.Id}, Name: {foundCarById.Name}, Speed: {foundCarById.Speed}, CarCode: {foundCarById.CarCode}");
                            else
                                Console.WriteLine("Masin tapilmadi");
                            break;
                        case 3:
                            Console.Write("\nCarCode daxil edin: ");
                            string carCode = Console.ReadLine();
                            Car foundCarByCode = galery.FindCarByCarCode(carCode);
                            if (foundCarByCode != null)
                                Console.WriteLine($"Id: {foundCarByCode.Id}, Name: {foundCarByCode.Name}, Speed: {foundCarByCode.Speed}, CarCode: {foundCarByCode.CarCode}");
                            else
                                Console.WriteLine("Masin tapilmadi");
                            break;
                        case 4:
                            Console.Write("\nMinimum suret daxil edin: ");
                            int minSpeed = int.Parse(Console.ReadLine());
                            Console.Write("Maximum suret daxil edin: ");
                            int maxSpeed = int.Parse(Console.ReadLine());
                            Car[] carsInSpeedRange = galery.FindCarsBySpeedInterval(minSpeed, maxSpeed);
                            if (carsInSpeedRange.Length > 0)
                            {
                                Console.WriteLine("\nVerilen suret intervalinda masinlar:");
                                foreach (var car in carsInSpeedRange)
                                {
                                    Console.WriteLine($"Id: {car.Id}, Name: {car.Name}, Speed: {car.Speed}, CarCode: {car.CarCode}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Axtarilan surete uygun masin tapilmadi.");
                            }
                            break;
                        case 5:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Duzgun secim edin!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Duzgun secim edin!");
                }
            } while (!exit);
        }

        
    }
    }

