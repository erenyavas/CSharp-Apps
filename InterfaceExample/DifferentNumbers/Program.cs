using DifferentNumbers;

Console.WriteLine("Hangi sayı türünü kontrol etmek istiyorsunuz?");
Console.WriteLine("1. Mükemmel Sayı");
Console.WriteLine("2. Asal Sayı");
Console.Write("Seçiminiz (1 veya 2): ");
var typeChoice = Console.ReadLine();

InterfaceNumberTypeChecker checker;
if (typeChoice == "1")
{
    checker = new PerfectNumberChecker();
}
else if (typeChoice == "2")
{
    checker = new PrimeNumberChecker();
}
else
{
    Console.WriteLine("Geçersiz seçim!");
    return;
}

Console.WriteLine("\nNe yapmak istiyorsunuz?");
Console.WriteLine("1. Belirli bir aralıktaki tüm uyan sayıları bulun");
Console.WriteLine("2. Belirli bir sayının seçilen türde olup olmadığını kontrol edin");
Console.WriteLine("3. İlk 5 bu türdeki sayıyı yazdır");
Console.Write("Seçiminiz (1, 2 veya 3): ");
var methodChoice = Console.ReadLine();

if (methodChoice == "1")
{
    Console.Write("Başlangıç değeri: ");
    int start = int.Parse(Console.ReadLine());
    Console.Write("Bitiş değeri: ");
    int end = int.Parse(Console.ReadLine());
    var numbersInRange = checker.GetAllNumbersInRange(start, end);
    Console.WriteLine($"Aralıktaki sayılar {start}-{end}: " + string.Join(", ", numbersInRange));
}else if(methodChoice == "2")
{
    Console.Write("Kontrol edilecek sayı: ");
    int number = int.Parse(Console.ReadLine());
    bool isNumberType = checker.IsNumberType(number);
    if (isNumberType)
    {
        Console.WriteLine($"{number} seçtiğiniz türde bir sayıdır.");
    }
    else
    {
        Console.WriteLine($"{number} seçtiğiniz türde bir sayı değilidir.");
    }
    
}
else if (methodChoice == "3")
{
    var first5Numbers = checker.GetFirst5Numbers();
    Console.WriteLine("İlk 5 sayı: " + string.Join(", ", first5Numbers));
}
else
{
    Console.WriteLine("Geçersiz seçim!");
}