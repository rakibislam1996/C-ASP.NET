using System;

namespace CovarianceDelegates
{
    public abstract class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual string GetCarDetails()
        {
            return $"{Id} - {Name}";
        }
    }

    public class RacingCar : Car
    {
        public override string GetCarDetails()
        {
            return $"{base.GetCarDetails()} : This is a sports car";
        }
    }
    public class Sedan : Car
    {
        public override string GetCarDetails()
        {
            return $"{base.GetCarDetails()} : This is a sedan";
        }
    }

    public static class CarFactory
    {
        public static RacingCar ReturnRacingCar(int id, string name)
        {
            return new RacingCar { Id = id, Name = name };
        }
        public static Sedan ReturnSedan(int id, string name)
        {
            return new Sedan { Id = id, Name = name };
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Func<int,string,Car> carFactory = CarFactory.ReturnRacingCar;
            Car racing = carFactory(1, "Nissan GT-R");

            Console.WriteLine(racing.GetType());
            Console.WriteLine(racing.GetCarDetails());

            carFactory = CarFactory.ReturnSedan;
            Car sedan = carFactory(2, "Toyota Allion");

            Console.WriteLine(sedan.GetType());
            Console.WriteLine(sedan.GetCarDetails());

            Action<Sedan> action = ParkCar;
            
            action(sedan as Sedan);
            
            action(new Sedan()
            {
                Id = 3,
                Name = "Mitshubishi Lancer"
            });
        }
        static void ParkCar(Car car)
        {

        }
    }
}
