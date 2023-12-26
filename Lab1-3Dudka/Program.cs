Console.WriteLine("Введите n");
long n = Convert.ToInt64(Console.ReadLine());
long hours = n / 3600;
long minutes = (n % 3600) / 60;
long seconds = (n % 3600) % 60;
Console.WriteLine($"часы {hours}");
Console.WriteLine($"минуты {minutes}");
Console.WriteLine($"секунды {seconds}");
