using Students;

List<Student> students = new List<Student>();

string input = Console.ReadLine();

while (input != "end")
{
    string[] studentComponents = input.Split(' ');
    string firstName = studentComponents[0];
    string lastName = studentComponents[1];
    int age = int.Parse(studentComponents[2]);
    string homeTown = studentComponents[3];

    Student currentStudent = new Student
    {
        FirstName = firstName,
        LastName = lastName,
        Age = age,
        HomeTown = homeTown,
    };

    students.Add(currentStudent);

    input = Console.ReadLine();
}

string neededTown = Console.ReadLine();

foreach (Student student in students.Where(s => s.HomeTown == neededTown))
{
    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
}