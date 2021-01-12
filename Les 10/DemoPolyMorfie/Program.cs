using System;

namespace DemoPolyMorfie
{
    class Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Vehicle Drive");
        }


        public virtual void Brake()
        {
           Console.WriteLine("Vehicle Brake");
        }
    }

    class Car : Vehicle
    {
        public new void Drive()
        {
            Console.WriteLine("Car Drive");
        }

        public override void Brake()
        {
            base.Brake();
            Console.WriteLine("Car Brake");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Vehicle v = new Vehicle();
            Vehicle vc = new Car();

            c.Drive();
            v.Drive();
            vc.Drive();

            c.Brake();
            v.Brake();
            vc.Brake();

            switch (vc)
            {
                case Car car:
                    car.Drive();
                    break;
                case Vehicle vehicle:
                    vehicle.Drive();
                    break;
            }


            if(c is Car)
            {
                Car car = (Car)c;
                car.Drive();
            }
        }
    }
}
