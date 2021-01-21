using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //User user = new User();
            //user.FirstName = "Matthias";
            //user.LastName = "Druwé";
            //user.BirthDate = DateTime.Now;

            //Car car = new Car();
            //car.Make = "Ford";
            //car.Model = "Focus";
            //car.ChassisNumber = "123456789";

            //user.Cars.Add(car);

            //UserRepository userRepository = new UserRepository();
            //userRepository.CreateUser(user);

            UserRepository userRepository = new UserRepository();
            User user = userRepository.GetAllUser().First();

            Console.WriteLine(user.Cars[0].ChassisNumber);

            Console.ReadKey();
        }
    }
}
