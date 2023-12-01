namespace myschoolDataBase
{
    public class DataBase : IDataBase
    {
        public void AddStudent(string name, int age, string email, string address, string UserType)
        {
            var users = new User
            {
                Name = name;
                Age = age;
                Email = email;
                Address = address;
                UserType = "Student";
            }

            User.Add(users);
            System.Console.WriteLine("Student added successfully");
        }
        public void AddTeacher(string name, int age, string email, string address, string UserType)
        {
            var teacher = new User
            {
                tName = name;
                tAge = age;
                tEmail = email;
                tAddress = address;
                tUserType = "Teacher";
            };

            User.Add(teacher);
            System.Console.WriteLine("Teacher added successfully");
            
        }
        public void SearchUser(string name)
        {
            var user = FindUsers();
            if (user != null)
            {
                 Print(user);
            }
            else 
            {
                Console.WriteLine("User does not exist");
            }
        }
        public void DeleteUser(string name)
        {
            var user = FindUsers();
            if (user != null)
            {
                 User.Remove(user);
            }
            else 
            {
                Console.WriteLine("User does not exist");
            }
        }
        public void FindUsers(string username)
        {
            return User.FindUsers(u => u.Name = name);
        }
        public void Print(User user)
        {
             Console.WriteLine($"name : {user.Name}\nAge: {user.Age}\nEmail : {user.Email}\nAddress : {user.Address}\nUserType : {user.UserType}");
        }
    }
}