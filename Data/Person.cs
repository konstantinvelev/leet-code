public class Person
{
    public string FirstName { get; set; }
    public required string LastName { get; set; }
    public int Age { get; set; }

    public static List<Person> People()
    {
        return new List<Person>
            {
                new() { FirstName = "Ivan", LastName = "Petrov", Age = 18 },
                new() { FirstName = "Georgi", LastName = "Ivanov", Age = 22 },
                new() { FirstName = "Maria", LastName = "Dimitrova", Age = 27 },
                new() { FirstName = "Petar", LastName = "Georgiev", Age = 31 },
                new() { FirstName = "Elena", LastName = "Nikolova", Age = 19 },
                new() { FirstName = "Nikolay", LastName = "Todorov", Age = 45 },
                new() { FirstName = "Desislava", LastName = "Koleva", Age = 38 },
                new() { FirstName = "Martin", LastName = "Iliev", Age = 24 },
                new() { FirstName = "Kristina", LastName = "Vasileva", Age = 29 },
                new() { FirstName = "Daniel", LastName = "Angelov", Age = 41 },
                new() { FirstName = "Borislav", LastName = "Hristov", Age = 35 },
                new() { FirstName = "Radoslava", LastName = "Stoyanova", Age = 26 },
                new() { FirstName = "Teodor", LastName = "Pavlov", Age = 33 },
                new() { FirstName = "Simona", LastName = "Ruseva", Age = 21 },
                new() { FirstName = "Viktor", LastName = "Marinov", Age = 50 },
                new() { FirstName = "Yoana", LastName = "Popova", Age = 30 },
                new() { FirstName = "Kalin", LastName = "Dobrev", Age = 28 },
                new() { FirstName = "Mihail", LastName = "Yordanov", Age = 37 },
                new() { FirstName = "Ani", LastName = "Zlateva", Age = 23 },
                new() { FirstName = "Stefan", LastName = "Mihaylov", Age = 43 },
                new() { FirstName = "Gergana", LastName = "Pencheva", Age = 20 },
                new() { FirstName = "Atanas", LastName = "Kostov", Age = 39 },
                new() { FirstName = "Iveta", LastName = "Dancheva", Age = 32 },
                new() { FirstName = "Plamen", LastName = "Borisov", Age = 47 },
                new() { FirstName = "Monika", LastName = "Kirilova", Age = 25 }
            };
    }
}
