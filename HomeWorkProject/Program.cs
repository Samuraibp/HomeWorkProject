namespace HomeWorkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ===== Задание 1 =====
            Console.WriteLine("Задание 1:");
            DrawSquare(5, '*');

            // ===== Задание 2 =====
            Console.WriteLine("\nЗадание 2:");
            Console.WriteLine(IsPalindrome(1221)); // true
            Console.WriteLine(IsPalindrome(7854)); // false

            // ===== Задание 3 =====
            Console.WriteLine("\nЗадание 3:");
            int[] original = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filter = { 6, 88, 7 };
            int[] result = FilterArray(original, filter);
            Console.WriteLine(string.Join(" ", result));

            // ===== Задание 4 =====
            Console.WriteLine("\nЗадание 4:");
            Website site = new Website();
            site.Input();
            site.Output();

            // ===== Задание 5 =====
            Console.WriteLine("\nЗадание 5:");
            Journal journal = new Journal();
            journal.Input();
            journal.Output();

            // ===== Задание 6 =====
            Console.WriteLine("\nЗадание 6:");
            Shop shop = new Shop();
            shop.Input();
            shop.Output();

            // ===== Задание 7 =====
            Console.WriteLine("\nЗадание 7:");
            Reservoir reservoir = new Reservoir(100, "Сталь");
            reservoir.Fill(120);
            reservoir.Empty(30);
            reservoir.Info();
        }

        //  Задание 1 
        static void DrawSquare(int sideLength, char symbol)
        {
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        //  Задание 2 
        static bool IsPalindrome(int number)
        {
            string original = number.ToString();
            char[] arr = original.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);

            return original == reversed;
        }

        //  Задание 3 
        static int[] FilterArray(int[] original, int[] filter)
        {
            List<int> result = new List<int>();

            foreach (int item in original)
            {
                if (!filter.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }
    }

    //  Задание 4 
    class Website
    {
        private string name;
        private string path;
        private string description;
        private string ip;

        public void Input()
        {
            Console.Write("Название: ");
            name = Console.ReadLine();

            Console.Write("Путь: ");
            path = Console.ReadLine();

            Console.Write("Описание: ");
            description = Console.ReadLine();

            Console.Write("IP: ");
            ip = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine($"Название: {name}");
            Console.WriteLine($"Путь: {path}");
            Console.WriteLine($"Описание: {description}");
            Console.WriteLine($"IP: {ip}");
        }
    }

    //  Задание 5 
    class Journal
    {
        private string name;
        private int year;
        private string description;
        private string phone;
        private string email;

        public void Input()
        {
            Console.Write("Название: ");
            name = Console.ReadLine();

            Console.Write("Год основания: ");
            year = int.Parse(Console.ReadLine());

            Console.Write("Описание: ");
            description = Console.ReadLine();

            Console.Write("Телефон: ");
            phone = Console.ReadLine();

            Console.Write("Email: ");
            email = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine($"Название: {name}");
            Console.WriteLine($"Год: {year}");
            Console.WriteLine($"Описание: {description}");
            Console.WriteLine($"Телефон: {phone}");
            Console.WriteLine($"Email: {email}");
        }
    }

    //  Задание 6 
    class Shop
    {
        private string name;
        private string address;
        private string profile;
        private string phone;
        private string email;

        public void Input()
        {
            Console.Write("Название: ");
            name = Console.ReadLine();

            Console.Write("Адрес: ");
            address = Console.ReadLine();

            Console.Write("Профиль: ");
            profile = Console.ReadLine();

            Console.Write("Телефон: ");
            phone = Console.ReadLine();

            Console.Write("Email: ");
            email = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine($"Название: {name}");
            Console.WriteLine($"Адрес: {address}");
            Console.WriteLine($"Профиль: {profile}");
            Console.WriteLine($"Телефон: {phone}");
            Console.WriteLine($"Email: {email}");
        }
    }

    //  Задание 7 
    class Reservoir
    {
        private double volume;
        private string material;
        private double currentVolume;

        public Reservoir(double volume)
        {
            this.volume = volume;
            material = "Неизвестно";
            currentVolume = 0;
        }

        public Reservoir(double volume, string material)
        {
            this.volume = volume;
            this.material = material;
            currentVolume = 0;
        }

        public Reservoir(double volume, string material, bool isFull)
        {
            this.volume = volume;
            this.material = material;
            currentVolume = isFull ? volume : 0;
        }

        public void Fill(double amount)
        {
            if (currentVolume + amount > volume)
            {
                Console.WriteLine("Переполнение! Резервуар заполнен до максимума.");
                currentVolume = volume;
            }
            else
            {
                currentVolume += amount;
            }
        }

        public void Empty(double amount)
        {
            if (currentVolume - amount < 0)
            {
                Console.WriteLine("Резервуар пуст.");
                currentVolume = 0;
            }
            else
            {
                currentVolume -= amount;
            }
        }

        public void Info()
        {
            Console.WriteLine($"Объем: {volume}");
            Console.WriteLine($"Материал: {material}");
            Console.WriteLine($"Текущий объем: {currentVolume}");
        }
    }
    
}
