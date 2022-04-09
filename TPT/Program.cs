using TPT;
using TPT.Models;

Console.WriteLine("***** Table Per Type *****");

using (ApplicationContext db = new ApplicationContext())
{
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    db.Users.AddRange(
        new User { Name = "GreedNeSS" },
        new User { Name = "Marcus" },
        new User { Name = "Henry" });

    db.Managers.AddRange(
        new Manager { Name = "Tom", Departament = "IT" },
        new Manager { Name = "Terry", Departament = "Sales" });

    db.Employees.AddRange(
        new Employee { Name = "Alise", Salary = 3000 },
        new Employee { Name = "Margo", Salary = 4000 });

    db.SaveChanges();
}

using (ApplicationContext db = new ApplicationContext())
{
    Console.WriteLine("\n=> Users");
    ShowObjectList(db.Users.ToList());
    Console.WriteLine("\n=> Employees");
    ShowObjectList(db.Employees.ToList());
    Console.WriteLine("\n=> Managers");
    ShowObjectList(db.Managers.ToList());
}

void ShowObjectList<T>(List<T> objList)
{
    foreach (T obj in objList)
    {
        Console.WriteLine(obj);
    }
}