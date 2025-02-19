//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace task_4
//{
//    internal class Program
//    {
//        static List<Student>students = new List<Student>();
//        static List<Degree_program>degree = new List<Degree_program>();
//        static void Main(string[] args)
//        {
//            int option = Menu();
//            while(option != 8)
//            {
//                switch(option)
//                {
//                    case 1:
//                        Console.WriteLine("Enter your name: ");
//                        string name = Console.ReadLine();
//                        Console.WriteLine("Enter your age: ");
//                        int age = int.Parse(Console.ReadLine());
//                        Console.WriteLine("Enter your markss in Fsc: ");
//                        double fsc_marks = int.Parse(Console.ReadLine());
//                        Console.WriteLine("Enter your marks in matric: ");
//                        double matric_marks = int.Parse(Console.ReadLine());
//                        Student student = new Student(name, age, fsc_marks, matric_marks);
//                        students.Add(student);
//                        break;
//                    case 2:
//                        Console.WriteLine("Enter degree name: ");
//                        string degree_name = Console.ReadLine();
//                        Console.WriteLine("Enter degree duratiion: ");
//                        int duration = int.Parse(Console.ReadLine());
//                        Console.WriteLine("Enter seats for degree: ");
//                        int seats = int.Parse(Console.ReadLine());
//                        Console.WriteLine("Enter how many subjectsto enter: ");
//                        int no_of_subject= int.Parse(Console.ReadLine());
//                        Console.WriteLine("Enter subject code: ");
//                        string sub_code = Console.ReadLine();
//                        Console.WriteLine("Enter dunject type: ");
//                        string sub_type =  Console.ReadLine();
//                        Console.WriteLine("Enter credit hours: ");
//                        int credit_hours = int.Parse(Console.ReadLine());
//                        Console.WriteLine("enter subject fees: ");
//                        int sub_fees = int.Parse(Console.ReadLine());
//                        Degree_program degree_program = new Degree_program(degree_name, duration, seats, no_of_subject, sub_code, sub_type, credit_hours, sub_fees);
//                        degree.Add(degree_program);
//                        break;
//                    case 3://generate merit 
//                        foreach (Student s in students)
//                        {
//                            Console.WriteLine($"Name: {s.Name}  , FSC: {s.FSC_Marks} , matric: {s.Matric_Marks} , aggregate: {s.aggree}");
//                        }
//                        break;
//                    case 4:
//                        foreach (Student s in students)
//                        {
//                            Console.WriteLine($"Name: {s.Name}  , FSC: {s.FSC_Marks} , matric: {s.Matric_Marks}");
//                        }
//                        break;

//                }
//                option = Menu();
//            }
//        }
//        static int Menu()
//        {
//            Console.WriteLine("1.Add Student.");
//            Console.WriteLine("2.Add degree program.");
//            Console.WriteLine("3.generate merit list.");
//            Console.WriteLine("4.View registered students.");
//            Console.WriteLine("5.view students of Program.");
//            Console.WriteLine("6.Register subjects for a specific students.");
//            Console.WriteLine("7.Calculate fees for all registered students.");
//            Console.WriteLine("8.Exit.");
//            Console.WriteLine("Enter your option: ");
//            int option = int.Parse(Console.ReadLine());
//            return option;
//        }

//    }
//}


using System;
using System.Collections.Generic;

// Main Program
class Program
{
    static List<DegreeProgram> degreePrograms = new List<DegreeProgram>();
    static List<Student> students = new List<Student>();
    static List<Subject> subjects = new List<Subject>();

