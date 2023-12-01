namespace myschoolDataBase
{
    public class Menu
    {
        private SchoolDatabase schoolDb;

        public Menu(SchoolDatabase schoolDb)
        {
            this.schoolDb = schoolDb;
        }

        public void DisplayMainMenu()
        {
            Console.WriteLine("====Main Menu====");
            Console.WriteLine("Welcome to the school database!");
            Console.WriteLine("1.Enter 1 to Add Student Details");
            Console.WriteLine("2.Enter 2 to Add Teacher Details");
            Console.WriteLine("3.Enter 3 to Search User");
            Console.WriteLine("4.Enter 4 to Delete User");
            Console.WriteLine("5.Enter 0 to Exit User");
        }

        public void HandleChoice()
        {
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudentDetails();
                    Console.Write("Enter student name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter student age: ");
                    int age = int.Parse(Console.ReadLine());

                    Console.Write("Enter student email: ");
                    string email = Console.ReadLine();

                    Console.Write("Enter student address: ");
                    string address = Console.ReadLine();
                    string userTypr = "student";
                    Student student = new Student(name, age, email, address);
                    schoolDb.AddStudent(student);

                    Console.WriteLine("Student details added successfully.");
                break;

                case 2:
                    AddTeacherDetails();
                    Console.Write("Enter teacher name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter teacher age: ");
                    int age = int.Parse(Console.ReadLine());

                    Console.Write("Enter teacher email: ");
                    string email = Console.ReadLine();

                    Console.Write("Enter teacher address: ");
                    string address = Console.ReadLine();
                    string userTypr = "teacher";
                    Teacher student = new Teacher(name, age, email, address);
                    schoolDb.AddTeacher(teacher);

                    Console.WriteLine("Teacher details added successfully.");
                break;
                case 3:
                    Console.WriteLine("Enter student name or teacher name you want to search for: ");
                    string usersearch = Console.ReadLine()!;
                    schoolDb.SearchUser(usersearch);
                    break;
                case 4:
                    Console.WriteLine("Enter student name or teacher name you want to delete for: ");
                    string userDelete = Console.ReadLine()!;
                    schoolDb.DeleteUser(userDelete);
                    schoolDb.DeleteUsers();
                break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

        
    }



}