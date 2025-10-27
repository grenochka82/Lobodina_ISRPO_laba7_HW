//using System;

//class Car
//{
//    public string Model;
//    public int Speed;
//    public int MaxSpeed;
//    public Car(string model, int maxSpeed)
//    {
//        this.Model = model;
//        this.MaxSpeed = maxSpeed;
//        this.Speed = 0;
//    }
//    public void Accelerate(int delta)
//    {
//        if (delta > 0)
//        {
//            this.Speed += delta;
//            if (this.Speed > this.MaxSpeed)
//            {
//                this.Speed = this.MaxSpeed;
//            }
//            Console.WriteLine($"Модель: {this.Model}, Текущая скорость: {this.Speed} км/ч");
//        }
//    }
//    public void Brake()
//    {
//        this.Speed = 0;
//        Console.WriteLine($"После торможения: {this.Speed} км/ч");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Car car = new Car("Tesla Model S", 250);

//        car.Accelerate(120);
//        car.Brake();
//    }
//}