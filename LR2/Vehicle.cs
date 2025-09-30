namespace LR2
{
    public abstract class Vehicle
    {
        private int x, y;
        private int price, speed, year;
        public Vehicle(int x, int y, int price, int speed, int year)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
        public virtual void print()
        {
            Console.WriteLine($"Координаты: x={x}, y={y}");
            Console.WriteLine($"Цена: {price}, Скорость: {speed}, Год выпуска: {year}");
        }
    }
    public class Plane : Vehicle
    {
        int height, passengers;
        public Plane(int x, int y, int price, int speed, int year, int height, int passengers) : base(x, y, price, speed, year)
        {
            this.height = height;
            this.passengers = passengers;
        }
        public override void print()
        {
            Console.WriteLine("Plane");
            base.print();
            Console.WriteLine($"Высота: {height}, Кол-во пассажиров: {passengers}");
        }
    }
    public class Ship : Vehicle
    {
        string port;
        int passengers;
        public Ship(int x, int y, int price, int speed, int year, string port, int passengers) : base(x, y, price, speed, year)
        {
            this.port = port;
            this.passengers= passengers;
        }
        public override void print()
        {
            Console.WriteLine("Ship");
            base.print();
            Console.WriteLine($"Порт приписки: {port}, Кол-во пассажиров: {passengers}");
        }
    }
    public class Car : Vehicle
    {
        public Car(int x, int y, int price, int speed, int year) : base(x, y, price, speed, year) { }
        public override void print()
        {
            Console.WriteLine("Car");
            base.print();
        }
    }
}
