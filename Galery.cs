using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classandİDtask
{
      public class Galery
    {
        public  int Id;
        public string Name { get; set; }

       public Car[] cars;
        public int count { get; set; }

        
        public Galery(int capacity)
        {
            cars=new Car[capacity];
            count = 0;
        }
        public void AddCar(Car car)
        {
            if (count >= cars.Length)
            {
                Array.Resize(ref cars, cars.Length+1);
            }
            cars[count++]=car;
        }

        public void ShowAllCars()
        {
            for(int i = 0;i< count; i++)
            {
                Car car = cars[i];
                Console.WriteLine($"id:{car.Id}, Name:{car.Name},Speed:{car.Speed},CarCode:{car.CarCode}");
            }
        }
        public Car[] GetAllCars()
        {
            Car[] allcars = new Car[count];
            for (int i = 0; i < count; i++)
            {
                allcars[i] = cars[i];
            }return allcars;
            
        }
        public Car FindCarById(int id)
        {

            for(int i = 0; i < count; i++)
            {
                if (cars[i].Id == id)
                {
                    return cars[i];
                }
            }
            return null;
        }
        public Car FindCarByCarCode(string carcode)
        {
            for(int i=0; i<count; i++)
            {
                if (cars[i].CarCode == carcode)
                {
                    return cars[i];
                }
            }return null;
        }
        public Car[] FindCarsBySpeedInterval(int minSpeed, int maxSpeed)
        {
            Car[] carsInSpeedRange = new Car[count];
            int index = 0;
            for (int i = 0; i < count; i++)
            {
                if (cars[i].Speed >= minSpeed && cars[i].Speed <= maxSpeed)
                {
                    carsInSpeedRange[index++] = cars[i];
                }
            }
            Array.Resize(ref carsInSpeedRange, index);
            return carsInSpeedRange;
        }
    }
}
