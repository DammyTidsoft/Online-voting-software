namespace myschoolDataBase
{
    public interface IDataBase
    {
        void AddStudent(string name, int age, string email, string address, string UserType);
        void AddTeacher(string name, int age, string email, string address, string UserType);
        void SearchUser(string name);
        void DeleteUser(string name);
        void FindUsers(string username);
        void Print(User user);
    }
}