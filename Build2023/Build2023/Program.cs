using Pair = (int First, int Second);
using Grade = decimal;

var mads = new Student("Mads Torgersen", 900751, [3.5m, 2.9m, 1.8m, .. Grades.Dustin]);

WriteLine(mads.GPA);

public class Student(string name, int id, Grade[] grades) : Person(name)
{
    public string Name { get; set => field = value.Trim(); } = name;
    public int Id => id;

    public Student(string name, int id) : this(name, id, []) { }

    public decimal GPA => grades switch
    {
        [] => 4.0m,
        [var grade] => grade,
        [.. var all] => all.Average()
    };
}