    static void Main(string[] args)
    {
        InitializeData(); // Pre-populate some data for testing

        while (true)
        {
            DisplayMainMenu();
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    AddDegreeProgram();
                    break;
                case 3:
                    GenerateMerit();
                    break;
                case 4:
                    DisplayRegisteredStudents();
                    break;
                case 5:
                    DisplaySpecificDegreeStudents();
                    break;
                case 6:
                    RegisterSubjects();
                    break;
                case 7:
                    GenerateFee();
                    break;
                case 8:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayMainMenu()
    {
        Console.WriteLine("\n--- Main Menu ---");
        Console.WriteLine("1. Add Student");
        Console.WriteLine("2. Add Degree Program");
        Console.WriteLine("3. Generate Merit");
        Console.WriteLine("4. Registered Students");
        Console.WriteLine("5. Specific Degree Students");
        Console.WriteLine("6. Register Subjects");
        Console.WriteLine("7. Generate Fee");
        Console.WriteLine("8. Exit");
        Console.Write("Enter your choice: ");
    }

    static void AddStudent()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        Console.Write("Enter student CNIC: ");
        string cnic = Console.ReadLine();

        Console.WriteLine("Available Degree Programs:");
        foreach (var Program in degreePrograms)
        {
            Console.WriteLine(Program.Name);
        }

        Console.Write("Enter degree program name: ");
        string degreeName = Console.ReadLine();
        DegreeProgram program = degreePrograms.Find(p => p.Name == degreeName);

        if (program != null)
        {
            Student student = new Student(name, cnic, program);
            students.Add(student);
            program.AddStudent(student);
            Console.WriteLine("Student added successfully!");
        }
        else
        {
            Console.WriteLine("Degree program not found.");
        }
    }

    static void AddDegreeProgram()
    {
        Console.Write("Enter degree program name: ");
        string name = Console.ReadLine();
        Console.Write("Enter required credits: ");
        int credits = int.Parse(Console.ReadLine());

        DegreeProgram program = new DegreeProgram(name, credits);
        degreePrograms.Add(program);
        Console.WriteLine("Degree program added successfully!");
    }

    static void GenerateMerit()
    {
        // Placeholder for merit generation logic
        Console.WriteLine("Merit list generated (placeholder).");
    }

    static void DisplayRegisteredStudents()
    {
        Console.WriteLine("\n--- Registered Students ---");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    static void DisplaySpecificDegreeStudents()
    {
        Console.Write("Enter degree program name: ");
        string degreeName = Console.ReadLine();
        DegreeProgram program = degreePrograms.Find(p => p.Name == degreeName);

        if (program != null)
        {
            Console.WriteLine($"\n--- Students in {program.Name} ---");
            foreach (var student in program.Students)
            {
                Console.WriteLine(student);
            }
        }
        else
        {
            Console.WriteLine("Degree program not found.");
        }
    }

    static void RegisterSubjects()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        Student student = students.Find(s => s.Name == name);

        if (student != null)
        {
            Console.WriteLine("Available Subjects:");
            foreach (var Subject in subjects)
            {
                Console.WriteLine(Subject);
            }

            Console.Write("Enter subject code: ");
            string code = Console.ReadLine();
            Subject subject = subjects.Find(s => s.Code == code);

            if (subject != null)
            {
                student.RegisterSubject(subject);
                Console.WriteLine("Subject registered successfully!");
            }
            else
            {
                Console.WriteLine("Subject not found.");
            }
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    static void GenerateFee()
    {
        Console.WriteLine("\n--- Fee Generation ---");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name}: {student.TotalFee}");
        }
    }

    static void InitializeData()
    {
        // Pre-populate some data for testing
        degreePrograms.Add(new DegreeProgram("Computer Science", 130));
        degreePrograms.Add(new DegreeProgram("Electrical Engineering", 140));

        subjects.Add(new Subject("CS101", "Introduction to Programming", 5000));
        subjects.Add(new Subject("CS102", "Data Structures", 6000));
        subjects.Add(new Subject("EE101", "Circuit Analysis", 5500));
    }
}

// Student Class
class Student
{
    public string Name { get; set; }
    public string CNIC { get; set; }
    public DegreeProgram DegreeProgram { get; set; }
    public List<Subject> RegisteredSubjects { get; set; }
    public double TotalFee { get; set; }

    public Student(string name, string cnic, DegreeProgram degreeProgram)
    {
        Name = name;
        CNIC = cnic;
        DegreeProgram = degreeProgram;
        RegisteredSubjects = new List<Subject>();
        TotalFee = 0;
    }

    public void RegisterSubject(Subject subject)
    {
        RegisteredSubjects.Add(subject);
        TotalFee += subject.Fee;
    }

    public override string ToString()
    {
        return $"Name: {Name}, CNIC: {CNIC}, Degree Program: {DegreeProgram.Name}, Registered Subjects: {RegisteredSubjects.Count}, Total Fee: {TotalFee}";
    }
}

// DegreeProgram Class
class DegreeProgram
{
    public string Name { get; set; }
    public int RequiredCredits { get; set; }
    public List<Student> Students { get; set; }

    public DegreeProgram(string name, int requiredCredits)
    {
        Name = name;
        RequiredCredits = requiredCredits;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public override string ToString()
    {
        return $"Degree Program: {Name}, Required Credits: {RequiredCredits}, Students: {Students.Count}";
    }
}

// Subject Class
class Subject
{
    public string Code { get; set; }
    public string Name { get; set; }
    public double Fee { get; set; }

    public Subject(string code, string name, double fee)
    {
        Code = code;
        Name = name;
        Fee = fee;
    }

    public override string ToString()
    {
        return $"Subject Code: {Code}, Name: {Name}, Fee: {Fee}";
    }
}