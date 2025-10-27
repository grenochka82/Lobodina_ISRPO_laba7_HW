//namespace Plotnikova_Anna_ISP_232_Homework_Lab7_ISRPO
//{
//    internal class Program
//    {
//        static void Main(string[] args)
           
//        {
//            static void Main(string[] args)
//            {
//                Console.WriteLine("=== ТЕСТИРОВАНИЕ ВСЕХ КЛАССОВ ===\n");
//                Console.WriteLine("1. ТЕСТ КЛАССА BOOK:");
//                Book book1 = new Book();
//                Book book2 = new Book("Война и мир", "Толстой", 1869, true);
//                book1.PrintInfo();
//                book2.PrintInfo();
//                Console.WriteLine("\n2. ТЕСТ КЛАССА BANKACCOUNT:");
//                BankAccount account = new BankAccount("1234567890");
//                account.Deposit(1000);
//                account.Withdraw(500);
//                account.PrintBalance();
//                Console.WriteLine("\n3. ТЕСТ КЛАССА CAR:");
//                Car car = new Car("Tesla Model S", 250);
//                car.Accelerate(120);
//                car.Brake();
//                Console.WriteLine("\n4. ТЕСТ КЛАССА DICE:");
//                Dice dice6 = new Dice();
//                Dice dice12 = new Dice(12);
//                Console.Write("6-гранный кубик: ");
//                for (int i = 0; i < 3; i++) Console.Write(dice6.Roll() + " ");
//                Console.Write("\n12-гранный кубик: ");
//                for (int i = 0; i < 3; i++) Console.Write(dice12.Roll() + " ");
//                Console.WriteLine();
//                Console.WriteLine("\n5. ТЕСТ КЛАССА CHARACTER:");
//                Character warrior = new Character("Воин", 100, 20);
//                Character mage = new Character("Маг", 60, 100);
//                Character archer = new Character("Лучник", 80, 40);
//                warrior.PrintInfo();
//                warrior.Attack();
//                mage.PrintInfo();
//                mage.Attack();
//                archer.PrintInfo();
//                archer.Attack();
//            }
//        }
//        class Book
//        {
//            public string Title;
//            public string Author;
//            public int Year;
//            public bool IsAvailable;
//            public Book()
//            {
//                Title = "Неизвестно";
//                Author = "Неизвестен";
//                Year = 0;
//                IsAvailable = false;
//            }
//            public Book(string title, string author, int year, bool isAvailable)
//            {
//                this.Title = title;
//                this.Author = author;
//                this.Year = year;
//                this.IsAvailable = isAvailable;
//            }
//            public void PrintInfo()
//            {
//                string availability = IsAvailable ? "Да" : "Нет";
//                Console.WriteLine($"Название: \"{Title}\", Автор: {Author}, Год: {Year}, Доступна: {availability}");
//            }
//        }
//        class BankAccount
//        {
//            public string AccountNumber;
//            private decimal balance;

//            public BankAccount(string accountNumber, decimal initialBalance = 0)
//            {
//                this.AccountNumber = accountNumber;
//                this.balance = initialBalance;
//            }

//            public void Deposit(decimal amount)
//            {
//                if (amount > 0)
//                {
//                    this.balance += amount;
//                    Console.WriteLine($"Пополнение: {amount} руб.");
//                }
//            }

//            public void Withdraw(decimal amount)
//            {
//                if (amount > 0 && amount <= this.balance)
//                {
//                    this.balance -= amount;
//                    Console.WriteLine($"Снятие: {amount} руб.");
//                }
//                else
//                {
//                    Console.WriteLine("Недостаточно средств!");
//                }
//            }

//            public void PrintBalance()
//            {
//                Console.WriteLine($"Текущий баланс: {this.balance} руб.");
//            }
//        }

//        class Car
//        {
//            public string Model;
//            public int Speed;
//            public int MaxSpeed;

//            public Car(string model, int maxSpeed)
//            {
//                this.Model = model;
//                this.MaxSpeed = maxSpeed;
//                this.Speed = 0;
//            }

//            public void Accelerate(int delta)
//            {
//                if (delta > 0)
//                {
//                    this.Speed += delta;
//                    if (this.Speed > this.MaxSpeed)
//                    {
//                        this.Speed = this.MaxSpeed;
//                    }
//                    Console.WriteLine($"Модель: {this.Model}, Текущая скорость: {this.Speed} км/ч");
//                }
//            }

//            public void Brake()
//            {
//                this.Speed = 0;
//                Console.WriteLine($"После торможения: {this.Speed} км/ч");
//            }
//        }

//        class Dice
//        {
//            private int _sides;
//            private Random random;

//            public Dice(int sides = 6)
//            {
//                this._sides = sides;
//                this.random = new Random();
//            }

//            public int Roll()
//            {
//                return random.Next(1, _sides + 1);
//            }
//        }

//        class Character
//        {
//            public int Health;
//            public int Mana;
//            public string Name;

//            public Character(string name, int health, int mana)
//            {
//                this.Name = name;
//                this.Health = health;
//                this.Mana = mana;
//            }

//            public void Attack()
//            {
//                Console.WriteLine($"{this.Name} атакует!");
//            }

//            public void PrintInfo()
//            {
//                Console.WriteLine($"{this.Name}: Здоровье = {this.Health}, Мана = {this.Mana}");
//            }
//        }
//    }
//}
    
