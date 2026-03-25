using Domain;

namespace ExercicesLinq;

internal class Program
{
    static void Main(string[] args)
    {
        DataContext dc = new DataContext();

        foreach (Student student in dc.Students)
        {
            Console.WriteLine(student.Last_Name);
        }
    }
}
