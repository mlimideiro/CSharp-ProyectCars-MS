using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace ProjectCars
{
    public class CarCRUD
    {
        private static string _path = @"C:\Json Store\Cars.json"; //I´m going to change this

        public static List<Car> GetCars()
        {
            List<Car> cars = new List<Car>
            {
                new Car
                {
                    Id = "AA0456AA",
                    Model = "Fiat",
                    DoorsQuantity = 5,
                    Color = "Verde",
                    IsManualTransmission = true
                },

                new Car
                {
                    Id = "BB0156VV",
                    Model = "Peugeot",
                    DoorsQuantity = 3,
                    Color = "Azul",
                    IsManualTransmission = true
                },
            };

            return cars;
        }


        public Car Create(Car car)
        {
            var cars = getCarsJsonFromFile();
            var carsList = DeserealizeJsonFile(cars);
            carsList.Add(car);
            SerializeJsonFile(carsList);
            //string carStr = car.ToString();
            //File.AppendAllText(_path, carStr);
            return car;
        }

        public Car Get(string Id)
        {
            var cars = getCarsJsonFromFile();
            var carsList = DeserealizeJsonFile(cars);
            foreach (var car in carsList)
            {
                if (car.Id == Id)
                {
                    return car;
                }
            }
            return null;
        }

        public Car Update(Car carUpd)
        {
            var actualized = false;
            var cars = getCarsJsonFromFile();
            var carsList = DeserealizeJsonFile(cars);
            foreach (var car in carsList)
            {
                if (car.Id == carUpd.Id)
                {
                    car.Model = carUpd.Model;
                    car.DoorsQuantity = carUpd.DoorsQuantity;
                    car.Color = carUpd.Color;
                    car.IsManualTransmission = carUpd.IsManualTransmission;
                    actualized = true;
                }
            }

            if (actualized)
            {
                SerializeJsonFile(carsList);
                return carUpd;
            }
            else
            {
                return null;
            }
        }

        public void Delete(string Id)
        {
            var cars = getCarsJsonFromFile();
            var carsList = DeserealizeJsonFile(cars);
            var itemToRemove = carsList.Single(car => car.Id == Id);
            carsList.Remove(itemToRemove);
            SerializeJsonFile(carsList);
            }

        public static string getCarsJsonFromFile()
        {
            string carsJsonForFile;
            using (var reader = new StreamReader(_path))
            {
                carsJsonForFile = reader.ReadToEnd();
            }
            return carsJsonForFile;
        }

        public static void SerializeJsonFile(List<Car> cars)
        {
            string carJson = JsonConvert.SerializeObject(cars.ToArray(), Formatting.Indented);
            File.WriteAllText(_path, carJson);
        }


        public static List<Car> DeserealizeJsonFile(string carsJson)
        {
            var cars = JsonConvert.DeserializeObject<List<Car>>(carsJson);
            return cars;
        }
    }
}
