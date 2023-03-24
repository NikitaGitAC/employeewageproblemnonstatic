using static Employeewage_problemoop.empcheck;

namespace Employeewage_problemoop
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation problem");
            EmpAttendence Attendance = new EmpAttendence();
            Attendance.EmployeeCheck();
        }
    }
}