using LR2;
using System;

class Program
{
    static void Main()
    {
        ClassRoom room = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil(), new GoodPupil());
        room.ShowActivity();
        Console.WriteLine();
        Console.WriteLine();
        Vehicle[] vehicles = {
            new Plane(100, 200, 5000000, 900, 2020, 150, 10000),
            new Car(10, 20, 30000, 180, 2022),
            new Ship(300, 400, 2000000, 50, 2018, "Симферополь", 500)
        };

        foreach (var v in vehicles)
            v.print();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Введите ключ доступа (pro/exp) или нажмите Enter для бесплатной версии:");
        string? key = Console.ReadLine();
        DocumentWorker doc;

        if (key == "pro")
            doc = new ProDocumentWorker();
        else if (key == "exp")
            doc = new ExpertDocumentWorker();
        else
            doc = new DocumentWorker();
        doc.OpenDocument();
        doc.EditDocument();
        doc.SaveDocument();
    }
}