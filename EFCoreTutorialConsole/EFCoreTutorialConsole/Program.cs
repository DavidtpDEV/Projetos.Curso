// See https://aka.ms/new-console-template for more information

using EFCoreTutorialConsole;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using EFCoreTutorialConsole;

using (var context = new SchoolContext())
{

    // Criar o db se não exisitr
    context.Database.EnsureCreated();

    //Entrada de dois objetos
    var grd1 = new Grade() { GradeName = "Full Stack Asp.NET" };
    var std1 = new Student() { FirstName = "David", LastName = "Milani", Grade = grd1 };


    //Add student para o context
    context.Students.Add(std1);

    //Salvar os dados para a tabela
    context.SaveChanges();
    foreach (var s in context.Students)
    {
        Console.WriteLine($"FIrst NAme: {s.FirstName}, Last Name: {s.LastName}");
    }
}