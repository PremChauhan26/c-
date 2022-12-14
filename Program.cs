namespace FinalExam_200528741;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Final Exam!");
        Student pupil = new Student();
        Resource resourceA = new Resource();
        Resource resourceB = new Resource();
        pupil.SchoolId = 40526183;
        resourceA.Code = "abc";
        resourceA.Title = "Final exam";
        resourceA.Description = "Good day";
        resourceA.Publisher = "Prem";
        resourceB.Code = "xyz";
        resourceB.Title = "Final Exam";
        resourceB.Description = "Good Day";
        resourceB.Publisher = "Prem";
        List<Resource> resources = new List<Resource>();
        resources.Add(resourceA);
        resources.Add(resourceB);
        Borrowing borrowing = new Borrowing("40526183" , resources);
        borrowing.StartDate = new DateTime(2022, 12,13,08,37,00);
        borrowing.EndDate = new DateTime(2022, 22,13,08,37,00);
    }
}
