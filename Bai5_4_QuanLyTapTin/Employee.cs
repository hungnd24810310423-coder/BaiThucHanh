namespace Bai5_4_QuanLyTapTin
{
    public class Employee
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string JoinDate { get; set; }
        public string Department { get; set; }
        public string Group { get; set; }

        public Employee(string id, string fullName, string position,
                        string joinDate, string department, string group)
        {
            Id = id;
            FullName = fullName;
            Position = position;
            JoinDate = joinDate;
            Department = department;
            Group = group;
        }
    }
}
